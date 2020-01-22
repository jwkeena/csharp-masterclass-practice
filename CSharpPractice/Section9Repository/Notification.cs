using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.Section9Repository
{
    class Notification : NotificationInterface
    {
        private string sender;
        private string message;
        private string date;

        // Default constructor
        public Notification()
        {
            this.sender = null;
            this.message = null;
            this.date = DateTime.Now.ToString();
        }

        public Notification(string sender, string message, string date)
        {
            this.sender = sender;
            this.message = message;
            this.date = date;
        }

        public void showNotification()
        {
            Console.WriteLine(this.message);
        }

        public string getDate()
        {
            Console.WriteLine(this.date);
            return this.date;
        }
    }
}
