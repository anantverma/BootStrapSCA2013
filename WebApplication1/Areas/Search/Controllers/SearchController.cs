using SPAShoppingCartApp.CartService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;


namespace SPAShoppingCartApp.Areas.Search.Controllers
{
    public class SearchController : Controller
    {
        [ChildActionOnly]
        public ActionResult Search()
        {
            List<SelectListItem> categoryList = new List<SelectListItem>();
            ICartAppService service = new CartAppServiceClient();
            var categories = service.GetCategories();
            foreach(var category in categories)
            {
                categoryList.Add(new SelectListItem { Text = category.CategoryName, Value = category.Id.ToString() });
            }
            ViewBag.Categories = categoryList;
            return PartialView("_Search");
        }
        
    }
}
