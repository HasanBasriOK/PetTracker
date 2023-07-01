using Microsoft.AspNetCore.Mvc;

namespace PetTracker.RestService.Controllers;

public class UserController : BaseController
{
    // GET
    public IActionResult Index()
    {
        return Ok();
    }
}