using EightToTen.Services.RestaurantPicker;
using Microsoft.AspNetCore.Mvc;

namespace EightToTen.Controllers;

[ApiController]
[Route("[controller]")]
public class RestaurantPickerController : ControllerBase
{
    private readonly IRestaurantPickerService _restaurantPickerService;

    public RestaurantPickerController(IRestaurantPickerService restaurantPickerService)
    {
        _restaurantPickerService = restaurantPickerService;
    }

    [HttpGet]
    [Route("CategoryOrigin/{numberChoice}")]
    public string CategoryOrigin(string numberChoice) {
        return _restaurantPickerService.CategoryOrigin(numberChoice);
    }
    [HttpGet]
    [Route("CategoryFood/{numberChoice}")]
    public string CategoryFood(string numberChoice) {
        return _restaurantPickerService.CategoryFood(numberChoice);
    }
    
    [HttpGet]
    [Route("CategoryRating/{numberChoice}")]
    public string CategoryRating(string numberChoice) {
        return _restaurantPickerService.CategoryRating(numberChoice);
    }
}