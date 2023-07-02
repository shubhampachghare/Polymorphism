using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Animal
    {
        public virtual void AnimalSound()                       //Base Class
        {
            Console.WriteLine("Animal Makes a Sound");
        }
    }
    class Pig : Animal 
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Pig Says Wee Wee");
        }
    }

    class Dog:Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("The Dog Says : Bow Bow");
        }
    }
}
