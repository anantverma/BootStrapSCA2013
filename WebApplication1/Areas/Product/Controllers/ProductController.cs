using SPAShoppingCartApp.Areas.Product.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SPAShoppingCartApp.Areas.Product.Controllers
{
    public class ProductController : Controller
    {
        List<Models.Product> products;
        public ActionResult Index()
        {
            return View();
        }

        private void getProducts()
        {
            products = new List<Models.Product>();
            products.Add(new Models.Product { CategoryId = 1, ProductId = 1, ProductBrand = "Reebok", ProductPrice = 1000, ProductName = "Bata Shoes", ProductDescription = "Comfortable shoes.", ProductImage = null });
            products.Add(new Models.Product { CategoryId = 1, ProductId = 2, ProductBrand = "Reebok", ProductPrice = 2000, ProductName = "Bata Shoes", ProductDescription = "Comfortable shoes.", ProductImage = null });
            products.Add(new Models.Product { CategoryId = 1, ProductId = 3, ProductBrand = "Bata", ProductPrice = 3000, ProductName = "Bata Shoes", ProductDescription = "Comfortable shoes.", ProductImage = null });
            products.Add(new Models.Product { CategoryId = 1, ProductId = 4, ProductBrand = "Nike", ProductPrice = 4000, ProductName = "Bata Shoes", ProductDescription = "Comfortable shoes.", ProductImage = null });
            products.Add(new Models.Product { CategoryId = 1, ProductId = 5, ProductBrand = "Nike", ProductPrice = 5000, ProductName = "Bata Shoes", ProductDescription = "Comfortable shoes.", ProductImage = null });
            products.Add(new Models.Product { CategoryId = 1, ProductId = 6, ProductBrand = "Puma", ProductPrice = 6000, ProductName = "Bata Shoes", ProductDescription = "Comfortable shoes.", ProductImage = null });
        }

        public ActionResult GetProducts(IEnumerable<FilterViewModel> filters)
        {
            getProducts();
            if (filters != null && filters.Count() > 0)
            {
                foreach (FilterViewModel filter in filters)
                {
                    products.Where(product => product.ProductBrand == filter.Value);                    
                }
            }
            return View("GetProducts", products);
        }

        public ActionResult ProductDetails(int id)
        {
            getProducts();
            Models.Product product = products.Where(t => t.ProductId == id).FirstOrDefault();
            return View("ProductDetails", product);
        }

    }
}
