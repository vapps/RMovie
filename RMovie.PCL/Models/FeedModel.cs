using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace RMovie.PCL.Models
{

    #region FeedImageModel
    public class FeedImageModel : BaseModel
    {
        public Uri Url { get; set; }
        public string Title { get; set; }
        public Uri Link { get; set; }
    }
    #endregion

    // FeedData
    // Holds info for a single blog feed, including a list of blog posts (FeedItem)
    public class FeedDataModel : BaseModel
    {
        public FeedDataModel()
        {
            _Items = new ObservableCollection<FeedItemModel>();
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime PubDate { get; set; }
        public FeedImageModel Image { get; set; }

        private ObservableCollection<FeedItemModel> _Items;
        public ObservableCollection<FeedItemModel> Items
        {
            get { return this._Items; }
            set
            {
                _Items = value;
            }
        }
    }

    // FeedItem
    // Holds info for a single blog post
    public class FeedItemModel : BaseModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
        public DateTime PubDate { get; set; }
        public Uri Link { get; set; }
    }

}
