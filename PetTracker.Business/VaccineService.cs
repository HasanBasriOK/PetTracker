using PetTracker.Business.Abstraction;
using PetTracker.DataAccess.EntityRepositories.Abstraction;

namespace PetTracker.Business;

public class VaccineService : IVaccineService
{
    private readonly IVaccineRepository _vaccineRepository;

    public VaccineService(IVaccineRepository vaccineRepository)
    {
        _vaccineRepository = vaccineRepository;
    }
}