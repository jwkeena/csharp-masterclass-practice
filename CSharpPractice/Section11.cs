using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using CSharpPractice.Section11Repository;

namespace CSharpPractice
{
    // Advanced C# topics
    class Section11
    {
        public static void Structs()
        {
            // Structs are similar to classes, but classes are reference types and structs are value types.
            // In practice, this means that empty classes can be instantiated, but a struct must contain a value for all of its defined fields.
            // To prove this, try commenting out any of the lines below which sets each of the struct's fields.
            // Another way to prove this is to try and call DisplayInfo() before one or more of the fields are set.
            Game game1;
            game1.name = "Tetris Effect";
            game1.developer = "Monstars";
            game1.rating = 10;
            game1.DisplayInfo();

            // Alternate way of instantiating a struct
            // All the struct's members are initialized to their default value because the constructor is called, unlike with the first option
            // In the first option, the struct object's members remain unassigned until you manually assign them.
            Game game2 = new Game();
            Console.WriteLine(game2.rating);
        }

        interface IGame
        {
            void IHaveAnInterface();
        }
        struct Game : IGame // Like classes, structs can work with interfaces
        {
            // Like classes, structs can have members (here, properties and fields).
            public string name;
            public string developer;
            public double rating;

            // Like classes, structs can have members (here, methods).
            public void DisplayInfo()
            {
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Developer: " + developer);
                Console.WriteLine("Rating: " + rating);
            }

            public void IHaveAnInterface()
            {
                Console.WriteLine("This struct has an interface.");
            }

            // SO HOW ARE STRUCTS DIFFERENT FROM CLASSES?
            // The biggest thing is that, unlike classes, structs cannot have empty, paramaterless constructors (i.e. default constructors).
            // This is because they are value types--they must have a value for ALL of their fields to be created.
            // If you had a default constructor, then you'd be allowing the possibility of a struct with no fields set.
            // Uncomment the next line to see the error it throws.
            // public Game() { }

            // On the other hand, like classes, you CAN have struct constructors WITH parameters.
            // You can also have static parameterless constructors (since that declares the item non-instantiable), if you have a constructor with parameters too.

            // Unlike classes, structs do not support inheritance.
            // Unlike classes, you cannot specify members of a struct as abstract, virtual, or protected.
            // Unlike classes, you cannot mark a struct itself as abstract or protected (but you can use protected when declaring a struct inside a class).
            // Unlike classes, its default access modifier is internal for itself and its members.

            // For more on structs vs classes, see
            // https://softwareengineering.stackexchange.com/questions/92339/when-do-you-use-a-struct-instead-of-a-class
            // https://www.tutorialsteacher.com/csharp/csharp-struct 
            // https://stackoverflow.com/questions/521298/when-to-use-struct
        }

        // Index defaults to start at 0
        enum Day { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }

        // Index is specified to start at 1 (other indices can also be specified, not just the first one)
        enum Month { Jan = 1, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec }
        public static void Enums()
        {
            // From https://www.tutorialsteacher.com/csharp/csharp-enum
            // In C#, enum is a value type data type. 
            // The enum is used to declare a list of named integer constants. 
            // It can be defined using the enum keyword directly inside a namespace, class, or structure. 
            // The enum is used to give a name to each constant so that the constant integer can be referred using its name.

            // Enums are constants; they aren't supposed to change.
            // They are for integers; they don't work with strings.
            // They exist to give names to numbers so they're easier to refer to in the code.
            // Note that they tend to be declared at the namespace level.
            // Their index begins at 0 unless specified otherwise. The rest are incremented by one.

            Console.WriteLine(Day.Monday);
            Console.WriteLine((int)Day.Monday);
            Console.WriteLine(Day.Wednesday);
            Console.WriteLine((int)Day.Wednesday);
            Console.WriteLine(Day.Friday);
            Console.WriteLine((int)Day.Friday);
            Console.WriteLine(1 == (int)Day.Tuesday);

            Console.WriteLine(Month.Jan);
            Console.WriteLine((int)Month.Jan);
        }

