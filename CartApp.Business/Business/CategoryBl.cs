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
    public class CategoryBl : ICategoryBL
    {
        public IEnumerable<Category> List
        {
            get
            {
                IEnumerable<Category> products = new List<Category>();
                using (ShoppingCartDbEntities context = new ShoppingCartDbEntities())
                {
                    products = context.Categories.ToList().AsEnumerable();
                }
                return products;
            }
        }

        public void Add(Category entity)
        {
            using (ShoppingCartDbEntities context = new ShoppingCartDbEntities())
            {
                context.Categories.Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(Category entity)
        {
            using (ShoppingCartDbEntities context = new ShoppingCartDbEntities())
            {
                context.Categories.Remove(entity);
                context.SaveChanges();
            }
        }

        public void Update(Category entity)
        {
            using (ShoppingCartDbEntities context = new ShoppingCartDbEntities())
            {
                context.Entry<Category>(entity).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public Category FindById(int Id)
        {
            Category Category;
            using (ShoppingCartDbEntities context = new ShoppingCartDbEntities())
            {
                Category = context.Categories.Where(prod => prod.Id == Id).FirstOrDefault();
            }
            return Category;
        }
    }
}
