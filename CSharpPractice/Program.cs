﻿using System;
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
            see(Section3.Multiply(3, 6));

            Helpers.KeepWindowOpen();
        }

    }
}
