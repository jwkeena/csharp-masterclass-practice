using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CSharpPractice.Section9Repository
{
    class VideoPost : Post
    {
        // Fields
        protected bool isPlaying = false;
        protected int currDuration = 0;
        Timer timer;

        // Properties
        protected string VideoURL { get; set; }
        protected int Length { get; set; }
        protected int LengthCountdown { get; set; }

        // I'm not creating an empty constructor because I'm not going to instantiate this class without all the parameters 
        public VideoPost(string title, bool isPublic, string sendByUsername, string videoURL, int length)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.IsPublic = isPublic;
            this.SendByUsername = sendByUsername;
            this.VideoURL = videoURL;
            this.Length = length;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2} - video URL: {3} - length: {4} seconds", this.ID, this.Title, this.SendByUsername, this.VideoURL, this.Length);
        }

        public void Play()
        {
            if (!isPlaying)
            {
                isPlaying = true;
                Console.WriteLine("Video playing");
                timer = new Timer(TimerCallback, null, 0, 1000);
            }
        }

        private void TimerCallback(Object o)
        {
            if (currDuration < Length)
            {
                currDuration++;
                Console.WriteLine("Video at {0}s", currDuration);
                GC.Collect(); // Force the garbage constructor
            }
            else
            {
                Stop();
            }
        }

        public void Stop()
        {
            if (isPlaying)
            {
                isPlaying = false;
                Console.WriteLine("Video stopped at {0}s", currDuration);
                currDuration = 0;
                timer.Dispose();
            }
        }
    }
}
