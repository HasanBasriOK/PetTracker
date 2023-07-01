using Microsoft.EntityFrameworkCore;
using PetTracker.DataAccess.EntityRepositories.Abstraction;
using PetTracker.Entity.DbEntities;

namespace PetTracker.DataAccess.EntityRepositories;

public class TreatmentDocumentRepository : BaseRepository<TreatmentDocument>,ITreatmentDocumentRepository
{
    public TreatmentDocumentRepository(DbContext dbContext) : base(dbContext)
    {
        
    }
}