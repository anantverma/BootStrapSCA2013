using SPAShoppingCartApp.Areas.Product.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SPAShoppingCartApp.Areas.Product.Controllers
{
    public class FilterController : Controller
    {
        List<SearchFilter> Filters;

        private void GetPriceFilter()
        {
            Filters = new List<SearchFilter>();
            Filters.Add(new SearchFilter { FilterText = string.Format("0 - 1000 {0}", "(0)"), FilterQueryString = "minLimit=0&maxLimit=1000&"});
            Filters.Add(new SearchFilter { FilterText = string.Format("1001 - 5000 {0}", "(0)"), FilterQueryString = "minLimit=1001&maxLimit=5000&"});
            Filters.Add(new SearchFilter { FilterText = string.Format("5001 - 10000 {0}", "(0)"), FilterQueryString = "minLimit=5001&maxLimit=10000&"});
            Filters.Add(new SearchFilter { FilterText = string.Format("10001 - 15000 {0}", "(0)"), FilterQueryString = "minLimit=10001&maxLimit=15000&"});
            Filters.Add(new SearchFilter { FilterText = string.Format("15001 - 20000 {0}", "(0)"), FilterQueryString = "minLimit=15001&maxLimit=20000&" });
            Filters.Add(new SearchFilter { FilterText = string.Format("15001 - 20000 {0}", "(0)"), FilterQueryString = "minLimit=15001&maxLimit=20000&" });
        }

        private void GetBrandFilter()
        {
            Filters = new List<SearchFilter>();
            Filters.Add(new SearchFilter { FilterText = string.Format("Liberty {0}", "(0)"), FilterQueryString = "brand=liberty&" });
            Filters.Add(new SearchFilter { FilterText = string.Format("Bata {0}", "(0)"), FilterQueryString = "brand=bata&" });
            Filters.Add(new SearchFilter { FilterText = string.Format("Reebok {0}", "(0)"), FilterQueryString = "brand=reebok&" });
            Filters.Add(new SearchFilter { FilterText = string.Format("Adidas {0}", "(0)"), FilterQueryString = "brand=adidas&" });
            Filters.Add(new SearchFilter { FilterText = string.Format("Nike {0}", "(0)"), FilterQueryString = "brand=nike&" });
        }

        private void GetSizeFilter()
        {
            Filters = new List<SearchFilter>();
            Filters.Add(new SearchFilter { FilterText = string.Format("4 {0}", "(0)"), FilterQueryString = "size=4&" });
            Filters.Add(new SearchFilter { FilterText = string.Format("5 {0}", "(0)"), FilterQueryString = "size=5&" });
            Filters.Add(new SearchFilter { FilterText = string.Format("6 {0}", "(0)"), FilterQueryString = "size=6&" });
            Filters.Add(new SearchFilter { FilterText = string.Format("7 {0}", "(0)"), FilterQueryString = "size=7&" });
            Filters.Add(new SearchFilter { FilterText = string.Format("8 {0}", "(0)"), FilterQueryString = "size=8&" });
            Filters.Add(new SearchFilter { FilterText = string.Format("9 {0}", "(0)"), FilterQueryString = "size=9&" });
            Filters.Add(new SearchFilter { FilterText = string.Format("10 {0}", "(0)"), FilterQueryString = "size=10&" });
        }

        public ActionResult PriceFilter()
        {
            ViewBag.Title = "Price Range";
            GetPriceFilter();
            return View("Filter", Filters);
        }

        public ActionResult BrandFilter()
        {
            ViewBag.Title = "Brands";
            GetBrandFilter();
            return View("Filter", Filters);
        }

        public ActionResult SizeFilter()
        {
            ViewBag.Title = "Sizes";
            GetSizeFilter();
            return View("Filter", Filters);
        }
    }
}
