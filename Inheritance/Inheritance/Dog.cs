using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Dog : Animal
    {
        public string Breed { get; set; }

        public Dog(string breed)
            : base(breed)
        {
            Console.WriteLine("Breed:{0}", breed);
        }

        public void Bark()
        {
            Energy--;
        }
    }
}
