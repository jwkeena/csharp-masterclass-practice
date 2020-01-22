using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.Section9Repository
{
    class Employee
    {
        // Properties
        protected string Position { get; set; }
        protected string Name { get; set; }
        protected int Salary { get; set; }

        // Default constructor
        public Employee()
        {
            Position = null;
            Name = null;
            Salary = 0;
        }

        // Parameterized constructor
        public Employee (string position, string name, int salary)
        {
            this.Position = position;
            this.Name = name;
            this.Salary = salary;
        }

        // Methods
        // Notice 'virtual' keyword in Work() method so that it can be overridden in the Trainee class
        public virtual void Work()
        {
            Console.WriteLine(this.Name + " is going to work to make $" + this.Salary + " a year.");
        }

        public void GoHome()
        {
            Console.WriteLine(this.Name + " is going home for the day.");
        }

    }
}
