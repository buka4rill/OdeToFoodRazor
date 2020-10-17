using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using OdeToFood.Core;
using OdeToFood.Data;

namespace OdeToFood.Web.Pages.Restaurants
{
    public class ListModel : PageModel
    {
        // Inject services to be used in page
        private readonly IConfiguration config;
        private readonly IRestaurantData restaurantData;
        public ListModel(IConfiguration config, IRestaurantData restaurantData)
        {
            this.config = config;
            this.restaurantData = restaurantData;
        }


        // Properties
        public string Message { get; set; }

        public IEnumerable<Restaurant> Restaurants { get; set; }

        [BindProperty(SupportsGet = true)] // This prop should receive info from req
        public string SearchTerm { get; set; }

        // public void OnGet(string searchTerm)
        // {
        //     Message = config["Message"]; // Get from appsettings.json
        //     // Restaurants = restaurantData.GetAll();
        //     Restaurants = restaurantData.GetRestaurantsByName(searchTerm);
        // }

        public void OnGet()
        {
            Message = config["Message"]; // Get from appsettings.json
            Restaurants = restaurantData.GetRestaurantsByName(SearchTerm);
        }
    }
}