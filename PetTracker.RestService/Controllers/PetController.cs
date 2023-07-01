using Microsoft.AspNetCore.Mvc;

namespace PetTracker.RestService.Controllers;

public class PetController : BaseController
{
    // GET
    public IActionResult Index()
    {
        return Ok();
    }
}