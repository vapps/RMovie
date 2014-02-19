using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using kaki104.MetroCL.Common;
using kaki104.MetroCL.Models;
using Windows.ApplicationModel;
using Windows.Networking.BackgroundTransfer;
using Windows.Storage;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

namespace kaki104.MetroCL.ViewModel
{
    public class BackgroundViewModel : BindableBase
    {
        /// <summary>
        /// 다운로드 시작시 발생하는 이벤트
        /// </summary>
        public event EventHandler<DownloadOprationItem> StartDownloadEvent;

        private ObservableCollection<DownloadOprationItem> activeDownloads;
        /// <summary>
        /// 현재 백그라운드 다운로드 오퍼레이션들
        /// </summary>
        public ObservableCollection<DownloadOprationItem> ActiveDownloads
        {
            get { return activeDownloads; }
            set
            {
                activeDownloads = value;
                OnPropertyChanged();
            }
        }

        private DownloadOprationItem currentDownloadOperation;
        /// <summary>
        /// 현재 다운로드 오퍼레이션
        /// </summary>
        public DownloadOprationItem CurrentDownloadOperation
        {
            get { return currentDownloadOperation; }
            set 
            { 
                currentDownloadOperation = value;
                OnPropertyChanged();
            }
        }

        private string uriString;
        /// <summary>
        /// 다운로드 Uri
        /// </summary>
        public string UriString
        {
            get { return uriString; }
            set 
            { 
                uriString = value;
                OnPropertyChanged();
            }
        }

        private string fileName;
        /// <summary>
        /// 파일 이름
        /// </summary>
        public string FileName
        {
            get { return fileName; }
            set 
            { 
                fileName = value;
                OnPropertyChanged();
            }
        }
        
        /// <summary>
        /// 생성자
        /// </summary>
        public BackgroundViewModel()
        {
            ActiveDownloads = new ObservableCollection<DownloadOprationItem>();
            if (DesignMode.DesignModeEnabled == true)
            {
                DownloadOprationItem item = new DownloadOprationItem 
                {
                    BytesReceived = 100,
                    TotalBytesToReceive = 1000,
                    DownloadProgressPercent = 10,
                    State = "start"
                };
                ActiveDownloads.Add(item);
                ActiveDownloads.Add(item);
                ActiveDownloads.Add(item);
                ActiveDownloads.Add(item);
                ActiveDownloads.Add(item);
            }
        }

        /// <summary>
        /// 백그라운드 다운로드 복구
        /// </summary>
        /// <returns></returns>
        public async void DiscoverActiveDownloadsAsync()
        {
            try
            {
                //백그라운드 다운로더에서 현재 다운로드 정보를 반환 받아
                //IReadOnlyList<DownloadOperation> downloads = await BackgroundDownloader.GetCurrentDownloadsAsync();

                ////다운로드 카운트가 있으면
                //if (downloads.Count > 0)
                //{
                //    //테스크 리스트를 하나 만들고
                //    List<Task> tasks = new List<Task>();
                //    foreach (DownloadOperation download in downloads)
                //    {
                //        //다운로드를 테스크에 추가하고 - 이 경우에 반환된 데이터는 어떻게 처리되는지 모르겠군
                //        tasks.Add(HandleDownloadAsync(download, false));
                //    }

                //    //모든 테스크가 완료되면 리턴 한다.
                //    await Task.WhenAll(tasks);
                //}
            }
            catch (Exception ex)
            {
            }
        }

        public async Task<DownloadOprationItem> StartDownload(Uri source, string destination, BitmapImage image = null)
        {
            DownloadOprationItem returnData;

            try
            {
                if (destination == null || destination == "")
                {
                    //파일명이 없으면 원본 파일 명을 사용한다.
                    var lastSegment = source.Segments.LastOrDefault();
                    destination = Uri.UnescapeDataString(lastSegment);
                }

                //템프폴더로 다운로드를 받아야함 - 다운로드 폴더는 생성만 가능하고 나머지 기능이 제한됨
                StorageFile destFile = await Windows.Storage.ApplicationData.Current.TemporaryFolder.CreateFileAsync(destination, CreationCollisionOption.FailIfExists);

                BackgroundDownloader downloader = new BackgroundDownloader();
                DownloadOperation download = downloader.CreateDownload(source, destFile);

                // Attach progress and completion handlers.
               returnData = await HandleDownloadAsync(download, true, image);
            }
            catch (Exception ex)
            {
                returnData = null;
            }
            //완료가되면 리턴해주는 것이궁
            return returnData;
        }

