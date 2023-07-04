using PetTracker.Business.Abstraction;
using PetTracker.DataAccess.EntityRepositories.Abstraction;

namespace PetTracker.Business;

public class TreatmentService : ITreatmentService
{
    private readonly ITreatmentRepository _treatmentRepository;

    public TreatmentService(ITreatmentRepository treatmentRepository)
    {
        _treatmentRepository = treatmentRepository;
    }
}