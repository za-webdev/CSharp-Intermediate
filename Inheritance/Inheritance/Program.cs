using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Animal dog = new Dog("Puppy");
            dog.Sleep();
            dog.Eat();
            dog.Display();
            var fish = new Fish(new Swimable(),"fishy");
            fish.Eat();
            fish.Sleep();
            fish.KeepSwiming();
            fish.Display();


            Console.ReadLine();
            
        }
    }
}
