using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using kaki104.MetroCL.Common;
using Windows.UI.Xaml.Media.Imaging;
using Windows.Storage;

namespace kaki104.MetroCL.Models
{
    public class SkyDrivePhotoImageModel : BindableBase
    {
        private int heightImage;
        /// <summary>
        /// The height, in pixels, of this image of this particular size.
        /// </summary>
        public int HeightImage
        {
            get { return heightImage; }
            set
            {
                heightImage = value;
                OnPropertyChanged();
            }
        }

        private int widthImage;
        /// <summary>
        /// The width, in pixels, of this image of this particular size.
        /// </summary>
        public int WidthImage
        {
            get { return widthImage; }
            set
            {
                widthImage = value;
                OnPropertyChanged();
            }
        }

        private string sourceImage;
        /// <summary>
        /// A URL of the source file of this image of this particular size.
        /// </summary>
        public string SourceImage
        {
            get { return sourceImage; }
            set
            {
                sourceImage = value;
                OnPropertyChanged();
            }
        }

        private string typeImage;
        /// <summary>
        /// The type of this image of this particular size. Valid values are:
        /// full (max size 2048 x 2048 pixels)
        /// normal (max size 800 x 800 pixels)
        /// album (max size 200 x 200 pixels)
        /// small (max size 100 x 100 pixels)
        /// </summary>
        public string TypeImage
        {
            get { return typeImage; }
            set
            {
                typeImage = value;
                OnPropertyChanged();
            }
        }
    }

    public class SkyDrivePhotoModel : SkyDriveFileModel
    {
        public SkyDrivePhotoModel()
        {
            Images = new ObservableCollection<SkyDrivePhotoImageModel>();
        }

        private async void UriImageSaveFile()
        {
            //var tempFile = await Windows.Storage.ApplicationData.Current.TemporaryFolder.CreateFileAsync(this.Name + "_Scaled800", Windows.Storage.CreationCollisionOption.ReplaceExisting);
            //await tempFile.OpenAsync(Windows.Storage.FileAccessMode.ReadWrite);
            //var stream = await tempFile.OpenStreamForWriteAsync();
            try
            {
                var uri = new Uri(Picture.Replace("Thumbnail", "Scaled800,WebReady"));
                var imageFile = await Windows.Storage.StorageFile.GetFileFromApplicationUriAsync(uri);

                var imageFileStream = await imageFile.OpenAsync(Windows.Storage.FileAccessMode.Read);

                var tempImage = new BitmapImage();
                tempImage.SetSource(imageFileStream);

                if (tempImage != null)
                {
                    this.BaseImage = tempImage;
                    if (this.Parent != null && this.Parent.BaseImage == null)
                    {
                        this.Parent.BaseImage = this.BaseImage;
                    }
                }
            }
            catch (Exception ex)
            {
                this.BaseImage = null;
            }

        }

        public SkyDrivePhotoModel(SkyDriveFileModel file) 
            : base(file.Id, file.CreaterName, file.CreaterId, file.Link, file.Name, file.ParentId, file.Description, file.UploadLocation, file.Type, 
                    file.CreatedTime, file.UpdatedTime, file.Access, file.Size, file.CommentsCount, file.CommentEnabled, file.IsEmbeddable, file.Source,
                    file.LastCheck, file.IsLocalFile, file.LocalFilePath)
        {
            Images = new ObservableCollection<SkyDrivePhotoImageModel>();
        }

        [IgnoreDataMember]
        private ObservableCollection<SkyDrivePhotoImageModel> images;
        /// <summary>
        /// Info about various sizes of the photo.
        /// </summary>
        [IgnoreDataMember]
        public ObservableCollection<SkyDrivePhotoImageModel> Images
        {
            get { return images; }
            set 
            { 
                images = value;
                OnPropertyChanged();
            }
        }

        private string whenTaken;
        /// <summary>
        /// The date, in ISO 8601 format, on which the photo was taken, or null if no date is specified.
        /// </summary>
        public string WhenTaken
        {
            get { return whenTaken; }
            set 
            { 
                whenTaken = value;
                OnPropertyChanged();
            }
        }

        private int height;
        /// <summary>
        /// The height, in pixels, of the photo.
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
        /// The width, in pixels, of the photo.
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

        private int tagsCount;
        /// <summary>
        /// The number of tags on the photo.
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
        /// A value that indicates whether tags are enabled for the photo. If users can tag the photo, this value is true; otherwise, it is false.
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

        private string picture;
        /// <summary>
        /// A URL of the photo's picture.
        /// </summary>
        public string Picture
        {
            get { return picture; }
            set 
            { 
                picture = value;
                OnPropertyChanged();

                SetPicture();
            }
        }

        private void SetPicture()
        {
            if (Picture != null && Picture != "")
            {
                this.BaseImage = null;

                var uri = new Uri(Picture);
                BaseImage = new BitmapImage(uri);
            }
        }

    }
}
