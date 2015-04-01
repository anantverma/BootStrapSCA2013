using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SPAShoppingCartApp.Areas.Search.Controllers
{
    public class SearchController : Controller
    {
        [ChildActionOnly]
        public ActionResult Search()
        {
            List<SelectListItem> categoryList = new List<SelectListItem>();
            categoryList.Add(new SelectListItem { Text = "Shoes", Value = "Shoes" });
            categoryList.Add(new SelectListItem { Text = "Mobiles", Value = "Mobiles" });
            categoryList.Add(new SelectListItem { Text = "Bags", Value = "Bags" });
            ViewBag.Categories = categoryList;
            return PartialView("_Search");
        }
        
    }
}
