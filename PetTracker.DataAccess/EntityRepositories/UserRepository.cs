using Microsoft.EntityFrameworkCore;
using PetTracker.DataAccess.EntityRepositories.Abstraction;
using PetTracker.Entity.DbEntities;

namespace PetTracker.DataAccess.EntityRepositories;

public class UserRepository : BaseRepository<User>,IUserRepository
{
    public UserRepository(DbContext dbContext) : base(dbContext)
    {
        
    }
}