        public static void MathClassExamples()
        {
            // Rounding up
            Console.WriteLine("Ceiling: " + Math.Ceiling(15.3));
            // Rounding down
            Console.WriteLine("Floor: " + Math.Floor(15.3));

            // Find lowest and highest number
            int num1 = 238;
            int num2 = 43;
            Console.WriteLine("num1: " + num1 + " num2: " + num2);
            Console.WriteLine("Lower number: " + Math.Min(num1, num2));
            Console.WriteLine("Higher number: " + Math.Max(num1, num2));

            // Pi
            Console.WriteLine(Math.PI);

            // Other common methods are obvious: Abs, Sqrt, Pow
        }

        public static void RandomClassExamples()
        {
            // Create dice (really, one die)
            Random dice = new Random();

            // Create empty integer to store lots of dice rolls in
            int roll;

            // Roll the dice 10 times
            for (int i = 0; i < 10; i++)
            {
                roll = dice.Next(1, 7);
                Console.WriteLine(roll);
            }
        }

        public static void RegExExamples()
        {
            Console.WriteLine("See comments for examples of RegEx formulas to use in Sample.txt.");
            // Search for pattern 123-456-7890
            // \d{3}-\d{3}-\d{4}

            // Search for US phone number pattern with only - OR . OR # between number blocks
            // \d{3}[.#-]\d{3}[.#-]\d{4}

            // Challenge: search for website links
            // (https|http)://(www.|).*\.*\b    <-- mine 
            // https?://(www.)?(\w+)(\.\w+)     <-- instructor's

            // Using C# Regex to find all numbers in a string
            Regex regex = new Regex(@"\d");
            string text = "Hi there, my favorite number is 7 and numbers that are terrible include, 1, 4, and 898987867.";

            MatchCollection matchCollection = regex.Matches(text);
            Console.WriteLine($"Matches found: {matchCollection.Count}. They are: ");
            foreach (Match match in matchCollection) 
            {
                GroupCollection group = match.Groups;
                Console.WriteLine($"{group[0].Value} found at {group[0].Index}");
            }
        }

        public static void DateTimeExamples()
        {
            DateTime dateTime = new DateTime(2019, 7, 13);
            Console.WriteLine(dateTime + " is an important day");

            // Write today on screen
            Console.WriteLine(DateTime.Today);
            // Write current time on screen
            Console.WriteLine(DateTime.Now);

            // Is 3000 a leap year?
            int days = DateTime.DaysInMonth(3000, 2);
            Console.WriteLine("Days in Feb 3000: {0}", days);

            // What time is it?
            DateTime now = DateTime.Now;
            Console.WriteLine($"It is {now.Hour} o'clock {now.Minute} minutes and {now.Second} seconds");

            // Using a methods that return a DateTime
            Console.WriteLine(GetTomorrow());
            Console.WriteLine(GetFirstWeekdayOfYear(3000));

            // How many days since x day?
            Console.WriteLine("Write a date in this format: yyyy-mm-dd");
            string input = Console.ReadLine();
            if (DateTime.TryParse(input, out dateTime))
            {
                Console.WriteLine(dateTime);
                TimeSpan daysPassed = now.Subtract(dateTime);
                Console.WriteLine($"Days passed since {dateTime}: {daysPassed.Days}");
            }
            else
                Console.WriteLine("Wrong input.");
        }

        static DateTime GetTomorrow()
        {
            return DateTime.Today.AddDays(1);
        }

        static DayOfWeek GetFirstWeekdayOfYear(int year)
        {
            return new DateTime(year, 1, 1).DayOfWeek;
        }

        public static void NullableExamples()
        {
            // These are equivalent. All you need to do is add the ? for the shortcut
            Nullable<Int32> nullableIntA = null;
            int? nullableIntB = null;

            // Nothing is printed for the empty values, but there's no build error
            double? num1 = new Double?();
            double? num2 = 3.14157;
            bool? boolval = new bool?();
            Console.WriteLine($"Our nullable values are {num1}, {num2}, {boolval}");

            // The Null coalescing operator ??
            // As per the MSDN definition: The ?? operator is called the null - coalescing operator 
            // and is used to define a default value for nullable value types or reference types.
            // It returns the left - hand operand if the operand is not null; otherwise, it returns the right operand. 
            // It is used to assign a default value to a variable when the value is null.
            string name = null;
            string myname = name ?? "Default Name";
            Console.WriteLine(myname);
        }

        public static void AbstractInheritanceExamples()
        {
            Cube cube1 = new Cube(7);
            cube1.GetInfo();

            Sphere sphere1 = new Sphere(7);
            sphere1.GetInfo();
        }
    }
}
