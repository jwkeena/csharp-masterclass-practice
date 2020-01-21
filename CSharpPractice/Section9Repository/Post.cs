using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.Section9Repository
{
    class Post
    {
        private static int currentPostId;
        
        // Properties. Notice they're protected, so they can only be used by this class and any inheriting classes
        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string SendByUsername { get; set; }
        protected bool IsPublic { get; set; }

        // Default constructor. If a derived class does not invoke a base-
        // class constructor explicitly, the default constructor of its base class is called implicity.
        public Post()
        {
            ID = 0;
            Title = "Hello World";
            IsPublic = true;
            SendByUsername = "Justin";
        }

        // Instance constructor with three parameters
        public Post(string title, bool isPublic, string sendByUsername)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;
        }

        protected int GetNextID()
        {
            return ++currentPostId;
        }

        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }

        // Modifying the ToString method interited from the universal 'base' class in System.Object
        // This way we can stringify the post and custom format it in one stroke
        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2}", this.ID, this.Title, this.SendByUsername);
        }
    }
}
