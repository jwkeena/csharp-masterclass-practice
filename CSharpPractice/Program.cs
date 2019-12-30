using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class Program
    {
        // Variables can be declared even in the master class, outside of the Main method
        static int LanguagesLearned = 1; 
        static void Main(string[] args)
        {
            // Variables defined in a higher scope can be reassigned inside a method. But variables declared inside of a method are only accessible inside that method
            LanguagesLearned = 2; 
            
            // calling custom method defined later on
            TurnOnChristmasMode();


            // Keeps console window open
            Console.ReadLine();
        }

        static void TurnOnChristmasMode()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.BackgroundColor = ConsoleColor.DarkGreen; 
            Console.Clear(); // Makes the background color apply to the whole window
            Console.WriteLine("Christmas mode activated").ToUpper();
        }

        static void SimpleIntegers()
        {
            // simple addition and concatenation
            int num1 = 7;
            int num2 = 5;
            int sum = num1 + num2;
            Console.WriteLine("The sum of " + num1 + " and " + num2 + " is " + sum);

            int unassignedNum; // This value cannot be printed to the console because it has no value (unlike in JS, where its value would be null)

        }
    }
}
