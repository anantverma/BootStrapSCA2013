using SPAShoppingCartApp.Areas.Product.Models;
using SPAShoppingCartApp.CartService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SPAShoppingCartApp.Areas.Product.Controllers
{
    public class ProductController : Controller
    {
        private List<ProductDescription> products;
        public ActionResult Index()
        {
            return View();
        }

        private void getProducts()
        {
            products = new List<ProductDescription>();
            ICartAppService service = new CartAppServiceClient();
            products = service.GetProducts().ToList();
        }

        public ActionResult GetProducts()
        {
            var count = HttpContext.Request.QueryString.Count;
            getProducts();
            return View("GetProducts", products);
        }

        public ActionResult ProductDetails(int id)
        {
            getProducts();
            ProductDescription product = products.Where(t => t.Id == id).FirstOrDefault();
            return View("ProductDetails", product);
        }

    }
}
