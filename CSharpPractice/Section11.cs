using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
