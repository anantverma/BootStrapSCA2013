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
            products.Add(new Models.Product { CategoryId = 1, ProductId = 1, ProductPrice = 1000, ProductName = "Bata Shoes", ProductDescription = "Comfortable shoes.", ProductImage = null });
            products.Add(new Models.Product { CategoryId = 1, ProductId = 2, ProductPrice = 2000, ProductName = "Bata Shoes", ProductDescription = "Comfortable shoes.", ProductImage = null });
            products.Add(new Models.Product { CategoryId = 1, ProductId = 3, ProductPrice = 3000, ProductName = "Bata Shoes", ProductDescription = "Comfortable shoes.", ProductImage = null });
            products.Add(new Models.Product { CategoryId = 1, ProductId = 4, ProductPrice = 4000, ProductName = "Bata Shoes", ProductDescription = "Comfortable shoes.", ProductImage = null });
            products.Add(new Models.Product { CategoryId = 1, ProductId = 5, ProductPrice = 5000, ProductName = "Bata Shoes", ProductDescription = "Comfortable shoes.", ProductImage = null });
            products.Add(new Models.Product { CategoryId = 1, ProductId = 6, ProductPrice = 6000, ProductName = "Bata Shoes", ProductDescription = "Comfortable shoes.", ProductImage = null });
        }

        public ActionResult GetProducts()
        {
            getProducts();
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
