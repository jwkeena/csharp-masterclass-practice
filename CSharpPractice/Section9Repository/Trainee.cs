using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.Section9Repository
{
    class Trainee : Employee
    {
        // Properties unique to trainees
        protected string WorkingHours { get; set; }
        protected string SchoolHours { get; set; }

        // Constructors
        public Trainee() { }

        public Trainee(string position, string name, int salary, string workingHours, string schoolHours) : base(position, name, salary)
        {
            this.WorkingHours = workingHours;
            this.SchoolHours = schoolHours;
        }


        // Methods unique to trainees
        public void Learn()
        {
            Console.WriteLine(this.Name + " is training at work while going to business school in the evenings.");
        }

        public override void Work()
        {
            Console.WriteLine("As a trainee, " + this.Name + " has a short work schedule of " + this.WorkingHours + ".");
        }
    }
}
