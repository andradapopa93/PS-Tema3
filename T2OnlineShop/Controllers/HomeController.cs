using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using T2OnlineShop.Models;

namespace T2OnlineShop.Controllers
{
    public class HomeController : Controller
    {

        OnlineStoreEntities storeDB = new OnlineStoreEntities();

        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View();
        }

    }
}
