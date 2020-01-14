using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.Section6Repository
{
    class HomoSapiens
    {
        // Member variables can be privatized now since they're being passed in to the constructor externally.
        // These should still be initialized so that they can be used by member methods.
        // For instance, if someone creates a HomoSapiens instance without a coolnessFactor, we need it to be initialized to 0.
        private string firstName;
        private int coolnessLevel;

        // Member methods
        public void IntroduceMyself()
        {
            Console.WriteLine("Hello, my name is " + firstName);
            Console.WriteLine("And my coolnessLevel is " + coolnessLevel.ToString());
        }

        // Default constructor
        public HomoSapiens()
        {
            Console.WriteLine("Default constructor called because no parameters were specified. HomoSapiens instance created.");
        }

        // Parameterized constructor 1 (overload 1)
        public HomoSapiens(string firstName)
        {
            this.firstName = firstName; // equivalent to this.firstName
        }       
        
        // Parameterized constructor 2 (overload 2)
        public HomoSapiens(string firstName, int coolnessLevel)
        {
            this.firstName = firstName; // equivalent to this.firstName
            this.coolnessLevel = coolnessLevel; // equivalent to this.coolnessLevel
        }
    }
}
