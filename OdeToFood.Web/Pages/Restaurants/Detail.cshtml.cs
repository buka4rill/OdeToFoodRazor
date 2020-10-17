using Microsoft.AspNetCore.Mvc.RazorPages;
using OdeToFood.Core;

namespace OdeToFood.Web.Pages.Restaurants
{
    public class DetailModel : PageModel
    {
        // Show details for a specific restaurant
        public Restaurant Restaurant { get; set; }

        public void OnGet(int restaurantId)
        {
            Restaurant = new Restaurant();
            Restaurant.Id = restaurantId;
        }
    }
}