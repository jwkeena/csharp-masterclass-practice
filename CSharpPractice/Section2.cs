using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class Section2
    {
        // implicit conversion means switching a type with no data loss at all, and no chance of throwing an exception
        // this may only be possible on built-in numeric types
        public static void DoImplicitConversion()
        {
            int num = 7892435;
            long bigNum = num;
            Console.WriteLine("The integer " + num + " has been converted to a long " + bigNum + " without explicitly re casting it");

            float myFloat = 13.45f; // don't forget to put an 'f' at the end of a float initialization
            double myDouble = myFloat;
            Console.WriteLine("The float " + myFloat + " has been converted to a double " + myDouble + " without explicitly re casting it");
        }

        // explicit conversion means switching a type with some data loss, or at least a risk of data loss (and possibly throwing an exception)
        // if there is such a risk, the compiler requires that you explicitly tell it to convert, which is called a cast.
        // the cast is you telling the compiler that you're aware some data may be lost and you don't give an f
        public static void DoExplicitConversion()
        {
            double myDouble = 26.2;
            int myInt;

            // casting double to int
            myInt = (int)myDouble; // reads as: make (=) an integer (int) out of the myDouble variable. the (int) is the cast
            Console.WriteLine(myInt); // cuts off the decimal points to fit into int data type. This is the data loss
        }

        // type conversion
        public static void DoTypeConversion()
        {
            double myDouble = 123.456;
            string myString = myDouble.ToString();
            Console.WriteLine(myString);
        }

        // simple addition and concatenation
        public static void DoSimpleAddition()
        {
            int num1 = 7;
            int num2 = 5;
            int sum = num1 + num2;
            Console.WriteLine("The sum of " + num1 + " and " + num2 + " is " + sum);

            int unassignedNum; // This value cannot be printed to the console because it has no value (unlike in JS, where its value would be null)
        }
    }
}
