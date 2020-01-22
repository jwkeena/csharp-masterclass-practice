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

            Section9Repository.ImagePost imagePost2 = new Section9Repository.ImagePost();
            Console.WriteLine(imagePost2.ToString());

            Section9Repository.VideoPost videoPost1 = new Section9Repository.VideoPost("This is a video post", true, "RIP-Vine", "www.theinternet.com/video.mpeg", 100);
            Console.WriteLine(videoPost1.ToString());
        }

        // Inheritance challenge 1
        public static void PlayVideoPost()
        {
            Section9Repository.VideoPost videoPost1 = new Section9Repository.VideoPost("This is a video post", true, "RIP-Vine", "www.theinternet.com/video.mpeg", 100);
            videoPost1.Play();
            Console.WriteLine("Press any key to stop video");
            Console.ReadKey();
            videoPost1.Stop();
        }

        public static void InheritanceChallenge2()
        {
            Section9Repository.Employee janitor = new Section9Repository.Employee("Janitor", "Mario", 40000);
            janitor.Work();

            Section9Repository.Boss ceo = new Section9Repository.Boss("CEO", "Fischer", 100000, "Lexus");
            ceo.Work();
            ceo.Lead();

            Section9Repository.Trainee intern = new Section9Repository.Trainee("intern", "Sona", 5000, "10am-2pm", "5pm-8pm");
            intern.Work();
        }

        public static void InterfaceExample()
        {
            Section9Repository.Notification note1 = new Section9Repository.Notification("justin", "hello world", DateTime.Now.ToString());
            note1.showNotification();
            note1.getDate();
        }

    }
}
