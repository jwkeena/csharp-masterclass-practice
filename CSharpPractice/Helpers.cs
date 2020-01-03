using System;
using System.Timers;
using System.Threading.Tasks;
using WindowsInput.Native;
using WindowsInput;

namespace CSharpPractice
{
    class Helpers
    {
        public static void KeepWindowOpen()
        {
            Console.ReadLine();
        }
        // Alt method https://stackoverflow.com/questions/21221218/c-sharp-timer-to-close-console-window-after-x-seconds
        public static void CloseAfterThreeSeconds()
        {
            Console.WriteLine("Exit after delay method fired");
            Timer aTimer = new Timer(); // Create a timer from the System.Timers assembly reference
            aTimer.Elapsed += new ElapsedEventHandler(CloseConsoleWindow); // Hook up the elapsed event for the timer
            aTimer.Interval = 3000; // Set timer for interval in milliseconds
            aTimer.Enabled = true; // Start the timer
        }
        private static void CloseConsoleWindow(Object source, ElapsedEventArgs e)
        {
            Environment.Exit(0);
        }

        public static void SimulatePressingEnter()
        {
            var sim = new InputSimulator();
            sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);
        }
    }
}
