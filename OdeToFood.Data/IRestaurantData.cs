using System.Collections.Generic;
using System.Linq;
using OdeToFood.Core;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }



    // Implement the Interface
    // Acts like Service class
    public class InMemoryRestaurantData : IRestaurantData
    {
        // Add some data for development, pending real data
        List<Restaurant> restaurants;
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant
                {
                    Id = 1,
                    Name = "Ebuka's Restaurant",
                    Location = "Lagos",
                    Cuisine = CuisineType.Italian
                },
                new Restaurant
                {
                    Id = 2,
                    Name = "Ada's Restaurant",
                    Location = "Ibadan",
                    Cuisine = CuisineType.Mexican
                },
                new Restaurant
                {
                    Id = 3,
                    Name = "Oge's Restaurant",
                    Location = "Akure",
                    Cuisine = CuisineType.Indian
                },
            };
        }


        public IEnumerable<Restaurant> GetAll()
        {
            // Return with LINQ Query
            return from r in restaurants
                   orderby r.Name // Sort by Name in Asc order
                   select r;
        }
    }
}