        /// <summary>
        /// 다운로드 관리
        /// </summary>
        /// <param name="download"></param>
        /// <param name="start"></param>
        /// <returns></returns>
        public async Task<DownloadOprationItem> HandleDownloadAsync(DownloadOperation download, bool start, BitmapImage image = null)
        {
            //다운로드 아이템 생성
            var downloadItem = new DownloadOprationItem {DownloadOp = download, BaseImage = image };

            try
            {
                // 액티브 다운로드 리스트에 추가
                ActiveDownloads.Add(downloadItem);
                // 이벤트 발생
                if (StartDownloadEvent != null)
                {
                    StartDownloadEvent(this, downloadItem);
                }

                // 프로그래스 콜백 하나 만들고
                Progress<DownloadOperation> progressCallback = new Progress<DownloadOperation>(DownloadProgress);
                if (start)
                {
                    downloadItem.State = downloadItem.DownloadOp.Progress.Status.ToString();
                    // true이면 바로 시작
                    await download.StartAsync().AsTask(downloadItem.CancelToken.Token, progressCallback);
                }
                else
                {
                    downloadItem.State = downloadItem.DownloadOp.Progress.Status.ToString();
                    // false이면 캔슬토큰과 프로그래스만 붙여 놓고
                    await download.AttachAsync().AsTask(downloadItem.CancelToken.Token, progressCallback);
                }

                ResponseInformation response = download.GetResponseInformation();
            }
            catch (TaskCanceledException)
            {
                downloadItem.State = downloadItem.DownloadOp.Progress.Status.ToString();
            }
            catch (Exception ex)
            {
                downloadItem.State = "error " + ex.Message ;
            }
            finally
            {
                //ActiveDownloads.Remove(downloadItem);
                downloadItem.State = downloadItem.DownloadOp.Progress.Status.ToString();
            }
            return downloadItem;
        }

        // 다운로드 프로그래스 처리
        private void DownloadProgress(DownloadOperation download)
        {
            double percent = 100;
            //선택된 다운로드 아이템을 찾고
            var di = ActiveDownloads.FirstOrDefault(p => p.DownloadOp.Guid == download.Guid);

            if (download.Progress.TotalBytesToReceive > 0)
            {
                percent = download.Progress.BytesReceived * 100 / download.Progress.TotalBytesToReceive;
                if (di != null)
                {
                    //다운로드 아이템의 상태, 다운로드 퍼센트, 수신 사이즈, 총 사이즈 입력
                    di.State = download.Progress.Status.ToString();
                    di.DownloadProgressPercent = percent;
                    di.BytesReceived = download.Progress.BytesReceived / 1024;
                    di.TotalBytesToReceive = download.Progress.TotalBytesToReceive / 1024;
                }
            }

            if (download.Progress.HasRestarted && di != null)
            {
                di.State = download.Progress.Status.ToString();
            }

            if (download.Progress.HasResponseChanged && di != null)
            {
                di.State = download.Progress.Status.ToString();
            }
        }

        private ICommand startCommand;
        /// <summary>
        /// 다운로드 스타트
        /// </summary>
        public ICommand StartCommand
        {
            get
            {
                if (startCommand == null)
                {
                    startCommand = new DelegateCommand(
                        async _ =>
                        {
                            await StartDownload(new Uri(UriString), FileName);
                        });
                }
                return startCommand;
            }
        }

        /// <summary>
        /// 셀렉트 체인지 이벤트 처리
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CurrentDownloadOperation = e.AddedItems.FirstOrDefault() as DownloadOprationItem;
            //CheckCanExecuteChanged();
        }

        /// <summary>
        /// 커맨드 사용가능 여부 체크
        /// </summary>
        private void CheckCanExecuteChanged()
        {
            (PauseCommand as DelegateCommand).RaiseCanExecuteChanged();
            (ResumeCommand as DelegateCommand).RaiseCanExecuteChanged();
            (CancelCommand as DelegateCommand).RaiseCanExecuteChanged();
        }

        private DelegateCommand pauseCommand;
        /// <summary>
        /// 일시 정지
        /// </summary>
        public DelegateCommand PauseCommand
        {
            get 
            {
                if (pauseCommand == null)
                {
                    pauseCommand = new DelegateCommand(
                        _ =>
                        {
                            CurrentDownloadOperation.DownloadOp.Pause();
                            //CheckCanExecuteChanged();
                        },
                        _ => IsCurrentDownloadOperation());
                }
                return pauseCommand; 
            }
        }

        private DelegateCommand resumeCommand;
        /// <summary>
        /// 다시 시작
        /// </summary>
        public DelegateCommand ResumeCommand
        {
            get
            {
                if (resumeCommand == null)
                {
                    resumeCommand = new DelegateCommand(
                        _ =>
                        {
                            CurrentDownloadOperation.DownloadOp.Resume();
                            //CheckCanExecuteChanged();
                        },
                        _ => IsCurrentDownloadOperation());
                }
                return resumeCommand;
            }
        }

        private DelegateCommand cancelCommand;
        /// <summary>
        /// 취소 
        /// </summary>
        public DelegateCommand CancelCommand
        {
            get 
            {
                if (cancelCommand == null)
                {
                    cancelCommand = new DelegateCommand(
                        _ => 
                        {
                            CurrentDownloadOperation.Cancel();
                            //CheckCanExecuteChanged();
                            CurrentDownloadOperation.DownloadProgressPercent = 0;
                        },
                        _ => IsCurrentDownloadOperation());
                }
                return cancelCommand; 
            }
        }

        /// <summary>
        /// 버튼 사용 가능여부 반환 함수
        /// </summary>
        /// <returns></returns>
        private bool IsCurrentDownloadOperation()
        {
            bool returnValue = false;

            if (CurrentDownloadOperation == null)
            {
                returnValue = false;
            }
            else
            {
                returnValue = true;
            }
            return returnValue;
        }
    }
}
