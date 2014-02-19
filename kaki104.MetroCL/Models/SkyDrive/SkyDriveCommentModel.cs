using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace kaki104.MetroCL.Models
{
    public class SkyDriveCommentModel : kaki104.MetroCL.Common.BindableBase
    {
        [DataMember]
        private string id;
        /// <summary>
        /// The Comment object's id
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
        private string fromName;
        /// <summary>
        /// The name of the user who created the comment
        /// </summary>
        public string FromName
        {
            get { return fromName; }
            set
            {
                fromName = value;
                OnPropertyChanged();
            }
        }

        [DataMember]
        private string fromId;
        /// <summary>
        /// The ID of the user who created the comment
        /// </summary>
        public string FromId
        {
            get { return fromId; }
            set
            {
                fromId = value;
                OnPropertyChanged();
            }
        }

        [DataMember]
        private string message;
        /// <summary>
        /// The text of the comment. The maximum length of a comment is 10,000 characters
        /// </summary>
        public string Message
        {
            get { return message; }
            set
            {
                message = value;
                OnPropertyChanged();
            }
        }

        [DataMember]
        private string createdTime;
        /// <summary>
        /// The time, in ISO 8601 format, at which the comment was created
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
    }
}
