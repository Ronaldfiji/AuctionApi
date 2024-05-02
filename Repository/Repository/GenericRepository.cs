
using DataModel.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Repository.Contracts;
using System.Linq.Expressions;

namespace Repository.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {

        protected readonly AuctionDBContext _context;
        protected readonly ILogger _logger;
        public GenericRepository(AuctionDBContext context, ILogger logger)
        {
            _context = context;
            _logger = logger;
        }


        public virtual async Task<T> Add(T entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException($"{nameof(Add)} new entity must not be null");
                }
                var newEntity = await _context.Set<T>().AddAsync(entity);
                await _context.SaveChangesAsync();

                return newEntity.Entity;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} Add() method error", typeof(GenericRepository<T>));
                throw new Exception($"{nameof(Add)} method error. {typeof(GenericRepository<T>)}: entity could not be saved." +
                    $" Review error logs  " + ex);

            }
        }

        public virtual async Task AddRange(IEnumerable<T> entities)
        {
            try
            {
                if (entities == null)
                {
                    throw new ArgumentNullException($"{nameof(Add)} new entity must not be null");
                }
                _context.Set<T>().AddRange(entities);
                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} AddRange() method error", typeof(GenericRepository<T>));
                throw new Exception($"{nameof(AddRange)} method error. {typeof(T)}: entity could not be saved." +
                    $" Review error logs  " + ex.Message);

            }

        }

        /* This is actual predicate expression func/
         *  public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Where(expression);
        }*/
        // To get one entity - > products.Where(p => p.Name == name).FirstOrDefault()!; 

        public virtual async Task<T> FindItem(Expression<Func<T, bool>> expression)
        {
            try
            {
                var result = await _context.Set<T>().Where(expression).FirstOrDefaultAsync();

                return result!;
            }
            catch (Exception ex)
            {
                throw new Exception($"Could not retrieve entity:{ex.Message}");
            }
        }

        public virtual async Task<IEnumerable<T>> Find(Expression<Func<T, bool>> expression)
        {
            try
            {
                var result = await _context.Set<T>().Where(expression).ToListAsync();
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception($"Could not retrieve entities:{ex.Message}");
            }
        }


        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            try
            {
                return await _context.Set<T>().ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Could not retrieve entities:{ex.Message}");

            }
        }

        public virtual async Task<T> Get(int id)
        {
            try
            {
                var entity = await _context.Set<T>().FindAsync(id);
                return entity!;

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} GetUserByID(Get) method error", typeof(GenericRepository<T>));
                throw new Exception($"Failed to find Entity with {nameof(id)} .  " + ex.Message);
            }
        }

        public virtual async Task<T> UpdateAsync(T entity)
        {
            //var newObj = _context.Entry(entity).State = EntityState.Modified;

            try
            {
                var item = _context.Set<T>().Update(entity);
                await _context.SaveChangesAsync();
                return item.Entity;
            }
            catch (DbUpdateConcurrencyException)
            {

                if (await _context.Set<T>().FindAsync(entity.GetType().GetProperty("Id")) == null)
                {
                    return null!;
                }
                else
                {
                    throw;
                }
            }

            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} Update() method error", typeof(GenericRepository<T>));
                throw new Exception($"Failed to update Entity with {nameof(entity)} .  " + ex);
            }
        }



        /*  public virtual async Task<T> UpdateAsync(T entity)
              {
                  try
                  {
                      var item = _context.Set<T>().Update(entity);
                      await _context.SaveChangesAsync();
                      return item.Entity;
                  }

                  catch (Exception ex)
                  {
                      _logger.LogError(ex, "{Repo} Update() method error", typeof(GenericRepository<T>));
                      throw new Exception($"Failed to update Entity with {nameof(entity)} .  " + ex.Message);
                  }
              }*/


        public virtual async Task<T> DeleteAsync(T entity)
        {
            try
            {
                var item = _context.Set<T>().Remove(entity);
                await _context.SaveChangesAsync();
                return item.Entity;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} Delete() method error", typeof(GenericRepository<T>));
                throw new Exception($"Failed to delete Entity with {nameof(entity)} .  " + ex.Message);
            }
        }

        public virtual async Task<bool> DeleteRangeAsync(IEnumerable<T> entities)
        {
            try
            {
                _context.Set<T>().RemoveRange(entities);
                int result = await _context.SaveChangesAsync();
                return (result > 0);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} DeleteRange() method error", typeof(GenericRepository<T>));
                throw new Exception($"Failed to delete Entities with {nameof(entities)} .  " + ex.Message);
            }

        }




    }
}
