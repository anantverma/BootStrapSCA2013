using SPAShoppingCartApp.Areas.ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SPAShoppingCartApp.Areas.ShoppingCart.Controllers
{
    public class ShoppingCartController : Controller
    {
        List<CartItem> CartItems;
        private List<CartItem> GetCartItems()
        {
            CartItems = new List<CartItem>();
            //CartItems.Add(new CartItem { CartId = 1, ProductId = 1, ProductCode = "10001", ProductQuantity = 1, ProductImageSrc = "~/Images/accent.png", ProductName = "Product1", ProductPrice = "1000" });
            //CartItems.Add(new CartItem { CartId = 1, ProductId = 2, ProductCode = "10002", ProductQuantity = 1, ProductImageSrc = "~/Images/accent.png", ProductName = "Product2", ProductPrice = "2000" });
            //CartItems.Add(new CartItem { CartId = 1, ProductId = 3, ProductCode = "10003", ProductQuantity = 1, ProductImageSrc = "~/Images/accent.png", ProductName = "Product3", ProductPrice = "3000" });
            //CartItems.Add(new CartItem { CartId = 1, ProductId = 4, ProductCode = "10004", ProductQuantity = 1, ProductImageSrc = "~/Images/accent.png", ProductName = "Product4", ProductPrice = "4000" });
            //CartItems.Add(new CartItem { CartId = 1, ProductId = 5, ProductCode = "10005", ProductQuantity = 1, ProductImageSrc = "~/Images/accent.png", ProductName = "Product5", ProductPrice = "5000" });
            return CartItems;
        }

        private CartItem CheckIfProductExistsInCart(int productId)
        {
            var existingCartItem = (from c in GetCartItemsFromSession()
                          where c.ProductId == productId
                          select c).FirstOrDefault();
            return existingCartItem;
        }

        public ActionResult CartSummary()
        {
            int cartItemsCount = GetCartItemsFromSession().Count;
            return View("CartSummary", cartItemsCount);
        }

        public ActionResult AddProductToCart(int productId, int quantity)
        {
            var ProductToBeAdded = CheckIfProductExistsInCart(productId);
            List<CartItem> OldCartItems = GetCartItemsFromSession();
            if (ProductToBeAdded == null)
            {
                OldCartItems.Add(new CartItem { CartId = 1, ProductId = 1, ProductCode = "10001", ProductQuantity = quantity, ProductImageSrc = "~/Images/accent.png", ProductName = "Product1", ProductPrice = "1000" });
            }
            else
            {
                OldCartItems.Find(c=> c.ProductId == ProductToBeAdded.ProductId).ProductQuantity += quantity;
            }
            Session["Cart"] = OldCartItems;
            return View("Cart", OldCartItems);
        }

        private List<CartItem> GetCartItemsFromSession()
        {
            List<CartItem> OldCartItems;
            if (Session["Cart"] == null)
            {
                GetCartItems();
                Session["Cart"] = CartItems;
            }
            OldCartItems = (List<CartItem>)Session["Cart"];
            return OldCartItems;
        }

        public ActionResult Cart()
        {
            CartItems = GetCartItemsFromSession();
            return View("Cart", CartItems);
        }

        //public ActionResult Delete (int Id)
        //{
        //    return View("Cart", CartItems);
        //}

    }
}
