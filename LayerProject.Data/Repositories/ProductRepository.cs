using LayerProject.Core.Entity;
using LayerProject.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerProject.Data.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private AppDbContext _appDbContext { get => _context as AppDbContext; }
        public ProductRepository(AppDbContext context) : base(context)
        {
            /*
             Repository içerisinde bir tane constructor olduğu için ve biz bu Repository i
             miras aldığımız için mutlaka burada da bir constructor olmak zorunda. bu yüzden
             almış olduğumuz DbContext i base deki context e gönderdik. Repository de ki 
             _context dolmuş oldu. ProductRepository içerisindeki _context i as keyword ü ile
             beraber AppDbContext e atadık ve vu sayede appDbContext ile Product ta ulaşmış
             olduk.
            */
        }

        public async Task<Product> GetWithCategoryByIdAsync(int productId)
        {
            var product = _appDbContext.Products.Include(x => x.Category).SingleOrDefaultAsync(x => x.Id == productId);
            return await product;
            // Tek bir product dönerken Include metodu ile beraber ilgili Category i de 
            // product a ekledik
        }
    }
}
