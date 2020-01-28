using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CSharpPractice.Section10Repository;

namespace CSharpPractice
{
    // Polymorphism, More on OOP, and Text Files
    class Section10
    {
        public static void Polymorphism()
        {
            /*
             * First, what is polymorphism? The instructor doesn't explain the theory here.
                    Polymorphism is Greek for "many forms."
                    Note, first of all, that this term does not refer to having many instances (or forms) of one class. That's just object instantiation.
                    Note, second of all, that this term does not refer to having many derived classes (or forms) of one base class. That's just inheritance.

                    What then, does the term mean positively?
                    Despite the "poly" in its name, there are, strangely, only 2 basic forms of polymorphism in C#.
                    And even more strangely, as I understand these terms, they are opposites. 
                    In other words, the two kinds of polymorphism are really 2 distinct things, not subsumable under a single common essense. They deserve their own names.

                    Nevertheless, they do have some traits in common, namely:
                        i. They both establish a relationship of sameness (but not identity) between many things and one other thing.
                        ii. They both require inheritance to be possible.

             * What are the 2 types of polymorphism?
                    The basic idea is that in OOP, **when inheritance occurs**, it becomes possible to do these two things:
                        (1) treat many things of different, but related kinds as if they were the same kind, or 
                        (2) the same word in different, but related contexts as if it meant different things.
                    We can see that the relationship is reversed from (1) to (2):
                        (1) many (kinds) --> one (kind)
                        (2) one (name) --> many (meanings)
                    Where --> means 'treated as if'.
                    The fact that we are not dealing with inverted relationships, and different understood content, is why I think these types of polymorphism should have different names.

            * Let me explain the two basic types with more specificity.

                 There can be (1) many objects that are treated as if they were instances of the same class (when they are in fact instances of different, albeit related classes).
                 This is achieved **implicitly** by the compiler. It implicitly converts derived classes to its base class; no cast is required.
                 From the ms docs: At run time, objects of a derived class may be treated as objects of a base class in places such as method parameters and collections or arrays. When this occurs, the object's declared type is no longer identical to its run-time type.

                 There can be (2) many method implementations that have the same name and signature (when they are in fact non-identical methods in different classes).
                 This is achieved **explicitly** by the programmer when using 'virtual' and 'override' keywords in method definitions in the base and inheriting classes.
                 Properties can also be overridden, which likewise requires using 'virtual' and 'override' keywords.

                 There can be (2) many method definitions or declarations that have the same name in the same class, as long as they have different signatures (number of parameters + parameter types).
                 This is achieved **explicitly** by the programmer by defining each method 'overload', as it's called.

            * There is more to be said about dynamic or run time polymorphism vs. static or compile time polymorphism, but I don't find that stuff helpful.
            * There is also operator overloading, but I'll leave that aside.
            */

            var cars = new List<Car>
            {
                new Audi(200, "blue", "A4"),
                new BMW(250, "red", "M3")
            };

            // Notice that, even though we've made an Audi and a BMW with specific methods
            // of the same name, the base class method gets invoked.
            foreach (var car in cars)
            {
                car.BaseMethodWithNoOverrideOrNewKeyword();
            }

            // Notice that, even though we've called a loop on a list of Cars, the Audi and BMW-specific methods
            // get invoked. This is because the base class method with the same name has been overridden.
            // So, when instances/objects are being treated AS IF they were instances/objects of their base class,
            // It is necessary to have the virtual keyword to tell the code at run time to look for subclass specific methods.
            foreach (var car in cars)
            {
                car.BaseMethodWithOverride();
            }

            // Notice that, without the virtual keyword, the code doesn't know to look for the subclass-specific methods
            // because a foreach loop is being run on a list of Cars--the Audi and BMW are treated as if they were simply Cars.
            foreach (var car in cars)
            {
                car.BaseMethodWithNewKeyword();
            }

            // In order to see the methods created with the new keyword, you have to create a instance of a subclass
            // As an instance of that subclass, not as if it were an instance of its base class.
            // Again, the big difference here is that we are making an Audi, not a Car.
            // Compare the first word of the next line with the first word of the items created in the cars variable. 
            Audi audiA3 = new Audi(100, "green", "A3");
            audiA3.BaseMethodWithNewKeyword();

            // If you recast a subclass instance as a base class instance, then you can use the original method.
            Car carRecast = (Car)audiA3;
            carRecast.BaseMethodWithNewKeyword();
        }

