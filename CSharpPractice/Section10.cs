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
