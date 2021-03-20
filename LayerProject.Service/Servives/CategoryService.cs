using LayerProject.Core.Entity;
using LayerProject.Core.Repositories;
using LayerProject.Core.Services;
using LayerProject.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerProject.Service.Servives
{
    public class CategoryService : Service<Category>, ICategoryService
    {
        public CategoryService(IUnitOfWork unitOfWork, IRepository<Category> repository) : base(unitOfWork, repository)
        {
        }

        public async Task<Category> GetWithProductByIdAsync(int categoryId)
        {
            return await _unitOfWork.Categories.GetWithProductByIdAsync(categoryId);
        }
    }
}
