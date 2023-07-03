using PetTracker.Business.Abstraction;

namespace PetTracker.Business;

public class PetService : IPetService
{
    private readonly IPetService _petService;

    public PetService(IPetService petService)
    {
        _petService = petService;
    }
}