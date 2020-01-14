using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CSharpPractice.Section6Repository
{
    class Members
    {
        // There are many kinds of members in a class. Here are most of them:

        // member - private field
        private string memberName;
        private string jobTitle;
        private int salary;

        // member - public field 
        public int age;

        // member - property - exposes jobTitle safely
        public string JobTitle { get; set; }

        // member - public method (can be called from other classes)
        public void WhatIsYourSalary (bool isFriend)
        {
            if (isFriend)
            {
                ShareSalary();
            }
            else
            {
                Console.WriteLine("You aren't my friend! Go away.");
            }
        }

        // member - private method (can only be called from this class or others that inherit from it)
        // notice that the only way of calling this method from a higher class is by calling a PUBLIC method in this class that then, in turn, calls this private class
        // As, in fact, the member method WhatsYourSalary() above does.
        private void ShareSalary()
        {
            Console.WriteLine("I make " + salary + " dollars!! My tax return is probably more than YOUR salary lol");
        }

        // member - constructor
        public Members()
        {
            age = 30;
            jobTitle = "developer";
            memberName = "Jason";
            salary = 1000000;
            Console.WriteLine("Object created");
        }

        // member - finalizer/destructor
        // There can only be one finalizer/destructor per class (unlike constructors)
        // Can only be defined in a class, not in a struct (whatever that is)
        // Cannot be inherited, overloaded, or called. It just fires automatically when the .NET framework (or core) does its garbage collecting
        // The Garbage Collector can remove the object when it is no longer reachable, or in scope, by any other part of the program
        // So, it only exists for making cleanup statements
        ~Members() // Needs tilde, then name of the class
        {
            Console.WriteLine("Deconstruction of Members object"); // This one I can't even see on the console
            Debug.Write("Members object destroyed"); // This message shows up in the Output bar
        }
    }
}
