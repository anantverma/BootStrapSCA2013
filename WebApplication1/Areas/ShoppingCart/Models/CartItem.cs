using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPAShoppingCartApp.Areas.ShoppingCart.Models
{
    public class CartItem
    {
        public int CartId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public int ProductQuantity { get; set; }
        public string ProductPrice { get; set; }
        public string ProductImageSrc { get; set; }
    }
}