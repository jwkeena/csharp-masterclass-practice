using System;

namespace CSharpPractice.Section6Classes
{
    internal class User
    {
        // Member variables
        public string firstName;
        public int coolnessLevel;

        // Member methods
        public void IntroduceMyself()
        {
            Console.WriteLine("Hello, my name is " + firstName);
        }

        // Parameterized constructur
        public User(string a, int b)
        {
            firstName = a;
            coolnessLevel = b;
        }
    }
}