using PetTracker.Business.Abstraction;

namespace PetTracker.Business;

public class MedicineService : IMedicineService
{
    private readonly IMedicineService _medicineService;

    public MedicineService(IMedicineService medicineService)
    {
        _medicineService = medicineService;
    }
}