using CartApp.DataAccess;
using CartApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartApp.Business
{
    public class CategoryBL : ICategoryBL
    {
        private IRepository<Category> categoryRepository;
        private IUnitOfWork _unitOfWork;

        public CategoryBL() 
        {
            _unitOfWork = new UnitOfWork();
            categoryRepository = new CategoryRepository(_unitOfWork);
        }

        public IEnumerable<Category> ProductCategories()
        {
            IEnumerable<Category> categories = new List<Category>();
            categories = categoryRepository.GetAll(null,null,string.Empty).ToList();
            return categories;
        }
    }
}
