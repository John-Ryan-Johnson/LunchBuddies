using System;
using System.Collections.Generic;
using System.Text;

namespace Lunch_Buddies
{
    class LunchBuddy
    {
        //properties

        public string FirstName { get; set; }
        public string LastName { get; set; }

        //constructor
        public LunchBuddy(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        //methods
        public void Eat()
        {
            var restaurant = new Restaurant();
            Console.WriteLine($"{FirstName} {LastName} is at {restaurant.Name}.");
        }

        public void Eat(string food)
        {
            Console.WriteLine($"{FirstName} {LastName} ate {food} at the office.");
        }

        public void Eat(List<LunchBuddy> companions)
        {
            var restaurant = new Restaurant();
            var firstNames = new List<string> { };
            foreach (var companion in companions)
            {
                var first = companion.FirstName;
                firstNames.Add(first);
            }
            string buddies = string.Join(",", firstNames);
            Console.WriteLine($"{FirstName} {LastName} is at {restaurant.Name} with {buddies}.");
        }

        public void Eat(string food, List<LunchBuddy> companions)
        {
            var restaurant = new Restaurant();
            var firstNames = new List<string> { };
            foreach (var companion in companions)
            {
                var first = companion.FirstName;
                firstNames.Add(first);
            }
            string buddies = string.Join(",", firstNames);
            Console.WriteLine($"{FirstName} {LastName} at {restaurant.Name} just ordered {food} with {buddies}.");
        }
    }
}
