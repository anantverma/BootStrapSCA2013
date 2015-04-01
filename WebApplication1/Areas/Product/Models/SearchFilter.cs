using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPAShoppingCartApp.Areas.Product.Models
{
    public class SearchFilter
    {
        public string FilterText { get; set; }
        public string FilterQueryString { get; set; }
    }
}