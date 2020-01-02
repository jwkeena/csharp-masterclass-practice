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
        // <Access specifier> <Return type> <Method name>(Parameter List)
        //{
        //  Method body
        //}

        // Practicing creating a method that returns an integer. So, instead of using 'void' for the return type, use 'int'
        static public int Multiply(int num1, int num2)
        {
            int result = num1 * num2;
            return result;
        }

    }
}
