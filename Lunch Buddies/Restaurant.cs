using System;
using System.Collections.Generic;
using System.Text;

namespace Lunch_Buddies
{
    class Restaurant
    {
        private List<string> RestaurantNames = new List<string> { "Logan's", "Hardees", "Taco Bell", "Subway" };

        public string Name { get; set; }

        public Restaurant()
        {
            Random random = new Random();

            Name = RestaurantNames[random.Next(RestaurantNames.Count)];
        }
    }
}
