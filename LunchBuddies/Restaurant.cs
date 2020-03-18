using System;
using System.Collections.Generic;
using System.Text;

namespace LunchBuddies
{
    class Restaurant
    {
        public List<string> Restaurants = new List<string> { "Taco Bell", "ChickFilA", "Milos", "McDonalds" };
        public string Name { get; set; }

        public Restaurant()
        {
            Random random = new Random();
            Name = Restaurants[random.Next(Restaurants.Count)];
        }
    }
}
