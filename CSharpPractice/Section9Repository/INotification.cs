using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.Section9Repository
{
    // The interface for Notification class
    interface NotificationInterface
    {

        // Member methods that must be defined in inheriting classes
        void showNotification();
        string getDate();
    }
}
