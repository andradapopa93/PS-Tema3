using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using T2OnlineShop.Models;

namespace T2OnlineShop.Controllers
{
    public class StoreController : Controller
    {

        OnlineStoreEntities storeDB = new OnlineStoreEntities();

        //
        // GET: /Store/
        public ActionResult Index()
        {
            var products = storeDB.Products.GroupBy(p => new { pType = p.type }).Select(q => q.FirstOrDefault()).ToList();
            return View(products);
        }


        //
        // GET: /Store/Browse?product=Disco
        public ActionResult Browse(string type)
        {
            // Retrieve the product from database
            var productModel = storeDB.Products.Where(p => p.type == type).ToList();

            return View(productModel);
        }


        //
        // GET: /Store/Details/5
        public ActionResult Details(int id)
        {
            var album = storeDB.Products.Find(id);

            return View(album);
        }


        //
        // GET: /Store/GenreMenu
        [ChildActionOnly]
        public ActionResult TypeMenu()
        {
            var types = storeDB.Products.GroupBy(p => new { pType = p.type }).Select(q => q.FirstOrDefault()).ToList();
            return PartialView(types);
        }

    }
}
