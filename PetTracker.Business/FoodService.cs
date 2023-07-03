using PetTracker.Business.Abstraction;
using PetTracker.DataAccess.EntityRepositories.Abstraction;

namespace PetTracker.Business;

public class FoodService : IFoodService
{
    private readonly IFoodRepository _foodRepository;

    public FoodService(IFoodRepository foodRepository)
    {
        _foodRepository = foodRepository;
    }
}