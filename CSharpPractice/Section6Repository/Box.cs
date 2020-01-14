using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.Section6Repository
{
    class Box
    {
        // Member variables: variables on the level of the class
        public int length;
        public int height;
        public int width;
        public int volume;

        public void DisplayInfo()
        {
            Console.WriteLine("Length is {0}, height is {1}, and width is {2}, so the volume is {3}", length, height, width, volume = length*height*width);
        }
    }
}
