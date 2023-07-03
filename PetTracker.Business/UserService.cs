using PetTracker.Business.Abstraction;

namespace PetTracker.Business;

public class UserService : IUserService
{
    private readonly IUserService _userService;

    public UserService(IUserService userService)
    {
        _userService = userService;
    }
}