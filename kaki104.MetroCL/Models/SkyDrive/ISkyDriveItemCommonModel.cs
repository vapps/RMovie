using System;
using System.Runtime.Serialization;
using Windows.UI.Xaml.Media.Imaging;

namespace kaki104.MetroCL.Models
{
    public interface ISkyDriveItemCommonModel
    {
        string Access { get; set; }
        string CreatedTime { get; set; }
        string CreaterId { get; set; }
        string CreaterName { get; set; }
        string Description { get; set; }
        string Id { get; set; }
        string Link { get; set; }
        string Name { get; set; }
        string ParentId { get; set; }
        string Type { get; set; }
        string UpdatedTime { get; set; }
        string UploadLocation { get; set; }
        BitmapImage BaseImage { get; set; }
        SkyDriveFolderModel Parent { get; set; }
        Guid LastCheck { get; set; }
        bool IsSkySearchItem { get; set; }
    }
}
