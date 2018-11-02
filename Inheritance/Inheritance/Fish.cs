using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Fish : Animal
    {
        public string Color { get; set; }
        private readonly Swimable _swim;

        public Fish(Swimable swim, string breed)
            : base(breed)
        {
            Console.WriteLine("Breed:{0}", breed);
            _swim = swim;
        }

        public void KeepSwiming()
        {
            _swim.swim();
        }
    }
}
