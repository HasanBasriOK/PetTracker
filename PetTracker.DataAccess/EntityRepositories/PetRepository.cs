using Microsoft.EntityFrameworkCore;
using PetTracker.DataAccess.EntityRepositories.Abstraction;
using PetTracker.Entity.DbEntities;

namespace PetTracker.DataAccess.EntityRepositories;

public class PetRepository : BaseRepository<Pet>,IPetRepository
{
    public PetRepository(DbContext dbContext) : base(dbContext)
    {
        
    }
}