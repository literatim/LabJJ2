using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LabJJ2.Models;

namespace LabJJ2.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Add()
        {
            return View();
        }

        public ActionResult Post(Product model)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Add");
            }

            return RedirectToAction("Add");
        }
    }
}