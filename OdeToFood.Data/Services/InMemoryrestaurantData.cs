using OdeToFood.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data.Services
{
    public class InMemoryrestaurantData : IRestaurantData
    {
        public List<Restaurant> restaurants;

        public InMemoryrestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant{Id=1, Name="Scott's Pizza", Cuisine=CuisineType.Italine},
                new Restaurant{Id=2, Name="taviska", Cuisine=CuisineType.French},
                new Restaurant{Id=3, Name="Mango Grove", Cuisine=CuisineType.Indian}
            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(r => r.Name);
        }

        public void Add(Restaurant restaurant)
        {
            restaurants.Add(restaurant);
            restaurant.Id = restaurants.Max(r => r.Id)+1;
        }

        public void Update(Restaurant restaurant)
        {
            var existing = Get(restaurant.Id);
            if(existing!=null)
            {
                existing.Name = restaurant.Name;
                existing.Cuisine = restaurant.Cuisine;
            }
        }

        public Restaurant Get(int id)
        {
            return restaurants.FirstOrDefault(r => r.Id == id);
        }

        public void Delete(int id)
        {
            var restaurant = Get(id);
            if(restaurant!=null)
            {
                restaurants.Remove(restaurant);
            }
        }
    }
}
