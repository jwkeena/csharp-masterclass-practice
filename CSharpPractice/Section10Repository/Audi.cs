using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.Section10Repository
{
    class Audi : Car
    {
        private string make = "Audi";
        public string Model { get; set; }

        public Audi() { }
        public Audi(int horsePower, string color, string model) : base(horsePower, color)
        {
            this.Model = model;
        }

        public void BaseMethodWithNoOverrideOrNewKeyword()
        {
            Console.WriteLine("This is the inheriting Audi-specific method. " +
                "In order to invoke this Audi-specific method you need to override it " +
                "Or use the new keyword in its definition, as shown below.");
        }

        public override void BaseMethodWithOverride()
        {
            Console.WriteLine("This " + make + " " + Model + " has " + HorsePower + " horsepower and has a " + Color + " color.");
        }
        public new void BaseMethodWithNewKeyword()
        {
            Console.WriteLine("This is an entirely NEW method in the inheriting class. It is not overriding the base method but reprioritizing it." +
                " To that extent, its name is misleading. It's not a base method but a new method only on this subclass, though it has the same name.");
        }

    }
}
