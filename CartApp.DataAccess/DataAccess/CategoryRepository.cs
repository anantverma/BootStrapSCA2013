using CartApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CartApp.DataLayer;
using CartApp.DataAccess.DataAccess;
using CartApp.DataAccess;

namespace CartApp.Business
{
    public class CategoryRepository : BaseRepositoryBL<Category>
    {
        public CategoryRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {

        }
    }
}
