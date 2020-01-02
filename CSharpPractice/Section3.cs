using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
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

        // Using user input to perform an operation
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
    }
}
