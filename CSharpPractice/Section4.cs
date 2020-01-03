using System;

namespace CSharpPractice
{
    // Making Decisions
    class Section4
    {
        public static void BasicCondition()
        {
            Console.WriteLine("What is the temperature?");
            int temperature = Int32.Parse(Console.ReadLine());

            if (temperature > 50)
            {
                Console.WriteLine("Go running outside");
            }
            else if (temperature < 50)
            {
                Console.WriteLine("Stay inside unless you wear warm clothes");
            } 
            else if (temperature < 25)
            {
                Console.WriteLine("It's too cold to run outside");
            }
        }
        public static void TestTryParse(string numberAsString)
        {
            // notice that parsedValue is declared inline. It can also be initialized in a separate line above
            bool success = int.TryParse(numberAsString, out int parsedValue);

            // notice the lack of braces for the condition
            if (success)
                Console.WriteLine("Parsing successful - number is " + parsedValue);
            else
                Console.WriteLine("Parsing failed.");
        }
        public static void BasicSwitchStatement()
        {
            Console.WriteLine("How many programming languages do you know?");
            string inputAsString = Console.ReadLine();
            bool inputIsParsable = int.TryParse(inputAsString, out int languagesLearned);
            
            if (inputIsParsable)
            {
                switch (Math.Abs(languagesLearned))
                {
                    case 0:
                        Console.WriteLine("noob");
                        break;
                    case 1:
                        Console.WriteLine("beginner");
                        break;
                    case 2:
                        Console.WriteLine("amateur");
                        break;
                    case 3:
                        Console.WriteLine("experienced");
                        break;
                    case 4:
                        Console.WriteLine("master");
                        break;
                    case 5:
                        Console.WriteLine("ok, you can stop now");
                        break;
                    default:
                        Console.WriteLine("you need another hobby");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid integer.");
                BasicSwitchStatement(); // Making method recursive so it runs until a valid integer is given
            }
        }
        public static void ComplexTernaryOperator()
        {
            Console.WriteLine("What temperature is the water?");
            string tempAsString = Console.ReadLine();
            bool tempAsStringIsParsable = int.TryParse(tempAsString, out int tempAsInt);
            string stateOfWater;

            if (tempAsStringIsParsable)
            {
                // note that parentheses in the following line can be removed since ternary operators are right associative
                stateOfWater = tempAsInt > 212 ? "gas" : (tempAsInt > 32 ? "liquid" : "solid");
                Console.WriteLine("The water is currently a " + stateOfWater); 

            }
            else
            {
                Console.WriteLine("Enter a valid integer.");
                ComplexTernaryOperator();
            }
        }
    }
}
