using Microsoft.AspNetCore.Mvc;

namespace PetTracker.RestService.Controllers;

public class CoiffeurController : BaseController
{
    // GET
    public IActionResult Index()
    {
        return Ok();
    }
}