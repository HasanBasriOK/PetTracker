using Microsoft.EntityFrameworkCore;
using PetTracker.DataAccess.EntityRepositories.Abstraction;
using PetTracker.Entity.DbEntities;

namespace PetTracker.DataAccess.EntityRepositories;

public class TreatmentRepository:BaseRepository<Treatment>,ITreatmentRepository
{
    public TreatmentRepository(DbContext dbContext) : base(dbContext)
    {
        
    }
}