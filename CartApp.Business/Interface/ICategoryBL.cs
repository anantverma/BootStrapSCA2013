using CartApp.DataAccess;
using CartApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartApp.Business
{
    public interface ICategoryBL
    {
        IEnumerable<Category> ProductCategories();
    }
}
