using PetTracker.Business.Abstraction;
using PetTracker.DataAccess.EntityRepositories.Abstraction;

namespace PetTracker.Business;

public class MedicineService : IMedicineService
{
    private readonly IMedicineRepository _medicineRepository;

    public MedicineService(IMedicineRepository medicineRepository)
    {
        _medicineRepository = medicineRepository;
    }
}