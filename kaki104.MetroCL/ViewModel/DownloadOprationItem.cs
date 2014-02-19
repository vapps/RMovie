using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using kaki104.MetroCL.Common;
using Windows.Networking.BackgroundTransfer;
using Windows.UI.Xaml.Media.Imaging;
using System.Runtime.Serialization;

namespace kaki104.MetroCL.ViewModel
{
    public class DownloadOprationItem : BindableBase
    {
        /// <summary>
        /// 취소 토큰
        /// </summary>
        [IgnoreDataMember]
        public CancellationTokenSource CancelToken { get; set; }

        /// <summary>
        /// 생성자
        /// </summary>
        public DownloadOprationItem()
        {
            CancelToken = new CancellationTokenSource();
        }

        /// <summary>
        /// 취소 메소드
        /// </summary>
        public void Cancel()
        {
            CancelToken.Cancel();
            CancelToken.Dispose();
        }

        [IgnoreDataMember]
        private DownloadOperation downloadOp;
        /// <summary>
        /// 다운로드 오퍼레이션
        /// </summary>
        [IgnoreDataMember]
        public DownloadOperation DownloadOp
        {
            get { return downloadOp; }
            set
            {
                downloadOp = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// 다운로드 Uri
        /// </summary>
        public string RequestUri
        {
            get { return DownloadOp.RequestedUri.ToString(); }
        }

        /// <summary>
        /// 로컬 파일명
        /// </summary>
        public string ResultFileName
        {
            get { return DownloadOp.ResultFile.Name; }
        }

        private double downloadProgressPercent;
        /// <summary>
        /// 다운로드 퍼센트
        /// </summary>
        public double DownloadProgressPercent
        {
            get { return downloadProgressPercent; }
            set
            {
                downloadProgressPercent = value;
                OnPropertyChanged();
            }
        }

        private ulong totalBytesToReceive;
        /// <summary>
        /// 총크기
        /// </summary>
        public ulong TotalBytesToReceive
        {
            get { return totalBytesToReceive; }
            set
            {
                totalBytesToReceive = value;
                OnPropertyChanged();
            }
        }

        private ulong bytesReceived;
        /// <summary>
        /// 수신크기
        /// </summary>
        public ulong BytesReceived
        {
            get { return bytesReceived; }
            set
            {
                bytesReceived = value;
                OnPropertyChanged();
            }
        }

        private string state;
        /// <summary>
        /// 상태 메시지
        /// </summary>
        public string State
        {
            get { return state; }
            set
            {
                state = value;
                OnPropertyChanged();
            }
        }

        [IgnoreDataMember]
        private BitmapImage baseImage;
        /// <summary>
        /// 기본 이미지..다운로드 되는 파일에 대한 이미지가 있으면 표시한다.
        /// </summary>
        [IgnoreDataMember]
        public BitmapImage BaseImage
        {
            get { return baseImage; }
            set
            {
                baseImage = value;
                OnPropertyChanged();
            }
        }

        private string id;
        /// <summary>
        /// 아이디
        /// </summary>
        public string Id
        {
            get { return id; }
            set 
            { 
                id = value;
                OnPropertyChanged();
            }
        }

    }
}
