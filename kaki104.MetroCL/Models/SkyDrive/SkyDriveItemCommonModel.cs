using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using kaki104.MetroCL.Common;
using Windows.UI.Xaml.Media.Imaging;

namespace kaki104.MetroCL.Models
{
    //[DataContract(IsReference = true)]
    public class SkyDriveItemCommonModel : BindableBase, ISkyDriveItemCommonModel
    {
        public SkyDriveItemCommonModel()
        {
        }

        public SkyDriveItemCommonModel(
            string id, string createrName, string createrId, string link, string name, 
            string parentId, string description, string uploadLocation, string type,
            string createdTime, string updatedTime, string access, Guid lastCheck)
        {
            Id = id;
            CreaterName = createrName;
            CreaterId = createrId;
            Link = link;
            Name = name;
            ParentId = parentId;
            Description = description;
            UploadLocation = uploadLocation;
            Type = type;
            CreatedTime = createdTime;
            UpdatedTime = updatedTime;
            Access = access;
            LastCheck = lastCheck;
            IsSkySearchItem = false;
        }

        [DataMember]
        private string id;
        /// <summary>
        /// The Folder/file object's ID.
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
        private string createrName;
        /// <summary>
        /// The name of the user who created/uploaded the folder.
        /// </summary>
        public string CreaterName
        {
            get { return createrName; }
            set 
            {
                createrName = value;
                OnPropertyChanged();
            }
        }

        [DataMember]
        private string createrId;
        /// <summary>
        /// The ID of the user who created/uploaded the folder.
        /// </summary>
        public string CreaterId
        {
            get { return createrId; }
            set 
            { 
                createrId = value;
                OnPropertyChanged();
            }
        }

        [DataMember]
        private string link;
        /// <summary>
        /// The URL of the folder/file, hosted in SkyDrive.
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
        private string name;
        /// <summary>
        /// The name of the folder/file.
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
        private string parentId;
        /// <summary>
        /// The resource ID of the parent.
        /// The id of the folder the file is currently stored in.
        /// </summary>
        public string ParentId
        {
            get { return parentId; }
            set 
            { 
                parentId = value;
                OnPropertyChanged();
            }
        }

        [DataMember]
        private string description;
        /// <summary>
        /// A description of the folder/file, or null if no description is specified
        /// </summary>
        public string Description
        {
            get { return description; }
            set 
            { 
                description = value;
                OnPropertyChanged();
            }
        }

        [DataMember]
        private string uploadLocation;
        /// <summary>
        /// The URL to upload items to the folder/file hosted in SkyDrive. Requires the wl.skydrive scope.
        /// </summary>
        public string UploadLocation
        {
            get { return uploadLocation; }
            set 
            { 
                uploadLocation = value;
                OnPropertyChanged();
            }
        }

        [DataMember]
        private string type;
        /// <summary>
        /// The type of object; in this case, "folder","file".
        /// </summary>
        public string Type
        {
            get { return type; }
            set 
            { 
                type = value;
                OnPropertyChanged();
            }
        }

        [DataMember]
        private string createdTime;
        /// <summary>
        /// The time, in ISO 8601 format, at which the folder/file was created.
        /// </summary>
        public string CreatedTime
        {
            get { return createdTime; }
            set 
            { 
                createdTime = value;
                OnPropertyChanged();
            }
        }

        [DataMember]
        private string updatedTime;
        /// <summary>
        /// The time, in ISO 8601 format, at which the contents of the folder/file were last updated.
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

        [DataMember]
        private string access;
        /// <summary>
        /// Info about who can access the folder/file.
        /// </summary>
        public string Access
        {
            get { return access; }
            set 
            { 
                access = value;
                OnPropertyChanged();
            }
        }

        [IgnoreDataMember]
        private BitmapImage baseImage;
        /// <summary>
        /// 기본 이미지..이 프로퍼티는 임의로 추가한 것임
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

        [DataMember]
        private SkyDriveFolderModel parent;
        /// <summary>
        /// 상위 폴더 - 원래는 ParentId만 있는데 내부적으로 각 아이템의 상위 폴더가 필요해서 추가함
        /// </summary>
        public SkyDriveFolderModel Parent
        {
            get { return parent; }
            set 
            { 
                parent = value;
                OnPropertyChanged();
            }
        }

        [IgnoreDataMember]
        private Guid lastCheck;
        /// <summary>
        /// 마지막 체크 GUID - 삭제확인을 위해 사용됨
        /// </summary>
        [IgnoreDataMember]
        public Guid LastCheck
        {
            get { return lastCheck; }
            set 
            { 
                lastCheck = value;
                OnPropertyChanged();
            }
        }

        [DataMember]
        private bool isSkySearchItem;
        /// <summary>
        /// 스카이 서치에 등록 여부
        /// </summary>
        public bool IsSkySearchItem
        {
            get { return isSkySearchItem; }
            set 
            { 
                isSkySearchItem = value;
                OnPropertyChanged();
            }
        }

    }
}
