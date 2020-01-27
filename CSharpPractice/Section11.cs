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

            // Unlike classes, structs do not support inheritance.
            // Unlike classes, you cannot specify members of a struct as abstract, virtual, or protected.
            // Unlike classes, you cannot mark a struct itself as abstract or protected.

            // For more on structs vs classes, see
            // https://softwareengineering.stackexchange.com/questions/92339/when-do-you-use-a-struct-instead-of-a-class
            // https://www.tutorialsteacher.com/csharp/csharp-struct 
            // https://stackoverflow.com/questions/521298/when-to-use-struct
        }

        public void Enums()
        {

        }
    }
}
