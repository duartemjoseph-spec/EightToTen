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
    // 1. Clean the input
    string cat = category.ToLower().Trim();

    // 2. Setup lists
    string[] pizzaPlaces = { "Domino's", "Pizza Hut", "Papa John's", "Little Caesars" };
    string[] burgerPlaces = { "McDonald's", "Burger King", "Wendy's", "In-N-Out" };
    string[] mexicanPlaces = { "Taco Bell", "Chipotle", "Del Taco", "El Pollo Loco" };
    
    Random rng = new Random();

    // 3. Check categories
    if (cat == "pizza")
    {
        int index = rng.Next(pizzaPlaces.Length);
        return $"You should eat at: {pizzaPlaces[index]}";
    }
    else if (cat == "burger") 
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
        return $"ERROR: The computer received '{cat}'. Expected 'pizza', 'burger', or 'mexican'.";
    }
}}}