using LayerProject.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerProject.Core.Services
{
    public interface ICategoryService : IService<Category>
    {
        Task<Category> GetWithProductByIdAsync(int categoryId);

        // Category üzerinden db kullanmadan çalşacak metotlarımızı burda yazıyoruz.
    }
}
