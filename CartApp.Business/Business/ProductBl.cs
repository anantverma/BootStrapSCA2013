using CartApp.Entities;
using CartApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CartApp.DataLayer;

namespace CartApp.Business
{
    public class ProductDescriptionBl : IProductDescriptionBL
    {
        public IEnumerable<ProductDescription> List
        {
            get
            {
                IEnumerable<ProductDescription> products = new List<ProductDescription>();
                using (ShoppingCartDbEntities context = new ShoppingCartDbEntities())
                {
                    products = context.ProductDescriptions.ToList().AsEnumerable();
                }
                return products;
            }
        }

        public void Add(ProductDescription entity)
        {
            using (ShoppingCartDbEntities context = new ShoppingCartDbEntities())
            {
                context.ProductDescriptions.Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(ProductDescription entity)
        {
            using (ShoppingCartDbEntities context = new ShoppingCartDbEntities())
            {
                context.ProductDescriptions.Remove(entity);
                context.SaveChanges();
            }
        }

        public void Update(ProductDescription entity)
        {
            using (ShoppingCartDbEntities context = new ShoppingCartDbEntities())
            {
                context.Entry<ProductDescription>(entity).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public ProductDescription FindById(int Id)
        {
            ProductDescription productDescription;
            using (ShoppingCartDbEntities context = new ShoppingCartDbEntities())
            {
                productDescription = context.ProductDescriptions.Where(prod => prod.Id == Id).FirstOrDefault();
            }
            return productDescription;
        }
    }
}
