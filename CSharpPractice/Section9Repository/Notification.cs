using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.Section9Repository
{
    // Notice that the class inherits from the interface.
    // The interface ensures that certain methods, properties, indexers, and events are defined in the class
    // The interface could also exist in the same file, but that's not standard practice.
    // One class can inherit from multiple interfaces.
    class Notification : INotification
    {
        public string Sender { get; set; }
        public string Date { get; set; }
        private string message;

        // Default constructor
        public Notification()
        {
            this.Sender = null;
            this.message = null;
            this.Date = DateTime.Now.ToString();
        }

        public Notification(string sender, string message, string date)
        {
            this.Sender = sender;
            this.message = message;
            this.Date = date;
        }

        public void showNotification()
        {
            Console.WriteLine(this.message);
        }

        public string getDate()
        {
            Console.WriteLine(this.Date);
            return this.Date;
        }
    }
}
