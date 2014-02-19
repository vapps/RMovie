using RMovie.PCL.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Text;

namespace RMovie.PCL.ViewModels
{
    public class FeedDataViewModel : BaseViewModel
    {
        private ObservableCollection<FeedDataModel> _Feeds = new ObservableCollection<FeedDataModel>();
        public ObservableCollection<FeedDataModel> Feeds
        {
            get
            {
                return this._Feeds;
            }
        }

        // FeedDataSource
        // Holds a collection of blog feeds (FeedData), and contains methods needed to
        // retreive the feeds.
        public class FeedDataSource
        {
            private ObservableCollection<FeedDataModel> _Feeds = new ObservableCollection<FeedDataModel>();
            public ObservableCollection<FeedDataModel> Feeds
            {
                get
                {
                    return this._Feeds;
                }
            }

            public void GetFeedsAsync()
            {
                Feeds.Add(new FeedDataModel
                {
                    Title = "Daum영화 개봉예정작",
                    Description = "Daum영화 | 영화정보 | 개봉예정작",
                    PubDate = DateTime.Now,
                    Image = new FeedImageModel
                    {
                        Url = new Uri("http://movieimage.daum-img.net/images/misc/RSS_logo_movie.gif"),
                        Title = "Daum영화 개봉예정작",
                        Link = new Uri("http://movie.daum.net/movieinfo/coming/movieInfoScheduled.do?modeType=day&order=recently")
                    },
                    Items = new ObservableCollection<FeedItemModel>
                {
                    new FeedItemModel
                    {
                        Title = "반딧불이 정원",
                        Link = new Uri("http://movie.daum.net/moviedetailMain.do?movieId=43206"),
                        Description = "감독 : 데니스 리, 주연 : 라이언 레이놀즈|윌렘 데포|줄리아 로버츠|캐리 앤 모스|에밀리 왓슨",
                        PubDate = DateTime.Now
                    },
                    new FeedItemModel
                    {
                        Title = "댄스 오브 드래곤",
                        Link = new Uri("http://movie.daum.net/moviedetailMain.do?movieId=44084"),
                        Description = "감독 : 맥스 매닉스, 주연 : 제이슨 스콧 리|범문방|장혁",
                        PubDate = DateTime.Now
                    },
                    new FeedItemModel
                    {
                        Title = "인피니트 콘서트 세컨드 인베이전 에볼루션 더 무비 3D",
                        Link = new Uri("http://movie.daum.net/moviedetailMain.do?movieId=73702"),
                        Description = "감독 : 손석, 주연 : 김성규|장동우|남우현|이성열|엘|호야|이성종",
                        PubDate = DateTime.Now
                    },
                    new FeedItemModel
                    {
                        Title = "화벽",
                        Link = new Uri("http://movie.daum.net/moviedetailMain.do?movieId=64563"),
                        Description = "감독 : 진가상, 주연 : 손려|등초",
                        PubDate = DateTime.Now
                    },
                    new FeedItemModel
                    {
                        Title = "런던 블러바드",
                        Link = new Uri("http://movie.daum.net/moviedetailMain.do?movieId=57494"),
                        Description = "감독 : 윌리엄 모나한, 주연 : 콜린 파렐|키이라 나이틀리",
                        PubDate = DateTime.Now
                    },
                    new FeedItemModel
                    {
                        Title = "나이트폴",
                        Link = new Uri("http://movie.daum.net/moviedetailMain.do?movieId=70603"),
                        Description = "감독 : 주현량, 주연 : 장가휘|임달화",
                        PubDate = DateTime.Now
                    }
                }
                });
            }

            //private async Task GetFeedAsync(string feedUriString)
            //{
            //    WebRequest request = new WebRequest.

            //    System.Windows.Web.Syndication.SyndicationClient client = new SyndicationClient();
            //    Uri feedUri = new Uri(feedUriString);

            //    try
            //    {
            //        SyndicationFeed feed = await client.RetrieveFeedAsync(feedUri);

            //        // This code is executed after RetrieveFeedAsync returns the SyndicationFeed.
            //        // Process the feed and copy the data we want into our FeedData and FeedItem classes.
            //        FeedData feedData = new FeedData();

            //        feedData.Title = feed.Title.Text;
            //        if (feed.Subtitle != null && feed.Subtitle.Text != null)
            //        {
            //            feedData.Description = feed.Subtitle.Text;
            //        }
            //        // Use the date of the latest post as the last updated date.
            //        feedData.PubDate = feed.Items[0].PublishedDate.DateTime;

            //        foreach (SyndicationItem item in feed.Items)
            //        {
            //            FeedItem feedItem = new FeedItem();
            //            feedItem.Title = item.Title.Text;
            //            feedItem.PubDate = item.PublishedDate.DateTime;
            //            feedItem.Author = item.Authors[0].Name.ToString();
            //            // Handle the differences between RSS and Atom feeds.
            //            if (feed.SourceFormat == SyndicationFormat.Atom10)
            //            {
            //                feedItem.Content = item.Content.Text;
            //                feedItem.Link = new Uri("http://windowsteamblog.com" + item.Id);
            //            }
            //            else if (feed.SourceFormat == SyndicationFormat.Rss20)
            //            {
            //                feedItem.Content = item.Summary.Text;
            //                feedItem.Link = item.Links[0].Uri;
            //            }
            //            feedData.Items.Add(feedItem);
            //        }
            //        return feedData;
            //    }
            //    catch (Exception)
            //    {
            //        return null;
            //    }
            //}
        }
    }
}