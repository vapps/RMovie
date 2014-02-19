using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RMovie.PCL.Models;
using SignalR.Client.Hubs;
using System.Collections.ObjectModel;
using RMovie.PCL.Commons;
using System.Net.Http;
using Newtonsoft.Json;

namespace RMovie.StoreApp.ViewModels
{
    public class SeatSelectViewModel : RMovie.PCL.ViewModels.SeatChoiceViewModel
    {
        HubConnection hubConnection;
        IHubProxy rMovieHub;

        private string clientCount;
        /// <summary>
        /// 클라이언트 수
        /// </summary>
        public string ClientCount
        {
            get { return clientCount; }
            set 
            { 
                clientCount = value;
                OnPropertyChanged("ClientCount");
            }
        }

        private ObservableCollection<string> systemMessageCollection;
        /// <summary>
        /// 시스템 메시지 컬렉션
        /// </summary>
        public ObservableCollection<string> SystemMessageCollection
        {
            get { return systemMessageCollection; }
            set
            {
                systemMessageCollection = value;
                OnPropertyChanged("SystemMessageCollection");
            }
        }

        private string choiceSeats;
        /// <summary>
        /// 선택한 좌석들
        /// </summary>
        public string ChoiceSeats
        {
            get { return choiceSeats; }
            set 
            { 
                choiceSeats = value;
                OnPropertyChanged("ChoiceSeats");
            }
        }


        /////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// 생성자
        /// </summary>
        public SeatSelectViewModel()
        {
            SystemMessageCollection = new ObservableCollection<string>();
            if (Windows.ApplicationModel.DesignMode.DesignModeEnabled == true)
            {
                ClientCount = "1,000";
                SystemMessageCollection.Add("서버에 접속했습니다.");
                SystemMessageCollection.Add("1111111.");
                SystemMessageCollection.Add("서버에 접속했습니다.");
                SystemMessageCollection.Add("2222222");
                SystemMessageCollection.Add("서버에 접속했습니다.");
                ChoiceSeats = "A1";
            }
        }
        /////////////////////////////////////////////////////////////////////////////////

        public async Task Init()
        {
            //dispatcher
            StaticFunctions.BaseContext = System.Threading.SynchronizationContext.Current;

            GetSeatStateAll();

            hubConnection = new HubConnection("http://localhost:19108/");
            rMovieHub = hubConnection.CreateProxy("rMovieHub");

            rMovieHub.On<SeatModel>("seatStateChange", 
                seat => 
                {
                    var result = this.LineCollection
                                    .SelectMany(p => p.SeatCollection)
                                    .FirstOrDefault(p => p.LineName == seat.LineName
                                                && p.SeatNum == seat.SeatNum);
                    if (result != null)
                    {
                        //내가 선택한 좌석
                        if (seat.ChoiceUser == hubConnection.ConnectionId)
                        {
                            result.SeatState = SeatStateEnum.ChoiceMe;
                            result.ChoiceUser = seat.ChoiceUser;
                        }
                        else
                        {
                            //다른 사람이 선택한 좌석
                            if (seat.ChoiceUser == null || seat.ChoiceUser == "")
                            {
                                //선택자가 없으면 원상복귀
                                result.SeatState = SeatStateEnum.ChoiceNobodyNormal;
                            }
                            else
                            {
                                //선택자가 있으면 다른사람이 선택했다고 표시
                                result.SeatState = SeatStateEnum.ChoiceOther;
                            }
                            result.ChoiceUser = seat.ChoiceUser;
                        }
                        changeChoiceSeats();
                    }
                });

            rMovieHub.On<int>("clientCountChanged", count => ClientCount = count.ToString());

            rMovieHub.On<string>("systemMessage", msg => SystemMessageCollection.Add(msg));

            await hubConnection.Start();
        }

        private void changeChoiceSeats()
        {
            var myChoices = LineCollection
                                .SelectMany(p => p.SeatCollection)
                                .Where(p => p.SeatState == SeatStateEnum.ChoiceMe);
            ChoiceSeats = "";
            foreach (var seat in myChoices)
            {
                ChoiceSeats += string.Format("{0}:{1} ", seat.LineName, seat.SeatNum);
            }
        }

        private async void GetSeatStateAll()
        {
            //http 설정
            var client = new HttpClient();
            var results = await client.GetAsync("http://localhost:19108/api/RMovie");
            if (results.IsSuccessStatusCode == true)
            {
                var resultString = await results.Content.ReadAsStringAsync();
                var datas = JsonConvert.DeserializeObject(resultString, typeof(ObservableCollection<LineModel>)) as ObservableCollection<LineModel>;
                if (datas != null)
                {
                    this.LineCollection = datas;
                }
            }
        }

        private DelegateCommand seatChoiceCommand;
        /// <summary>
        /// 좌석 클릭
        /// </summary>
        public DelegateCommand SeatChoiceCommand
        {
            get 
            {
                //, obj => (obj as SeatModel).SeatState != null && (obj as SeatModel).SeatState == SeatStateEnum.ChoiceOther ? false : true
                if (seatChoiceCommand == null)
                {
                    seatChoiceCommand = new DelegateCommand(
                        obj => 
                        {
                            var seat = obj as SeatModel;
                            if (seat != null)
                            {
                                switch (seat.SeatState)
                                { 
                                    case SeatStateEnum.ChoiceNobodyNormal:
                                        seat.ChoiceUser = hubConnection.ConnectionId;
                                        rMovieHub.Invoke("SetSeatState", seat);
                                        break;
                                    case SeatStateEnum.ChoiceMe:
                                        rMovieHub.Invoke("SetSeatState", seat);
                                        break;
                                    default:
                                        break;
                                }
                            }
                        });
                }
                return seatChoiceCommand; 
            }
        }

    }
}
