using MusicStore.EntityContext;
using MusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicStore.Controllers
{
    public class HomeController : Controller
    {
        HouseHoldApplianceStoreEntities storeDB = new HouseHoldApplianceStoreEntities();
        //
        // GET: /Home/
        public ActionResult Index()
        {
            // Get most popular albums
            /*var products = GetTopSellingProducts(5);
            return View(products);*/
            return View();
        }
        /*public List<Product> GetTopSellingProducts(int count)
        {
            // Group the order details by album and return
            // the albums with the highest count
            return storeDB.Products
                .OrderByDescending(a => a.OrderDetails.Count())
                .Take(count)
                .ToList();
        }*/
	}
}