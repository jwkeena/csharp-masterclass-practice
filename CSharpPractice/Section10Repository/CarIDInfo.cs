using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.Section10Repository
{
    // Setting up a 'has a' relationship example (as opposed to an 'is a' relationship)
    // Cars will have an instance of this class, but no car will BE a CarIdInfo instance
    class CarIDInfo
    {
        public int IDNum { get; set; } = 0;
        public string Owner { get; set; } = "Manufacturer";
    }
}
