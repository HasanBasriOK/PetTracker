using System.Linq.Expressions;

namespace PetTracker.DataAccess;

public interface IRepository<T> where T : class,new()
{
    Task<T> GetById(Guid id);
    Task<IEnumerable<T>> GetAllAsync();
    IQueryable<T> Where(Expression<Func<T, bool>> predicate);
    Task<T> AddAsync(T dbObject);
    void Update(T dbObject);
    void Delete(T dbObject);
}