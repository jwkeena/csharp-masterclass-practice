using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpPractice.Section6Classes; 
// Notice the separate namespace for all the classes I'll be trying to instantiate here. 
// I can't put the classes to be instantiated here as nested classes because 
// Apparently calling methods on nested classes in the immediately higher scope doesn't work.

namespace CSharpPractice
{
    class Section6
    {
        public static void InstantiateBasicClass()
        {
            Human human = new Human();

            // Able to access the member variables and methods because they're marked public
            human.firstName = "justin";
            human.IntroduceMyself();
        }

        public static void InstantiateMultipleInstancesOfBasicClass()
        {
            Human human1 = new Human();
            Human human2 = new Human();

            human1.firstName = "Borden";
            human2.firstName = "Angier";

            human1.IntroduceMyself();
            human2.IntroduceMyself();
        }
        
        public static void InstantiateClassWithParameterizedConstructor()
        {
            User justin = new User("Justin", 10);
            justin.IntroduceMyself();
        }
    }
}
