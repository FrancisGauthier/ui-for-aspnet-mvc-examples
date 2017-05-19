using KendoUIMVC5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KendoUIMVC5.Controllers
{
    public class WareHouseController : Controller
    {
        // GET: WareHouse
        public ActionResult Index()
        {
            return View(new[] { new WareHouse("Toto",new[] { new Product(1,"toto",Category.Beverages)})});
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(WareHouse house)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}