using Microsoft.AspNetCore.Mvc;

namespace PetTracker.RestService.Controllers;

public class FoodController : BaseController
{
    // GET
    public IActionResult Index()
    {
        return Ok();
    }
}