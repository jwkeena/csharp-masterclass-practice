using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Shortcut for Console.WriteLine();
            Action<object> see = Console.WriteLine;
            
            Section1.TurnOnChristmasMode();

            Section3.UnaryOperators();

            Helpers.KeepWindowOpen();
        }

    }
}
