using PetTracker.Business.Abstraction;

namespace PetTracker.Business;

public class VaccineService : IVaccineService
{
    private readonly IVaccineService _vaccineService;

    public VaccineService(IVaccineService vaccineService)
    {
        _vaccineService = vaccineService;
    }
}