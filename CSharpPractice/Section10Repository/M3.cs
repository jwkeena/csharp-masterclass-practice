using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.Section10Repository
{
    class M3 : BMW
    {
        public M3(int horsePower, string color, string model) : base(horsePower, color, model) { }

        // Methods can be overridden multiple times, but here we're just copying the one from BMW instead of changing it again.
        public override void BaseMethodWithOverride()
        {
            // Shortcut to invoke the method as defined in BMW
            base.BaseMethodWithOverride();
        }
    }
}
