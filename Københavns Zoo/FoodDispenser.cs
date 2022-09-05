using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Københavns_Zoo;
using Employees;

namespace Foods
{
    internal class FoodDispenser
    {
        //constructor
        public FoodDispenser()
        {

        }
        //public methood
        public void FeedAnimal(string Race)
        {
            if (Race == "zebra" || Race == "hippopotamus")
            {
                Console.WriteLine("Grass");
            }
            else if (Race == "tiger")
            {
                Console.WriteLine("Meat");
            }
            else if (Race == "monkey")
            {
                Console.WriteLine("Banana");
            }
            else
            {
                Console.WriteLine("The food dispenser is in the lunch room, serve cake!");
            }
        }
        public void WaterAnimal(string Race)
        {
            Console.WriteLine($"Water the {Race}");
        }
    }
}

