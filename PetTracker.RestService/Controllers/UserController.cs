using Microsoft.AspNetCore.Mvc;
using PetTracker.Business.Abstraction;

namespace PetTracker.RestService.Controllers;

public class UserController : BaseController
{
    private readonly IConfiguration _configuration;
    private readonly IUserService _userService;

    public UserController(IConfiguration configuration,IUserService userService)
    {
        _configuration = configuration;
        _userService = userService;
    }
    
    [HttpPost("Login")]
    public async Task<IActionResult> Login()
    {
        return Ok();
    }
}