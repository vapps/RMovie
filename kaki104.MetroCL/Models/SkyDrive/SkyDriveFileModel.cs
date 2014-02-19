using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;
using System.Collections.ObjectModel;

namespace kaki104.MetroCL.Models
{
    /// <summary>
    /// File/Audio 형태 동일
    /// </summary>
    public class SkyDriveFileModel : SkyDriveItemCommonModel
    {
        public SkyDriveFileModel()
        {
            init();
        }

        public SkyDriveFileModel(
            string id, string createrName, string createrId, string link, string name,
            string parentId, string description, string uploadLocation, string type,
            string createdTime, string updatedTime, string access,
            long size, int commentsCount, bool commentEnabled, bool isEmbeddable,
            string source, Guid lastCheck, bool isLocalFile, string localFilePath)
            : base(id, createrName, createrId, link, name,
                    parentId, description, uploadLocation, type,
                    createdTime, updatedTime, access, lastCheck)
        {
            Size = size;
            CommentsCount = commentsCount;
            CommentEnabled = commentEnabled;
            IsEmbeddable = isEmbeddable;
            Source = source;
            IsLocalFile = isLocalFile;
            LocalFilePath = localFilePath;

            init();
        }

        private void init()
        {
            DownloadGuid = Guid.Empty;
            CommentCollection = new ObservableCollection<SkyDriveCommentModel>();
        }

        private long size;
        /// <summary>
        /// The size, in bytes, of the file.
        /// </summary>
        public long Size
        {
            get { return size; }
            set 
            { 
                size = value;
                OnPropertyChanged();
            }
        }

        private int commentsCount;
        /// <summary>
        /// The number of comments that are associated with the file.
        /// </summary>
        public int CommentsCount
        {
            get { return commentsCount; }
            set 
            { 
                commentsCount = value;
                OnPropertyChanged();
            }
        }

        private bool commentEnabled;
        /// <summary>
        /// A value that indicates whether comments are enabled for the file. If comments can be made, this value is true; otherwise, it is false.
        /// </summary>
        public bool CommentEnabled
        {
            get { return commentEnabled; }
            set 
            { 
                commentEnabled = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<SkyDriveCommentModel> commentCollection;
        /// <summary>
        /// 코맨트 컬렉션
        /// </summary>
        public ObservableCollection<SkyDriveCommentModel> CommentCollection
        {
            get { return commentCollection; }
            set 
            { 
                commentCollection = value;
                OnPropertyChanged();
            }
        }

        private bool isEmbeddable;
        /// <summary>
        /// A value that indicates whether this file can be embedded. If this file can be embedded, this value is true; otherwise, it is false.
        /// </summary>
        public bool IsEmbeddable
        {
            get { return isEmbeddable; }
            set 
            { 
                isEmbeddable = value;
                OnPropertyChanged();
            }
        }

        private string source;
        /// <summary>
        /// The URL to use to download the file from SkyDrive.
        /// </summary>
        public string Source
        {
            get { return source; }
            set 
            { 
                source = value;
                OnPropertyChanged();
            }
        }

        private string localFilePath;
        /// <summary>
        /// 로컬 패스
        /// </summary>
        public string LocalFilePath
        {
            get { return localFilePath; }
            set 
            {
                localFilePath = value;
                OnPropertyChanged();
            }
        }

        private bool isLocalFile;
        /// <summary>
        /// 로컬 파일 존재 여부
        /// </summary>
        public bool IsLocalFile
        {
            get { return isLocalFile; }
            set 
            {
                isLocalFile = value;
                OnPropertyChanged();
            }
        }

        private Guid downloadGuid;
        /// <summary>
        /// 다운로드시 생기는 Guid 저장 - 나중에 파일과 다운로드 연결고리
        /// </summary>
        public Guid DownloadGuid
        {
            get { return downloadGuid; }
            set 
            { 
                downloadGuid = value;
                OnPropertyChanged();
            }
        }

    }
}
