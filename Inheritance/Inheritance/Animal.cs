using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Animal
    {
        public int Age { get; set; }
        
        protected int Energy { get; set; }

        private readonly string _breed;
        
        public Animal()
        {

        }
        public Animal(string breed)
        {
            _breed = breed;
        }

        public void Eat()
        {
            Energy++;

        }


        public void Sleep()
        {
            Energy++;
        }

        public void Display()
        {
            Console.WriteLine("This animal has Energy of : {0}",Energy);
        }
    }

    
}
