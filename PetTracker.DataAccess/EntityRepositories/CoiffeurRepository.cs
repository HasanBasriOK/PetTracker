using Microsoft.EntityFrameworkCore;
using PetTracker.DataAccess.EntityRepositories.Abstraction;
using PetTracker.Entity.DbEntities;

namespace PetTracker.DataAccess.EntityRepositories;

public class CoiffeurRepository : BaseRepository<Coiffeur> , ICoiffeurRepository
{
    public CoiffeurRepository(DbContext dbContext) : base(dbContext)
    {
        
    }
}