using Microsoft.EntityFrameworkCore;
using PetTracker.Entity.DbEntities;

namespace PetTracker.DataAccess.EntityRepositories.Abstraction;

public class VaccineRepository : BaseRepository<Vaccine> , IVaccineRepository
{
    public VaccineRepository(DbContext dbContext) : base(dbContext)
    {
        
    }
}