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
            Action<object> see = Console.WriteLine; // Shortcut for Console.WriteLine();

            // Test section methods here
            Section1.TurnOnChristmasMode();
            Section4.BasicCondition();


            Helpers.CloseAfterThreeSeconds(); // Only works in debugging mode
        }

        

    }
}
