using System;
using System.Timers;
using System.Threading.Tasks;
using WindowsInput.Native;
using WindowsInput;

namespace CSharpPractice
{
    class Helpers
    {
        static int secondsTillClose = 7;
        public static void KeepWindowOpen()
        {
            Console.ReadLine();
        }
        // Alt method https://stackoverflow.com/questions/21221218/c-sharp-timer-to-close-console-window-after-x-seconds
        public static void CloseWindowEventually()
        {
            Console.WriteLine("-----------------------------------------------");
            Timer closeWindowTimer = new Timer(); // Create a timer from the System.Timers assembly reference
            closeWindowTimer.Elapsed += new ElapsedEventHandler(CloseConsoleWindow); // Hook up the elapsed event for the timer
            closeWindowTimer.Interval = 7000; // Set timer for interval in milliseconds
            closeWindowTimer.Enabled = true; // Start the timer

            Timer displayCountdownTimer = new Timer();
            displayCountdownTimer.Elapsed += new ElapsedEventHandler(DisplayCountdownMessage);
            displayCountdownTimer.Interval = 1000;
            displayCountdownTimer.Enabled = true;
        }
        private static void CloseConsoleWindow(Object source, ElapsedEventArgs e)
        {
            Environment.Exit(0);
        }
        private static void DisplayCountdownMessage(Object source, ElapsedEventArgs e)
        {
            secondsTillClose--;
            Console.Write("\r" + secondsTillClose + " seconds until program exits.");
        }
        public static void SimulatePressingEnter()
        {
            var sim = new InputSimulator();
            sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);
        }
    }
}
