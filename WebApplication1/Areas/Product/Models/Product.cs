using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPAShoppingCartApp.Areas.Product.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public byte[] ProductImage { get; set; }
        public double ProductPrice { get; set; }
        public int CategoryId { get; set; }
    }
}