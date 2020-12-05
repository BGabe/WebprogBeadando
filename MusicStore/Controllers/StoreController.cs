using MusicStore.EntityContext;
using MusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MusicStore.Controllers
{
    public class StoreController : Controller
    {
        private HouseHoldApplianceStoreEntities storeDB = new HouseHoldApplianceStoreEntities();
        //
        // GET: /Store/
        public ActionResult Index()
        {
            var types = storeDB.Products.Select(p => p.Type).ToList();
            return View(types);
        }
        //
        // GET: /Store/Browse
        public ActionResult Browse(string type)
        {
            // Retrieve Genre and its Associated Albums from database
            List<Product> productsList = storeDB.Products.Where(p => p.Type == type).ToList();
            return View(productsList);
        }
        //
        // GET: /Store/Details
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = storeDB.Products.Find(id);
            return View(product);
        }
        //
        // GET: /Store/GenreMenu
        [ChildActionOnly]
        public ActionResult TypesMenu()
        {
            var types = storeDB.Products.Select(p => p.Type).ToList();
            return PartialView(types);
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                storeDB.Dispose();
            }
            base.Dispose(disposing);
        }
	}
}