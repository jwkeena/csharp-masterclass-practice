using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.Section9Repository
{
    // The interface for Notification class.
    // Convention is to name it I<class>.
    // Notice that you can't use access modifiers (i.e., public, protected, etc)
    // By default all members are public
    // You also cannot implement members in the interface (i.e., define how the methods work in the method body)
    // Interfaces are handy for forcing a certain class structure.
    interface INotification
    {
        // Member properties that must be defined in inheriting classes
        string Sender { get; set; }
        string Date { get; set; }

        // Member methods that must be defined in inheriting classes
        void showNotification();
        string getDate();
    }
}
