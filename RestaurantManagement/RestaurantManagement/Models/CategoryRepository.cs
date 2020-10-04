using System.Collections;
using System.Collections.Generic;

namespace RestaurantManagement.Models
{
    public class CategoryRepository: ICategoryRepository

    {
        private readonly AppDbContext _appDbContext;

        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Category> AllCategories => _appDbContext.Categories;

    }
}