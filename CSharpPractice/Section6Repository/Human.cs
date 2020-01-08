using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.Section6Repository
{
    class Human
    {
        public string firstName; // Making this public allows the instantiating class to modify it

        public void IntroduceMyself()
        {
            Console.WriteLine("Hello, my name is " + firstName);
        }
    }
}
