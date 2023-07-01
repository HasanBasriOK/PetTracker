using Microsoft.AspNetCore.Mvc;

namespace PetTracker.RestService.Controllers;

public class TreatmentController : BaseController
{
    // GET
    public IActionResult Index()
    {
        return Ok();
    }
}