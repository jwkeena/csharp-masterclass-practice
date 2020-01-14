using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.Section6Repository
{
    class ProtectedBox
    {
        // Notice all these are private, so they can't be simply accessed the way that the member variables of Box.cs are
        private int length;
        private int height = 4;
        private int width = 5;
        private int volume;

        // So, how can they be accessed outside of this class? With custom getters and setters. This is called encapsulation.
        public void SetLength(int length)
        {
            // This is the use of having setters: we can validate requests to change the member variable
            if (length <= 0)
                throw new Exception("Length must be higher than 0");
            
            this.length = length; //this.length refers to the member variable, length refers to the parameter of SetLength
            Console.WriteLine("Length set to " + length);
        }

        public int GetLength()
        {
            return this.length;
        }

        // Notice that we're not actually giving direct access to the volume variable, but the equivalent result of this calculation.
        public int GetVolume()
        {
            return this.length * this.height * this.width;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Length is {0}, height is {1}, and width is {2}, so the volume is {3}", length, height, width, volume = length * height * width);
        }
    }
}
