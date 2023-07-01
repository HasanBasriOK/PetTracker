using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace PetTracker.DataAccess;

public class BaseRepository<T> : IRepository<T> where T : class,new()
{
    private readonly DbContext _dbContext;

    public BaseRepository(DbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<T> GetById(Guid id)
    {
        if (id.Equals(null)) throw new ArgumentNullException();
        
        return await _dbContext.Set<T>().FindAsync(id);
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _dbContext.Set<T>().ToListAsync();
    }

    public IQueryable<T> Where(Expression<Func<T, bool>> predicate)
    {
        return _dbContext.Set<T>().Where(predicate);
    }

    public async Task<T> AddAsync(T dbObject)
    {
        return (await _dbContext.Set<T>().AddAsync(dbObject)).Entity;
    }

    public void Update(T dbObject)
    {
         _dbContext.Set<T>().Update(dbObject);
    }

    public void Delete(T dbObject)
    {
        _dbContext.Set<T>().Remove(dbObject);
    }
}