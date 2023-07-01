using Microsoft.AspNetCore.Mvc;

namespace PetTracker.RestService.Controllers;

public class VaccineController : BaseController
{
    // GET
    public IActionResult Index()
    {
        return Ok();
    }
}