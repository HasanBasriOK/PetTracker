using PetTracker.Business.Abstraction;

namespace PetTracker.Business;

public class TreatmentService : ITreatmentService
{
    private readonly ITreatmentService _treatmentService;

    public TreatmentService(ITreatmentService treatmentService)
    {
        _treatmentService = treatmentService;
    }
}