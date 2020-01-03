using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpPractice
{
    // Functions/Methods
    class Section3
    {
        // Method creation syntax: 
        // <Access specifier> <Static or non-static> <Return type> <Method name>(Parameter List)
        //{
        //  Method body
        //}

        // Practicing creating a method that returns an integer. So, instead of using 'void' for the return type, use 'int'
        // Notice that this only works properly for whole numbers!
        public static int Multiply(int num1, int num2)
        {
            int result = num1 * num2;
            return result;
        }

        // Challenge method
        public static void GreetFriend(string friend)
        {
            Console.WriteLine("Hello, " + friend + "!");
        }

        // Getting user input
        public static void RepeatUserInput()
        {
            string input = Console.ReadLine();
            Console.WriteLine(input);
        }

        // Using multiple user inputs to perform an operation
        public static double AddTwoUserInputNumbers()
        {
            Console.WriteLine("Enter first number to add. Decimals are OK.");
            string input1 = Console.ReadLine();
            double num1 = Double.Parse(input1);

            Console.WriteLine("Enter second number to add. Decimals are OK.");
            string input2 = Console.ReadLine();
            double num2 = Double.Parse(input1);

            double sum = num1 + num2;
            return sum;
        }

        // Error handling (try/catch/finally blocks)
        public static void ConvertUserInputToInt()
        {
            Console.WriteLine("Enter a number to be converted to an integer.");
            string input = Console.ReadLine();

            // The code in the try block will be run, and IF it throws an exception, it won't crash the program. 
            // In other words this is a way to 
            try
            {
                int inputAsInt = Int32.Parse(input);
            }

            // Specific exceptions can be logged, if you know what they are in advance
            // To check which ones are possible, hover the mouse over the suspicious method being called in the try block.
            catch (FormatException)
            {
                Console.WriteLine("Input not parsable as an integer. Remove letters, characters, and decimals.");
            }

            // A way to catch all exceptions: use the base Exception class.
            // Here I'm just logging the exception's message to see what kind it is.
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // This will be executed whenever try and catch blocks are run. 
            finally
            {
                Console.WriteLine("Finally block executed.");
            }
        }

        // Composite formatting vs string interpolation
        public static void DistinguishStringFormattingFromInterpolation()
        {
            string programmingLanguage = "C#";
            object currentMoment = DateTime.Now;

            // Composite formatting. The numbers in braces are replaced by the other arguments in order
            Console.WriteLine("You are running a program in {0} at {1}", programmingLanguage, currentMoment);

            // String interpolation. Don't forget the '$' before the string
            Console.WriteLine($"You are running a program in {programmingLanguage} at {currentMoment}");

        }

        public static void OperatorExamples()
        {
            // unary operators
            int num = 1;
            bool isSunny = false;

            // operator - : multiply by -1
            Console.WriteLine(-num);

            // operator ! : reverse boolean
            Console.WriteLine(!isSunny);

            // operators ++, -- : pre-increment, pre-decrement (notice it has to be prefixed to show up on the same line)
            Console.WriteLine(++num);

            // operators ++, -- : post-increment, post-decrement on the next line
            int anotherNum = 99;
            anotherNum++;
            Console.WriteLine(anotherNum);

            // mathematical operators +, *, /, % : add, multiply, divide, modulo
            // logical operators &&, ||
            // relational operators <, >, ==, !=, >=, <=
            // for more operators see https://www.programiz.com/csharp-programming/operators

        }
    }
}
