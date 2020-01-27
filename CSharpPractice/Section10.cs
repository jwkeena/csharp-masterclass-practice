using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            // You can also seal entire classes. Uncomment the following line to see the error it produces.

        }

    }
}
