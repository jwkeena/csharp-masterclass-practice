using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.Section9Repository
{
    class VideoPost : Post
    {
        protected string VideoURL { get; set; }
        protected int Length { get; set; }

        public VideoPost(string title, bool isPublic, string sendByUsername, string videoURL)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.IsPublic = isPublic;
            this.SendByUsername = sendByUsername;
            this.VideoURL = videoURL;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2} - video URL: {3}", this.ID, this.Title, this.SendByUsername, this.VideoURL);
        }
    }
}
