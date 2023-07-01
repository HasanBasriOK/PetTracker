using Microsoft.EntityFrameworkCore;
using PetTracker.DataAccess.EntityRepositories.Abstraction;
using PetTracker.Entity.DbEntities;

namespace PetTracker.DataAccess.EntityRepositories;

public class FoodRepository : BaseRepository<Food>,IFoodRepository
{
    public FoodRepository(DbContext dbContext) : base(dbContext)
    {
        
    }
}