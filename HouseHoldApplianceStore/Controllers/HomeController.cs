using HouseHoldApplianceStore.DAL;
using HouseHoldApplianceStore.Models.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HouseHoldApplianceStore.Controllers
{
    public class HomeController : Controller
    {
        dbStoreEntities ctx = new dbStoreEntities();
        public ActionResult Index(string search, int? page)
        {
            HomeIndexViewModel model = new HomeIndexViewModel();
            return View(model.CreateModel(search, 4, page));
        }

        public ActionResult AddToCart(int productId)
        {
            if (Session["cart"] == null)
            {
                List<Item> cart = new List<Item>();
                var product = ctx.Tbl_Product.Find(productId);
                cart.Add(new Item()
                {
                    Product = product,
                    Quantity = 1
                });
                Session["cart"] = cart;
            }
            else
            {
                List<Item> cart = (List<Item>)Session["cart"];
                var product = ctx.Tbl_Product.Find(productId);
                cart.Add(new Item()
                {
                    Product = product,
                    Quantity = 1
                });
                Session["cart"] = cart;
            }
            return Redirect("Index");
        }
        public ActionResult RemoveFromCart(int productId)
        {
            List<Item> cart = (List<Item>)Session["cart"];
            foreach (var item in cart)
            {
                if (item.Product.ProductId == productId)
                {
                    cart.Remove(item);
                    break;
                }
            }
            Session["cart"] = cart;
            return Redirect("Index");
        }

    }
}