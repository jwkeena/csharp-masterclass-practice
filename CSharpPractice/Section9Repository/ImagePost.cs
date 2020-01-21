using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.Section9Repository
{
    // ImagePost derives from Post and adds a property (ImageURL) and two constructors
    class ImagePost : Post
    {
        public string ImageURL { get; set; }

        // This empty constructor seems useless. The program works without it, and the instructor's explanation of it isn't clear


        public ImagePost(string title, bool isPublic, string sendByUsername, string imageURL)
        {
            // The following properties and the GetNextID method are inherited from Post.
            this.ID = GetNextID();
            this.Title = title;
            this.IsPublic = isPublic;
            this.SendByUsername = sendByUsername;
            // Property ImageURL is a member of ImagePost, but not of Post
            this.ImageURL = imageURL;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2} - image URL: {3}", this.ID, this.Title, this.SendByUsername, this.ImageURL);
        }

    }
}
