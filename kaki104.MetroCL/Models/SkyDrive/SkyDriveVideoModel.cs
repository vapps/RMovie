using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace kaki104.MetroCL.Models
{
    public class SkyDriveVideoModel : SkyDriveFileModel
    {
        public SkyDriveVideoModel()
        { 
        }

        public SkyDriveVideoModel(SkyDriveFileModel file) 
            : base(file.Id, file.CreaterName, file.CreaterId, file.Link, file.Name, file.ParentId, file.Description, file.UploadLocation, file.Type, 
                    file.CreatedTime, file.UpdatedTime, file.Access, file.Size, file.CommentsCount, file.CommentEnabled, file.IsEmbeddable, file.Source,
                    file.LastCheck, file.IsLocalFile, file.LocalFilePath)
        {
            
        }

        private int tagsCount;
        /// <summary>
        /// The number of tags on the video.
        /// </summary>
        public int TagsCount
        {
            get { return tagsCount; }
            set 
            { 
                tagsCount = value;
                OnPropertyChanged();
            }
        }

        private bool tagsEnabled;
        /// <summary>
        /// A value that indicates whether tags are enabled for the video. If tags can be set, this value is true; otherwise, it is false.
        /// </summary>
        public bool TagsEnabled
        {
            get { return tagsEnabled; }
            set 
            { 
                tagsEnabled = value;
                OnPropertyChanged();
            }
        }

        private int height;
        /// <summary>
        /// The height, in pixels, of the video.
        /// </summary>
        public int Height
        {
            get { return height; }
            set 
            { 
                height = value;
                OnPropertyChanged();
            }
        }

        private int width;
        /// <summary>
        /// The width, in pixels, of the video.
        /// </summary>
        public int Width
        {
            get { return width; }
            set 
            { 
                width = value;
                OnPropertyChanged();
            }
        }

        private int duration;
        /// <summary>
        /// The duration, in milliseconds, of the video run time.
        /// </summary>
        public int Duration
        {
            get { return duration; }
            set
            {
                duration = value;
                OnPropertyChanged();
            }
        }

        private int bitrate;
        /// <summary>
        /// The bit rate, in bits per second, of the video.
        /// </summary>
        public int Bitrate
        {
            get { return bitrate; }
            set 
            { 
                bitrate = value;
                OnPropertyChanged();
            }
        }

        private string picture;
        /// <summary>
        /// A URL of a picture that represents the video.
        /// </summary>
        public string Picture
        {
            get { return picture; }
            set 
            { 
                picture = value;
                OnPropertyChanged();

                //여기다가 사용하는거 별로 좋아하지는 않은데..ㅋ
                if (Picture != null && Picture != "")
                {
                    this.BaseImage = null;
                    this.BaseImage = new BitmapImage(new Uri(Picture));
                    //if (this.Parent != null && this.Parent.BaseImage == null)
                    //{
                    //    this.Parent.BaseImage = this.BaseImage;
                    //}
                }

            }
        }

    }
}
