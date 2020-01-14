using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.Section6Repository
{
    class ProtectedBoxWithProperties
    {
        private int length = 3;
        private int height = 4;
        private int volume;

        // I am giving indirect access to the length variable via the SetLength method.
        // But suppose I wanted to do this another way? That's what properties are for.

        // Property example, making the height variable indirectly accessible.
        // Notice the capital letter
        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value; 
                // The 'value' keyword is whatever the property is assigned to when the set (method?) is called.
                // For example, try calling 
            }
        }

        // Note that you can customize setters and getters
        public int Length
        {
            get
            {
                return length;
            }
            set
            {
                if (length < 0)
                {
                    length = -value;
                }
                else
                {
                    length = value;
                }
            }
        }

        // But you don't even need to make a member variable to have a property. 
        // This is equivalent to the Height property in 11 lines!
        // Of course that means you need to reference Width instead of width below
        public int Width { get; set; }

        // Notes to self
        // Auto-generated shortcut properties, like the one above, must have both a get accessor. So you can do this:
        // public int Qwerty { get; }
        // but not this:
        // public int Qwerty { set; }
        // It also seems like you can't do auto-generated get, and then a custom set.

        public int GetVolume()
        {
            return this.length * this.height * this.Width;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Length is {0}, height is {1}, and width is {2}, so the volume is {3}", length, height, Width, volume = length * height * Width);
        }

        // Properties challenge
        public int FrontSurface
        {
            get
            {
                return this.height * this.length;
            }
        }
    }
}
