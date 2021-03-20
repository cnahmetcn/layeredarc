using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LayerProject.Core.Repositories
{
    public interface IRepository<T> where T : class // T -> entity demek entity nin de bir class ı olmak zorunda
    {
        Task<T> GetByIdAsync(int id);

        Task<IEnumerable<T>> GetAllAsync();

        //find(x => x.id = 5)
        Task<IEnumerable<T>> Where(Expression<Func<T, bool>> predicate);

        // category.SingleOrDefaultAsync(x => x.Name ="Kalem")
        Task<T> SingleOrDefaultAsync(Expression<Func<T, bool>> predicate);

        Task AddAsync(T entity);

        Task AddRangeAsync(IEnumerable<T> entities);

        void Remove(T entity);

        void RemoveRange(IEnumerable<T> entities);

        T Update(T entity);

    }
}
