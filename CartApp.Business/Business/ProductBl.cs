using CartApp.DataAccess;
using CartApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CartApp.Business
{
    public class ProductBL : IProductBL
    {
        private IRepository<ProductDescription> productDescriptionRepository;
        private IRepository<Product> productRepository;
        private IUnitOfWork _unitOfWork;

        public ProductBL() 
        {
            _unitOfWork = new UnitOfWork();
            productDescriptionRepository = new ProductDescriptionRepository(_unitOfWork);
            productRepository = new ProductRepository(_unitOfWork);
        }

        public IEnumerable<ProductDescription> GetProducts()
        {
            IEnumerable<ProductDescription> products = productDescriptionRepository.GetAll(null, null, string.Empty).ToList();
            return products;
        }
    }
}
