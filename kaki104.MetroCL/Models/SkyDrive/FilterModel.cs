using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace kaki104.MetroCL.Models.SkyDrive
{
    /// <summary>
    /// 필터 아이템 모델
    /// </summary>
    public class FilterItemModel : kaki104.MetroCL.Common.BindableBase
    {
        private int filterItemCode;
        /// <summary>
        /// 필터 아이템 코드
        /// </summary>
        public int FilterItemCode
        {
            get { return filterItemCode; }
            set 
            { 
                filterItemCode = value;
                OnPropertyChanged();
            }
        }

        private string filterItemName;
        /// <summary>
        /// 필터 아이템 이름
        /// </summary>
        public string FilterItemName
        {
            get { return filterItemName; }
            set 
            { 
                filterItemName = value;
                OnPropertyChanged();
            }
        }

        private bool isChecked;
        /// <summary>
        /// 필터 선택
        /// </summary>
        public bool IsChecked
        {
            get { return isChecked; }
            set 
            { 
                isChecked = value;
                OnPropertyChanged();
            }
        }

    }

    /// <summary>
    /// 필터 모델
    /// </summary>
    public class FilterModel : kaki104.MetroCL.Common.BindableBase
    {
        private string filterName;
        /// <summary>
        /// 필터 이름
        /// </summary>
        public string FilterName
        {
            get { return filterName; }
            set 
            { 
                filterName = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<FilterItemModel> itemCollection;
        /// <summary>
        /// 필터 아이템 컬렉션
        /// </summary>
        public ObservableCollection<FilterItemModel> ItemCollection
        {
            get { return itemCollection; }
            set 
            { 
                itemCollection = value;
                OnPropertyChanged();
            }
        }

        private string filterType;
        /// <summary>
        /// 필터 타입
        /// </summary>
        public string FilterType
        {
            get { return filterType; }
            set 
            { 
                filterType = value;
                OnPropertyChanged();
            }
        }


        public FilterModel()
        {
            ItemCollection = new ObservableCollection<FilterItemModel>();
        }
    }
}
