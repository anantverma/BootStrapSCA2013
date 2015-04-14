using CartApp.DataAccess.DataAccess;
using CartApp.DataLayer;
using CartApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartApp.DataAccess
{
    public class BrandRepository : BaseRepositoryBL<Brand>
    {
        public BrandRepository(IUnitOfWork unitOfWork) 
            : base(unitOfWork)
        {

        }
        
    }
}
