using PetTracker.Business.Abstraction;
using PetTracker.DataAccess.EntityRepositories.Abstraction;

namespace PetTracker.Business;

public class CoiffeurService : ICoiffeurService
{
    private readonly ICoiffeurRepository _coiffeurRepository;

    public CoiffeurService(ICoiffeurRepository coiffeurRepository)
    {
        _coiffeurRepository = coiffeurRepository;
    }
}