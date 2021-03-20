using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LayerProject.API.DTOs
{
    public class ProductWithCategoryDto : ProductDto
    {
        public CategoryDto Category { get; set; }
    }
}
