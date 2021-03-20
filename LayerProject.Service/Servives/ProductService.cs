using LayerProject.Core.Entity;
using LayerProject.Core.Repositories;
using LayerProject.Core.Services;
using LayerProject.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LayerProject.Service.Servives
{
    public class ProductService : Service<Product>, IProductService
    {
        public ProductService(IUnitOfWork unitOfWork, IRepository<Product> repository) : base(unitOfWork, repository)
        {
        }

        public async Task<Product> GetWithCategoryByIdAsync(int productId)
        {
           return await _unitOfWork.Products.GetWithCategoryByIdAsync(productId);
        }
    }
}
