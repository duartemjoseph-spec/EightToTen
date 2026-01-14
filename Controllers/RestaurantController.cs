using Microsoft.AspNetCore.Mvc;
using EightToTen.Services;

namespace EightToTen.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RestaurantController : ControllerBase
    {
        private readonly RestaurantService _restaurantService;

        public RestaurantController(RestaurantService restaurantService)
        {
            _restaurantService = restaurantService;
        }

        [HttpGet("Pick/Pizza, Burgers, Mexican/{category}")]
        public string PickRestaurant(string category)
        {
            return _restaurantService.PickRestaurant(category);
        }
    }
}