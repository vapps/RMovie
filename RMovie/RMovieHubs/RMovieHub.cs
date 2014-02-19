using SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using RMovie.PCL.Models;
using RMovie.PCL.ViewModels;
using RMovie.ViewModels;

namespace RMovie.RMovieHubs
{
    [HubName("rMovieHub")]
    public class RMovieHub : Hub, IConnected, IDisconnect
    {
        private static readonly System.Collections.Concurrent.ConcurrentDictionary<string, object> _connections
            = new System.Collections.Concurrent.ConcurrentDictionary<string, object>();


        public RMovieHub()
        {
            //ViewModelLocator.SeatVM.Init();
        }

        //public void GetSeatStateAll()
        //{
        //    var result = ViewModelLocator.SeatVM.LineCollection;
        //    Caller.seatStateAll(result);
        //}

        public void SetSeatState(SeatModel setSeat)
        {
            var seat = ViewModelLocator.SeatVM.LineCollection
                        .SelectMany(p => p.SeatCollection)
                        .FirstOrDefault(p => p.LineName == setSeat.LineName
                                        && p.SeatNum == setSeat.SeatNum);
            //일단 좌석정보 가지고 오고
            if (seat != null)
            {
                //좌석을 선택한 사람이 동일인이라면 좌석 클리어
                if (seat.ChoiceUser == setSeat.ChoiceUser)
                {
                    seat.SeatState = SeatStateEnum.ChoiceNobodyNormal;
                    seat.ChoiceUser = "";
                    Clients.seatStateChange(seat);
                }
                else
                {
                    if (seat.ChoiceUser == null || seat.ChoiceUser == "")
                    {
                        //선택한 사람이 없어서 동일인이 아닌 것이라면 선택한 사람이 좌석 예약
                        seat.SeatState = SeatStateEnum.ChoiceOther;
                        seat.ChoiceUser = setSeat.ChoiceUser;
                        Clients.seatStateChange(seat);
                    }
                    else
                    { 
                        //선택한 사람이 있는데 다른 사람이 또 선택 한것이라면 메시지 출력
                        Caller.systemMessage("선택하실 수 없는 좌석입니다.");
                    }
                }
            }
            else
            {
                Caller.systemMessage("선택하실 수 없는 좌석입니다.");
            }
        }

        public Task Connect()
        {
            _connections.TryAdd(Context.ConnectionId, null);
            return Clients.clientCountChanged(_connections.Count);
        }

        public Task Reconnect(IEnumerable<string> groups)
        {
            _connections.AddOrUpdate(Context.ConnectionId, null, (key, o) => o);
            return Clients.clientCountChanged(_connections.Count);
        }

        public Task Disconnect()
        {
            //disconnect가 될때 자신이 선택했던 항목들은 모두 돌려 놓는다.
            var seats = ViewModelLocator.SeatVM.LineCollection
                        .SelectMany(p => p.SeatCollection)
                        .Where(p => p.ChoiceUser == Context.ConnectionId);

            foreach (var s in seats)
            {
                s.ChoiceUser = "";
                s.SeatState = SeatStateEnum.ChoiceNobodyNormal;
                Clients.seatStateChange(s);
            }

            object value;
            _connections.TryRemove(Context.ConnectionId, out value);
            return Clients.clientCountChanged(_connections.Count);
        }
    }
}