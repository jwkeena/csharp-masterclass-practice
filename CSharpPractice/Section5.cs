using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    // Loops
    class Section5
    {
        public static void ForLoop()
        {
            for (int counter = 0; counter < 100; counter++)
            {
                Console.WriteLine(counter);
            }
        }
        public static void OnlyPrintOddNumbersFromZeroTo(int maxNumber)
        {
            for (int counter = 0; counter < maxNumber; counter++)
            {
                if (counter % 2 != 0)
                    Console.WriteLine(counter + " is odd");
            }
        }
        public static void DoWhileLoop()
        {
            int counter = 0; // iterator must be declared outside the do block
            do
            {
                Console.WriteLine(counter);
                counter++; // don't forget to increment INSIDE the do block
            } while (counter < 10); // this will check the condition AFTER the do block is run once, unlike the for loop and while loop (to test this, make it counter < 0)
            // in other words the do block is always run at least once.
        }
        public static void WhileLoop()
        {
            int counter = 0;
            while (counter < 10) // Checks condition first, unlike the do while loop
            {
                Console.WriteLine(counter);
                counter++;
            }
        }
        public static void DecrementCounter()
        {
            int counter = 10;
            while (counter > 0)
            {
                Console.WriteLine("Press enter " + counter + " times to exit program");
                Console.ReadLine();
                counter--;
            }
        }
        public static void ContinueExample()
        {
            int counter = 0;
            while (counter < 10)
            {
                counter++; // Increment here, otherwise you'll have to increment in the if block AND after the if block to prevent an infinite loop
                if (counter == 5)
                {
                    Console.WriteLine("This iteration has been skipped");
                    continue;
                }
                Console.WriteLine(counter);
            }
        }
        public static void GradingAverageTool()
        {
            int sum = 0;
            int numOfStudents = 0;
            Console.WriteLine("Enter a grade to average, then press enter. \n" +
                "Only numbers 0-100 are accepted. \n" +
                "To average the total and exit the program, press 'a', then enter.\n");
            
            // Get app going with first input
            string firstInputAsString = Console.ReadLine();
            bool firstInputAsStringIsInteger = int.TryParse(firstInputAsString, out int firstInputAsInteger);

            if (firstInputAsStringIsInteger && firstInputAsInteger > -1 && firstInputAsInteger < 101)
            {
                sum += firstInputAsInteger;
                numOfStudents++;
                Console.WriteLine("Grades for " + numOfStudents + " student entered.");

                // Begin loop, since we know we have an integer 0-100 now
                int counter = 0;
                string input = Console.ReadLine();
                while (input != "a")
                {
                    bool inputIsInteger = int.TryParse(input, out int inputAsInteger); // This must be inside the loop so its value can be updated each iteration
                    counter++; // Increment counter right away
                    if (inputIsInteger) // Check if input is a whole number
                    {
                        if (inputAsInteger > -1 & inputAsInteger < 101)
                        {
                            sum += inputAsInteger;
                            numOfStudents++;
                            Console.WriteLine("Grades for " + numOfStudents + " students entered.");
                        }
                        else
                        {
                            Console.WriteLine("Grades must range from 0-100. " +
                                "\n Enter another grade or 'a' to average now.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Grades must be integers." +
                            "\n Enter another grade or 'a' to averge now.");
                    }
                    input = Console.ReadLine(); // Reset the input so that it can exit the loop if 'a' is entered
                }

                // Tally average after loop breaks
                if (numOfStudents > 0)
                {
                    double average = (double)sum / (double)numOfStudents;
                    Console.WriteLine("----------------------------------------------------------");
                    Console.WriteLine("The average grade for all " + numOfStudents + " student(s) is " + Math.Round(average, 2));
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Restarting program.");
                GradingAverageTool();
            }
        }
    }
}
