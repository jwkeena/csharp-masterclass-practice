using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    // Making Decisions
    class Section4
    {
        public static void BasicCondition()
        {
            Console.WriteLine("What is the temperature?");
            int temperature = Int32.Parse(Console.ReadLine());

            if (temperature > 50)
            {
                Console.WriteLine("Go running outside");
            }
            else if (temperature < 50)
            {
                Console.WriteLine("Stay inside unless you wear warm clothes");

            } 
            else if (temperature < 25)
            {
                Console.WriteLine("It's too cold to run outside");
            }
        }

        public static void TestTryParse(string numberAsString)
        {
            // notice that parsedValue is declared inline. It can also be initialized in a separate line above
            bool success = int.TryParse(numberAsString, out int parsedValue);

            // notice the lack of braces for the condition
            if (success)
                Console.WriteLine("Parsing successful - number is " + parsedValue);
            else
                Console.WriteLine("Parsing failed.");
        }
    }
}