        public static void PreventPolymorphism()
        {
            // First, I created a subclass of BMW.
            // Then we instantiate the sub-sub class (Car --> BMW --> M3).
            M3 myM3 = new M3(260, "red", "M3 Super Turbo");

            // Now look within the M3 class to see how the following method has been sealed at the BMW level.
            // The polymorphic behavior has been prevented.
            myM3.BaseMethodWithOverride();

            // You can also seal entire classes. Check out Audi and TT classes to see the idea in action.
        }

        public static void HasARelationshipExample()
        {
            // The inheritance examples we've seen so far are all 'is a' relationships. An M3 is a BMW. A BWM is a Car, etc.
            // In fact, all inheritance sets up 'is a' relationships. 
            // But suppose we want to give more attributes to the base class car, such that all instances of cars (BMWs, Audis, and specific models of those) 'have a' property like a VIN?
            // This approach, the alternative to inheritance, is called 'composition.'
            // Then we can create a class like 'CarIDInfo' and establish a 'has a' relationship in the Car class.
            // Go to the Car class and see how the CarIdInfo class has been instantiated to say that Cars 'have a' carIdInfo.
            // We are basically instantiating the CarIDInfo class within each Car instantiation. This way, an object HAS another object, instead of BEING an instance of another class.
            // And given the methods defined in the Car class, we can get and set the car id info here.
            M3 myM3 = new M3(260, "red", "M3 Super Turbo");
            myM3.SetCarIdInfo(11768, "Mario Andretti");
            myM3.GetCarIdInfo();
        }

        public static void ReadFromTextFile()
        {
            // First create a string into which the text from the text file can be saved.
            // To do that, we'll need to have a location that the text file is stored.
            // I'm creating a dynamic way to get the text file instead of hard-coding it. 
            // I've set the TextFile.txt's Build Action property to copy to the output directory if it's newer.
            // That way, when the exe file runs, it can find the text file relative to itself easily.
            string assemblyLocation = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string fullPath = assemblyLocation + "/Assets/TextFile.txt";
            string text = File.ReadAllText(fullPath);
            Console.WriteLine("TextFile.txt contains the following text: \n" + text);

            Console.WriteLine("-----------------------------");

            // Alternate method of reading text
            string[] lines = File.ReadAllLines(fullPath);
            Console.WriteLine("TextFile.txt contains the following text:");

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }

        public static void WriteToTextFile()
        {
            // Option 1
            string[] lines = { "first line", "second line", "third line" };
            string assemblyLocation = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string fullPath = assemblyLocation + "/Assets/ThisFileWasCreatedByTheApp.txt";
            File.WriteAllLines(fullPath, lines);

            // Option 2 - dynamically create .txt file
            Console.WriteLine("Give the file a name.");
            string fileName = Console.ReadLine();
            Console.WriteLine("Enter some text content for the file.");
            string input = Console.ReadLine();
            File.WriteAllText(assemblyLocation + "/Assets/" + fileName + ".txt", input);

            // Option 3
            // Grab text from file in option 1 and put it in another file
            using(StreamWriter file = new StreamWriter(assemblyLocation + "/Assets/WriteTextOption3.txt"))
            {
                foreach(string line in lines)
                {
                    if (line.Contains("third"))
                    {
                        file.WriteLine(line);
                    }
                }
            }
        }
    }
}
