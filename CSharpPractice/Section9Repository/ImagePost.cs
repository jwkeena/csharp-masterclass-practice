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
        // So here's my explanation. 
        // The reason it's here is if you created a new ImagePost with no parameters, since this empty constructor would invoke the base class constructor.
        // Without an empty constructor in a derived class, the derived class won't invoke the base class constructor if it's called with no parameters.

        public ImagePost() { }
        
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
