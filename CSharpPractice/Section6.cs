using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpPractice.Section6Repository; 
// Notice the separate namespace for all the classes I'll be trying to instantiate here. 
// I can't put the classes to be instantiated here as nested classes because 
// Apparently calling methods on nested classes in the immediately higher scope doesn't work.

namespace CSharpPractice
{
    // Object Oriented Programming
    class Section6
    {
        public static void InstantiateBasicClass()
        {
            Human human = new Human();

            // Able to access the member variables and methods because they're marked public
            human.firstName = "justin";
            human.IntroduceMyself();
        }

        public static void MultipleInstancesOfBasicClass()
        {
            Human human1 = new Human();
            Human human2 = new Human();

            human1.firstName = "Borden";
            human2.firstName = "Angier";

            human1.IntroduceMyself();
            human2.IntroduceMyself();
        }
        
        public static void UseDefaultConstructor()
        {
            HomoSapiens randomGuy = new HomoSapiens();

            // Public member methods can still be invoked, but the information will be missing
            randomGuy.IntroduceMyself();
        }

        public static void UseParameterizedConstructor()
        {
            HomoSapiens justin = new HomoSapiens("Justin", 10);
            justin.IntroduceMyself();

            // Note that not all parameters need to be entered, as long as there is an overload for it
            HomoSapiens jason = new HomoSapiens("Jason");
            jason.IntroduceMyself();
        }
    }
}
