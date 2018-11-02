using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Examples
{
    public class AnimalGame
    {
        public List<Mammal> StuffOnMyFarm { get; set; }
        public Chicken Chicken { get; set; }
        public Cow Cow { get; set; }
        public Person Person { get; set; }

        public void Init()
        {
            StuffOnMyFarm = new List<Mammal>()
            {
                new Chicken(),
                new Cow("Brad"),
                new Person("Worker#987324987")
            };

            Mammal guy = new Person("alksdlksjadf");
            ((Person)guy).Celebrate();
            Overlap(guy, new Chicken());
        }

        public void Update()
        {
            // Movement and collision detection
            
            foreach (var first in StuffOnMyFarm)
            {
                foreach (var second in StuffOnMyFarm)
                {
                    // Check everyone against everyone for overlap!
                    
                }
            }

            // Polymorphic code!
            Overlap(new Cow("Chad"), new Chicken());
        }

        public void Overlap(Mammal first, Mammal second)
        {

        }
    }

    public abstract class Mammal
    {
        public int Width { get; set; }
        public int PosX { get; set; }
        public int PosY { get; set; }
        public int Velocity { get; set; }
        public string Direction { get; set; }

        public string Name { get; private set; }

        public Mammal(string name)
        {
            Name = name;
        }

        public abstract void Run(string direction);

        public virtual void Speak(string say)
        {
            Console.WriteLine(say);
        }

        public virtual void Speak()
        {
            // I'm silent, I don't make noise.            
        }

        public virtual void Scream()
        {
            Console.WriteLine("AHHHHHHH!!");
        }

        public void RandomlyRun()
        {
            // pick a random direciton.
            Run("up");
            Speak("The aliens are comming!");
        }
    }

    public class Chicken : Mammal
    {
        public Chicken() : base("Chicken")
        {
        }

        public override void Run(string direction)
        {
            Direction = direction;
            Velocity += 2;
        }
        
        public override void Speak()
        {
            Console.WriteLine("Bock bock");
        }

        
    }

    public class Cow : Mammal
    {
        public Cow(string name) : base(name)
        {
        }

        public override void Run(string direction)
        {
            Direction = direction;
            Velocity += 5;
        }

        public override void Speak()
        {
            Console.WriteLine("Moooooooooooooo!");
        }

        public override void Scream()
        {
            base.Scream();
            //Console.WriteLine("mo.");
        }
    }

    public class BrownCow : Cow
    {
        public BrownCow(string name) : base(name)
        {
        }

        public override void Run(string direction)
        {
            base.Run(direction);
            Velocity = 10;
        }
    }

    public sealed class Person : Mammal
    {
        public Person(string name) : base(name)
        {
        }

        public override void Run(string direction)
        {
            Direction = direction;
            Velocity += 1;
        }

        public override void Speak()
        {
            Console.WriteLine("I need starbucks!");
        }

        public void Celebrate()
        {
            Console.WriteLine("WoooHooo!!!");
        }
    }

    // You cannot inherit from a sealed class.
    //public class King : Person
    //{

    //}

    public class Worm : Mammal
    {
        public Worm() : base("...")
        {
        }

        public override void Run(string direction)
        {
            Velocity -= 1;
        }
    }

    public class Tucan : Mammal
    {
        public Tucan(string name) : base(name)
        {
        }

        public override void Run(string direction)
        {
            Velocity += 100;
        }

        public override void Speak(string say)
        {
            Console.WriteLine(say.ToUpper());
        }
    }
}
