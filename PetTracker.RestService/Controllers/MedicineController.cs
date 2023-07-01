using Microsoft.AspNetCore.Mvc;

namespace PetTracker.RestService.Controllers;

public class MedicineController : BaseController
{
    // GET
    public IActionResult Index()
    {
        return Ok();
    }
}