using kaki104.MetroCL.Bases;

namespace kaki104.MetroCL.Models
{
    /// <summary>
    /// 메뉴 아이템 모델
    /// </summary>
    public class ItemModel : kaki104ModelBase
    {
        private string itemTitle;
        /// <summary>
        /// 아이템 제목
        /// </summary>
        public string ItemTitle
        {
            get
            {
                return itemTitle;
            }
            set
            {
                itemTitle = value;
                FirePropertyChange("ItemTitle");
            }
        }

        private string itemDesc;
        /// <summary>
        /// 아이템 설명
        /// </summary>
        public string ItemDesc
        {
            get
            {
                return itemDesc;
            }
            set
            {
                itemDesc = value;
                FirePropertyChange("ItemDesc");
            }
        }

        private string itemUri;
        /// <summary>
        /// 아이템 Uri
        /// </summary>
        public string ItemUri
        {
            get
            {
                return itemUri;
            }
            set
            {
                itemUri = value;
                FirePropertyChange("ItemUri");
            }
        }

        private string itemImageUri;
        /// <summary>
        /// 아이템 이미지 Uri
        /// </summary>
        public string ItemImageUri
        {
            get
            {
                return itemImageUri;
            }
            set
            {
                itemImageUri = value;
                FirePropertyChange("ItemImageUri");
            }
        }
    }
}
