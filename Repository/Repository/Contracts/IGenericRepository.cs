using System.Linq.Expressions;

namespace Repository.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> Add(T entity);
        Task AddRange(IEnumerable<T> entities);
        Task<IEnumerable<T>> Find(Expression<Func<T, bool>> expression);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> Get(int id);
        Task<T> UpdateAsync(T entity);
        Task<T> DeleteAsync(T entity);
        Task<bool> DeleteRangeAsync(IEnumerable<T> entities);
        Task<T> FindItem(Expression<Func<T, bool>> expression);

    }
}
