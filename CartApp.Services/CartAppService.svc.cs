using CartApp.Business;
using CartApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CartApp.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CartAppService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CartAppService.svc or CartAppService.svc.cs at the Solution Explorer and start debugging.
    public class CartAppService : ICartAppService
    {
        public void DoWork()
        {
        }

        public List<Category> GetCategories()
        {
            ICategoryBL categoryBl = new CategoryBL();
            return categoryBl.ProductCategories().ToList();
        }

        public List<ProductDescription> GetProducts()
        {
            IProductBL productBl = new ProductBL();
            return productBl.GetProducts().ToList();
        }
    }

}
