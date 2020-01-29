using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.Section11Repository
{
    class Sphere : Shape
    {
        public double Radius { get; set; }

        public Sphere(double radius)
        {
            Name = "sphere";
            Radius = radius;
        }
        public override double Volume()
        {
            return (((Math.Pow(Radius, 3)*Math.PI*4/3)));
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"This cube has a radius of {Radius} and a volume of {Volume()}");
        }
    }
}
