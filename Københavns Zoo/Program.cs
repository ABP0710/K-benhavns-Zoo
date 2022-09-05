using System;
using System.Collections.Generic;
using Foods;
using Employees;
using Københavns_Zoo;

namespace Københavns_Zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //this is an assignment for school

            //list to store the animals
            List<Animal> ark = new List<Animal>();

            //A list to store the employees
            List<Employee> staff = new List<Employee>();

            //employees
            Employee keeper1 = new Employee("Mads", staff);
            Employee keeper2 = new Employee("Henrik", staff);
            Hr hr1 = new Hr("Mette");

            //animals
            Animal zebra1 = new Animal("zebra", true, ark);
            Animal zebra2 = new Animal("zebra", false, ark);
            Animal tiger1 = new Animal("tiger", true, ark);
            Animal tiger2 = new Animal("tiger", false, ark);
            Animal hippopotamus1 = new Animal("hippopotamus", true, ark);
            Animal hippopotamus2 = new Animal("hippopotamus", false, ark);
            Animal monkey1 = new Animal("monkey", true, ark);
            Animal monkey2 = new Animal("monkey", false, ark);

            //food dispenser
            FoodDispenser FoodD = new FoodDispenser();

            staff.Add(keeper1);
            staff.Add(keeper2);


            //test

            //is the animal hungry
            zebra1.Hungry();

            //is the animal thirsty
            tiger1.Thirsty();

            //cant make the zookeeper feed the animals

            FoodD.FeedAnimal("tiger");

            //cant make the zookeeper water the animals

            FoodD.WaterAnimal("hippopotamus");

            //HR change the name on the zookeepers
            hr1.ChangeName(keeper1, "Bob");
        }
    }
}
