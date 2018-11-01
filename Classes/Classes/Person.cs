using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Person
    {
        
        public string Name { get; set; }
        public DateTime Birthdate { get; private set; }
        private Random rand = new Random();

        public int Age
        {
            get

            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;

                return years;

                //return rand.Next(100);

            }
        }
        public Person()
        {
            
        }

        public Person(string name,DateTime birthday)
        {
            this.Name = name;
            this.Birthdate = birthday;
        }

        
    }
}
