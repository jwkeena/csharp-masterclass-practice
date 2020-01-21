using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    // Inheritance
    class Section9
    {
        public static void CreatePosts()
        {
            Section9Repository.Post post1 = new Section9Repository.Post("This is a basic post", true, "ProgrammingNoob");
            Console.WriteLine(post1.ToString());

            Section9Repository.ImagePost imagePost1 = new Section9Repository.ImagePost("This is an image post", true, "InstagramHusband", "www.theinternet.com/image.jpg");
            Console.WriteLine(imagePost1.ToString());

            Section9Repository.VideoPost videoPost1 = new Section9Repository.VideoPost("This is a video post", true, "RIP-Vine", "www.theinternet.com/video.mpeg");
            Console.WriteLine(videoPost1.ToString());
        }

    }
}
