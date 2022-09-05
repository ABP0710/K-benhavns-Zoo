using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Københavns_Zoo
{
    internal class Animal
    {
        //propertys
        private string race;
        bool isMale;

        //encapsulation
        public string Race
        {
            get { return race; }
        }
        public bool IsMale 
        {
           get { return isMale; } 
        }

        //constructor
        public Animal(string race, bool isMale, List<Animal> animals)
        {
            this.race = race;
            this.isMale = isMale;

        }
        //public methoods
        public bool Thirsty()
        {
            bool thirsty;

            Random rnd = new Random();
            int needs = rnd.Next(0,2);

            if (needs == 0)
            {
                Console.WriteLine($"the {race} needs warter");
                thirsty = true;
            }
            else
            {
                Console.WriteLine($"the {race} got water");
                thirsty=false;
            }
            return thirsty;
        }

        public bool Hungry()
        {
            bool hungry;

            Random rnd = new Random();
            int needs = rnd.Next(0, 2);

            if (needs == 0)
            {
                Console.WriteLine($"the {race} is hungry and needs to be fed!");
                hungry = true;
            }
            else
            {
                Console.WriteLine($"the {race} is not hungry");
                hungry = false;
            }
            return hungry;
        }
    }
}
