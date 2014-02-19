using System;
using System.Runtime.Serialization;
using kaki104.MetroCL.Common;
using Windows.UI.Xaml.Media.Imaging;

namespace kaki104.MetroCL.Models
{
    public class UserModel : BindableBase
    {
        public UserModel()
        { 
        }

        [DataMember]
        private string id;
        /// <summary>
        /// The user's ID.
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

        [DataMember]
        private string name;
        /// <summary>
        /// The user's full name.
        /// </summary>
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged();
            }
        }

        [DataMember]
        private string firstName;
        /// <summary>
        /// The user's first name.
        /// </summary>
        public string FirstName
        {
            get { return firstName; }
            set 
            { 
                firstName = value;
                OnPropertyChanged();
            }
        }

        [DataMember]
        private string lastName;
        /// <summary>
        /// The user's last name.
        /// </summary>
        public string LastName
        {
            get { return lastName; }
            set 
            { 
                lastName = value;
                OnPropertyChanged();
            }
        }

        [DataMember]
        private string link;
        /// <summary>
        /// The URL of the user's profile page. wl.basic
        /// </summary>
        public string Link
        {
            get { return link; }
            set
            {
                link = value;
                OnPropertyChanged();
            }
        }

        [DataMember]
        private DateTime birthday;
        /// <summary>
        /// birth_day, birth_month, birth_year 3개를 합쳐서 생일 생성해야함 wl.birthday
        /// </summary>
        public DateTime Birthday
        {
            get { return birthday; }
            set 
            { 
                birthday = value;
                OnPropertyChanged();
            }
        }

        //work 생략

        [DataMember]
        private string gender;
        /// <summary>
        /// The user's gender. Valid values are "male", "female", or null if the user's gender is not specified.
        /// </summary>
        public string Gender
        {
            get { return gender; }
            set 
            { 
                gender = value;
                OnPropertyChanged();
            }
        }

        [DataMember]
        private string locale;
        /// <summary>
        /// The user's locale code.
        /// </summary>
        public string Locale
        {
            get { return locale; }
            set 
            { 
                locale = value;
                OnPropertyChanged();
            }
        }

        [DataMember]
        private string updatedTime;
        /// <summary>
        /// The time, in ISO 8601 format, at which the user last updated the object.
        /// </summary>
        public string UpdatedTime
        {
            get { return updatedTime; }
            set 
            { 
                updatedTime = value;
                OnPropertyChanged();
            }
        }

        private BitmapImage userImage;
        /// <summary>
        /// 사용자 이미지
        /// </summary>
        [IgnoreDataMember]
        public BitmapImage UserImage
        {
            get { return userImage; }
            set 
            { 
                userImage = value;
                OnPropertyChanged();
            }
        }
    }
}
