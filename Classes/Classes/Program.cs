using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Costumer
    {
        static void Main(string[] args)
        {
            var costumer = new Person("john", new DateTime(1991, 1, 19));

           
            Console.WriteLine("My name is {0} and i am {1} years old. ",costumer.Age,costumer.Name);


            //costumer.Age = 3;
            //costumer.Name = "Daffy";
            //Console.WriteLine("Hi my name is {0} and i am {1} year old", costumer.Name, costumer.Age);
            //costumer.GettingOld(new Person(10));

            
            //Console.WriteLine("now my age is {0}",costumer.Age);
        }
    }
}
