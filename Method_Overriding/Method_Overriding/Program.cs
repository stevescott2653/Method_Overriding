using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overriding
{
    public class Animal
    {
        public virtual void Eat()
        {
            Console.WriteLine("Eating...");
        }
    }

    public class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Eating dog food...");
        }
    }

    public class TestOverriding
    {
        public static void Main()
        {
            Dog d = new Dog();
            d.Eat();
        }
    }
}
