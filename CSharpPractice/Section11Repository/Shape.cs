using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.Section11Repository
{
    // An abstract class can't be instantiated, but it can be inherited.
    // Shape is a good example because we don't want a nonspecific "shape" to be instantiated. 
    // It must be a specific shape like Cube. So we need to make a Cube class that inherits from Shape.
    abstract class Shape
    {
        public string Name { get; set; }
        public virtual void GetInfo()
        {
            Console.WriteLine($"\nThis is a {Name}");
        }

        // Making an abstract method without implementing it (notice the absence of {}).
        // This means that, when a class inherits from abstract, it must implement a Volume() method.
        // This functionality reminds me of an interface. I wonder how it differs?
        public abstract double Volume();
    }
}
