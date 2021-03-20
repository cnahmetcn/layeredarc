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
    class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private AppDbContext _appDbContext { get => _context as AppDbContext; }
        public CategoryRepository(AppDbContext context) : base(context)
        {
            /*
             Repository içerisinde bir tane constructor olduğu için ve biz bu Repository i
             miras aldığımız için mutlaka burada da bir constructor olmak zorunda. bu yüzden
             almış olduğumuz DbContext i base deki context e gönderdik. Repository de ki 
             _context dolmuş oldu. CategoryRepository içerisindeki _context i as keyword ü ile
             beraber AppDbContext e atadık ve vu sayede appDbContext ile Category ye ulaşmış
             olduk.
            */
        }
        public async Task<Category> GetWithProductByIdAsync(int categoryId)
        {
            var category = _appDbContext.Categories.Include(x => x.Products).SingleOrDefaultAsync(x => x.Id == categoryId);
            return await category;
        }
    }
}
