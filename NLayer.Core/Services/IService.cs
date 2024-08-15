using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Services
{
    public interface IService<T> where T : class
    {
        // productRepo.where(x => x.id>5).OrderBy.ToListAsync();
        IQueryable<T> Where(Expression<Func<T, bool>> expression);

        // productRepo.GetAll(x => x.id>5).ToList();
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);
        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);

        // Generic repoda her ne kadar void olsa da IService için bunlar asenkron işleme tabii tutulur.
        Task UpdateAsync(T entity);
        Task RemoteAsync(T entity);
        Task RemoveRangeAsync(IEnumerable<T> entities);
    }
}
