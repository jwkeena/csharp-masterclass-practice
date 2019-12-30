using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class Section1
    {
        // Variables can be declared outside or inside methods, even the Main method of Program class.
        // But they must be declared inside the class brackets. After the namespace declarationor after the namespace brackets won't work
        static int LanguagesLearned = 1;

        // Playing with Console methods
        public static void TurnOnChristmasMode()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Clear(); // Makes the background color apply to the whole window
            Console.WriteLine("Christmas mode activated");
        }

        // Re assigning a variable declared at a higher scope
        public static void ReAssignExternalVariable()
        {
            Console.WriteLine(LanguagesLearned);
            // Variables defined in a higher scope can be reassigned inside a method. But variables declared inside of a method are only accessible inside that method
            LanguagesLearned = 2;
        }
        
        // First program
        public static void HelloWorld()
        {
            string myName = "Justin";
            Console.WriteLine("Hello " + myName);
        }
    }
}
