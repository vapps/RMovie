using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace kaki104.MetroCL.Models
{
    public class SkyDriveAudioModel : SkyDriveFileModel
    {
        public SkyDriveAudioModel()
        { 
        }

        public SkyDriveAudioModel(SkyDriveFileModel file) 
            : base(file.Id, file.CreaterName, file.CreaterId, file.Link, file.Name, file.ParentId, file.Description, file.UploadLocation, file.Type, 
                    file.CreatedTime, file.UpdatedTime, file.Access, file.Size, file.CommentsCount, file.CommentEnabled, file.IsEmbeddable, file.Source, 
                    file.LastCheck, file.IsLocalFile, file.LocalFilePath)
        {
            
        }

        private string title;
        /// <summary>
        /// The audio's title.
        /// </summary>
        public string Title
        {
            get { return title; }
            set 
            { 
                title = value;
                OnPropertyChanged();
            }
        }

        private string artist;
        /// <summary>
        /// The audio's artist name.
        /// </summary>
        public string Artist
        {
            get { return artist; }
            set 
            { 
                artist = value;
                OnPropertyChanged();
            }
        }

        private string album;
        /// <summary>
        /// The audio's album name
        /// </summary>
        public string Album
        {
            get { return album; }
            set 
            { 
                album = value;
                OnPropertyChanged();
            }
        }

        private string albumArtist;
        /// <summary>
        /// The artist name of the audio's album.
        /// </summary>
        public string AlbumArtist
        {
            get { return albumArtist; }
            set 
            { 
                albumArtist = value;
                OnPropertyChanged();
            }
        }

        private string genre;
        /// <summary>
        /// The audio's genre
        /// </summary>
        public string Genre
        {
            get { return genre; }
            set 
            { 
                genre = value;
                OnPropertyChanged();
            }
        }

        private int duration;
        /// <summary>
        /// The audio's playing time, in milliseconds
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

        private string picture;
        /// <summary>
        /// A URL to view the audio's picture on SkyDrive
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
