using Microsoft.EntityFrameworkCore;
using PetTracker.DataAccess.EntityRepositories.Abstraction;
using PetTracker.Entity.DbEntities;

namespace PetTracker.DataAccess.EntityRepositories;

public class MedicineRepository : BaseRepository<Medicine>,IMedicineRepository
{
    public MedicineRepository(DbContext dbContext) : base(dbContext)
    {
        
    }
}