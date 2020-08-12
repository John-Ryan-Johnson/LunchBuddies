using Lunch_Buddies;
using System;
using System.Collections.Generic;

namespace LunchBuddies
{
    class Program
    {
        static void Main(string[] args)
        {
            LunchBuddy lunchBuddy1 = new LunchBuddy("John", "Johnson");
            LunchBuddy lunchBuddy2 = new LunchBuddy("Devon", "Johnson");
            LunchBuddy lunchBuddy3 = new LunchBuddy("Dylan", "Johnson");
            LunchBuddy lunchBuddy4 = new LunchBuddy("Kalei", "Johnson");

            List<LunchBuddy> companions = new List<LunchBuddy> { };

            companions.Add(lunchBuddy1);
            companions.Add(lunchBuddy2);
            companions.Add(lunchBuddy3);
            companions.Add(lunchBuddy4);

            lunchBuddy1.Eat();
            lunchBuddy2.Eat("Tuna Salad");
            lunchBuddy3.Eat(companions);
            lunchBuddy4.Eat("Spaghetti", companions);
            Console.ReadLine();
        }
    }
}
