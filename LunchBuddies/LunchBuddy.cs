using System;
using System.Collections.Generic;
using System.Text;

namespace LunchBuddies
{
    class LunchBuddy
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public LunchBuddy(string fName, string lName)
        {
            Fname = fName;
            Lname = lName;
        }

        public string Eat()
        {
            var restaurant = new Restaurant();
            Console.WriteLine($"{Fname} {Lname} is at {restaurant.Name}");
            return restaurant.Name;
        }

        public void Eat(string food)
        {
            Console.WriteLine($"{Fname} {Lname} is eating {food}");
        }

        public void Eat(List<LunchBuddy> companions)
        {
            var restaurant = new Restaurant();
            var str = Fname + " " + Lname + " is eating at " + restaurant.Name + " with ";
            foreach (var companion in companions)
            {
                str += companion.Fname + ", ";
            }
            Console.WriteLine(str);
        }

        public void Eat(string food, List<LunchBuddy> companions)
        {
            var restaurant = new Restaurant();
            var str = Fname + " " + Lname + " is eating " + food + " at " + restaurant.Name + " with ";
            foreach (var companion in companions)
            {
                str += companion.Fname + ", ";
            }
            Console.WriteLine(str);
        }
    }
}
