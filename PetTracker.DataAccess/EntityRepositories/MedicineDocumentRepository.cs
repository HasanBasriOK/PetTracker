using Microsoft.EntityFrameworkCore;
using PetTracker.DataAccess.EntityRepositories.Abstraction;
using PetTracker.Entity.DbEntities;

namespace PetTracker.DataAccess.EntityRepositories;

public class MedicineDocumentRepository : BaseRepository<MedicineDocument> , IMedicineDocumentRepository
{
    public MedicineDocumentRepository(DbContext dbContext): base(dbContext)
    {
        
    }
}