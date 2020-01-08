using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.Section6Repository
{
    class HomoSapiens
    {
        // Member variables can be privatized now since they're being passed in to the constructor externally
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
