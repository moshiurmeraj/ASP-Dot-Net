using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartialViewPassingModel.Models;

namespace PartialViewPassingModel.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            Product product1 = new Product() { Name = "Pizza", Price = 1000 };
            Product product2 = new Product() { Name = "Burger", Price = 250 };
            Product product3 = new Product() { Name = "Fried Rice", Price = 300 };

            List<Product> productList = new List<Product>() { product1, product2, product3 };
            return View(productList);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
