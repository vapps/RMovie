using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaki104.MetroCL.Models
{
    public class SkyDriveFolderModel : SkyDriveItemCommonModel
    {
        public SkyDriveFolderModel()
        {
            Items = new ObservableCollection<ISkyDriveItemCommonModel>();
        }

        public SkyDriveFolderModel(
            string id, string createrName, string createrId, string link, string name,
            string parentId, string description, string uploadLocation, string type,
            string createdTime, string updatedTime, string access,
            int count, bool isEmbeddable, Guid lastCheck)
            : base(id, createrName, createrId, link, name,
                    parentId, description, uploadLocation, type,
                    createdTime, updatedTime, access, lastCheck)
        {
            Count = count;
            IsEmbeddable = isEmbeddable;
            Items = new ObservableCollection<ISkyDriveItemCommonModel>();
            FileItems = new ObservableCollection<SkyDriveFileModel>();
        }

        private int count;
        /// <summary>
        /// The total number of items in the folder.
        /// </summary>
        public int Count
        {
            get { return count; }
            set 
            { 
                count = value;
                OnPropertyChanged();
            }
        }

        private bool isEmbeddable;
        /// <summary>
        /// 문서에는 없는데 실제로는 존재
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

        private ObservableCollection<ISkyDriveItemCommonModel> items;
        /// <summary>
        /// 폴더내의 아이템들
        /// </summary>
        public ObservableCollection<ISkyDriveItemCommonModel> Items
        {
            get { return items; }
            set 
            { 
                items = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<SkyDriveFileModel> fileItems;
        /// <summary>
        /// 파일 아이템들만..
        /// </summary>
        public ObservableCollection<SkyDriveFileModel> FileItems
        {
            get { return fileItems; }
            set 
            { 
                fileItems = value;
                OnPropertyChanged();
            }
        }
        
        private string tag;
        /// <summary>
        /// 테그 - 문자로 표시되는 폴더의 경우 사용한다
        /// </summary>
        public string Tag
        {
            get { return tag; }
            set 
            { 
                tag = value;
                OnPropertyChanged();
            }
        }
    }
}
