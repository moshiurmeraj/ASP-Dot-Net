using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartialViewPassingModel.Models;

namespace PartialViewPassingModel.Controllers
{
    public class ProductController: Controller
    {
        private ProductContext db = new ProductContext();

        public ActionResult Index()

        {
            return View(db.Products.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Product product)
        {
                db.Products.Add(product);
                db.SaveChanges();
                return View(product);
        }
    }
}