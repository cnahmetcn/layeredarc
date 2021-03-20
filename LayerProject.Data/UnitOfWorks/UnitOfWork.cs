using LayerProject.Core.Repositories;
using LayerProject.Core.UnitOfWorks;
using LayerProject.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerProject.Data.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        private ProductRepository _productRepository;
        private CategoryRepository _categoryRepository;
        public IProductRepository Products => _productRepository = _productRepository ?? new ProductRepository(_context);
        /*
         _productRepository i al, alırken de kontrol et. Eğer _productRepository varsa kullan yoksa
        _context ile yeni bir ProductRepository oluşturup devam et. son olarak da Product a ata. 
        */
        public ICategoryRepository Categories => _categoryRepository = _categoryRepository ?? new CategoryRepository(_context);

        public UnitOfWork(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
