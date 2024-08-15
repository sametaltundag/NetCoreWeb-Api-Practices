using System.Linq.Expressions;

namespace NLayer.Core.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        // productRepo.GetAll(x => x.id>5).ToList();
        IQueryable<T> GetAll(Expression<Func<T, bool>> expression);

        // productRepo.where(x => x.id>5).OrderBy.ToListAsync();
        IQueryable<T> Where(Expression<Func<T,bool>> expression);

        Task<T> GetByIdAsync(int id);
        Task<bool> AnyAsync(Expression<Func<T,bool>> expression);
        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);

        void Update(T entity);
        void Remote(T entity);
        void RemoteRange(IEnumerable<T> entities); 




    }
}
