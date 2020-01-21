using System;
using System.Diagnostics;

namespace CSharpPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Shortcut for Console.WriteLine();
            Action<object> see = Console.WriteLine;

            // Test section methods here
            Section9.CreatePosts();

            // Helper functions to smooth development experience
            if (Debugger.IsAttached)
                Helpers.CloseWindowEventually();
            else
                see("To close, exit the program manually. Use F5 for automated closing.");

            Helpers.KeepWindowOpen();
        }
    }
}
