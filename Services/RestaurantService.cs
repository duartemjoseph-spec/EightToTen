using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EightToTen.Services
{
    public class RestaurantService
    {
        public string PickRestaurant(string category)
        {
            // Normalize input (ignore capitals)
            string cat = category.ToLower().Trim();

            // Setup restaurant lists
            string[] pizzaPlaces = { "Domino's", "Pizza Hut", "Papa John's", "Little Caesars", "Mountain Mike's", "Round Table", "Blaze Pizza", "Mod Pizza", "Costco Pizza", "Local Slice" };
            string[] burgerPlaces = { "McDonald's", "Burger King", "Wendy's", "In-N-Out", "Five Guys", "Shake Shack", "Carl's Jr", "Jack in the Box", "Sonic", "Habit Burger" };
            string[] mexicanPlaces = { "Taco Bell", "Chipotle", "Del Taco", "El Pollo Loco", "Qdoba", "Moe's", "Rubio's", "Baja Fresh", "Taco Cabana", "Local Taqueria" };

            Random rng = new Random();

            if (cat == "pizza")
            {
                int index = rng.Next(pizzaPlaces.Length);
                return $"You should eat at: {pizzaPlaces[index]}";
            }
            else if (cat == "burgers")
            {
                int index = rng.Next(burgerPlaces.Length);
                return $"You should eat at: {burgerPlaces[index]}";
            }
            else if (cat == "mexican")
            {
                int index = rng.Next(mexicanPlaces.Length);
                return $"You should eat at: {mexicanPlaces[index]}";
            }
            else
            {
                return "Invalid Category. Please choose: Pizza, Burger, or Mexican.";
            }
        }
    }
}