using System;
using System.Collections.Generic;

namespace LunchBuddies
{
    class Program
    {
        static void Main(string[] args)
        {
            var LunchBuddy = new LunchBuddy("Ginger", "Root");

            List<LunchBuddy> companions = new List<LunchBuddy> { };
            var buddy1 = new LunchBuddy("Beet", "Root");
            var buddy2 = new LunchBuddy("Tap", "Root");
            companions.Add(buddy1);
            companions.Add(buddy2);

            LunchBuddy.Eat("nacho fries");
            LunchBuddy.Eat(companions);
            LunchBuddy.Eat("fries", companions);
            Console.ReadKey();
        }
    }
}
