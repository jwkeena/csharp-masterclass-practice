using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class Section2
    {
        public static void ImplicitTypeConversion()
        {
            int num = 7892435;
            long bigNum = num;
            Console.WriteLine("The integer " + num + " has been converted to a long " + bigNum + " without explicitly re casting it");

            float myFloat = 13.45f; // don't forget to put an 'f' at the end of a float initialization
            double myDouble = myFloat;
            Console.WriteLine("The float " + myFloat + " has been converted to a double " + myDouble + " without explicitly re casting it");
        }
        public static void ExplicitTypeConversion()
        {
            double myDouble = 26.2;
            int myInt;

            // casting double to int
            myInt = (int)myDouble; // reads as: make (=) an integer (int) out of the myDouble variable.
            Console.WriteLine(myInt); // cuts off the decimal points to fit into int data type
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
