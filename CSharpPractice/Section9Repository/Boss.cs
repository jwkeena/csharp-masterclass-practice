using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.Section9Repository
{
    class Boss : Employee
    {
        // Property unique to bosses
        protected string CompanyCar { get; set; }

        public Boss() { }

        // Notice the 'base' extension to avoid rewriting this.Position = position, etc
        // Now we only need to set the properties unique to this class
        public Boss(string position, string name, int salary, string companyCar) : base(name, position, salary)
        {
            this.CompanyCar = companyCar;
        }

        // Method unique to bosses
        public void Lead()
        {
            Console.WriteLine(this.Name + " is the boss of you.");
        }
    } 
}
