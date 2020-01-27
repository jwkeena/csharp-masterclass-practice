using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.Section10Repository
{
    class Car
    {
        public int HorsePower { get; set; }
        public string Color { get; set; }

        // Default constructor
        public Car() { }

        public Car(int horsePower, string color)
        {
            this.HorsePower = horsePower;
            this.Color = color;
        }

        public void BaseMethodWithNoOverrideOrNewKeyword()
        {
            // This method on the Car class has slightly different variations
            // In its inheriting classes. However, those variations will not be run when
            // inheriting instances are treated as if they were instances of their base class.
            // In order to run them, you need to override them or use the new keyword as shown below.
            Console.WriteLine("This is the base Car class method. It is not being overridden or replaced in inheriting classes.");
        }

        public virtual void BaseMethodWithOverride()
        {
            Console.WriteLine("This is the base Car class method. In inheriting classes, it is being overridden. The virtual keyword here allows for that to happen.");
        }

        public void BaseMethodWithNewKeyword()
        {
            Console.WriteLine("This is a base Car class method. In inheriting classes, the new keyword has been applied.");
        }

        public virtual void BaseMethodWithOverrideThenSealed()
        {
            Console.WriteLine("This method on Car class will be changed in the BMW and Audi subclasses, but then locked from being overridden anymore.");
        }
    }
}
