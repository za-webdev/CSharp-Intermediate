using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Cow: Animal
    {
        public int weight { get; set; }

        //public Cow(string breed )
        //    :base(breed)
        //{
        //    Console.WriteLine("Breed:{0}", breed);
        //}

        public void Moo()
        {
            Energy--;
        }
    }
}
