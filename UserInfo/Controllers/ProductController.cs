using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserInfo.CustomFilters;

namespace UserInfo.Controllers
{
    public class ProductController : Controller
    {
        SuperMarketEntities ctx;

        public ProductController()
        {
            ctx = new SuperMarketEntities();
        }

        // GET: Product
        public ActionResult Index()
        {
            var Products = ctx.ProductMaster.ToList();
            return View(Products);
        }

        [AuthLog(Roles ="Admin")]
        public ActionResult Create()
        {
            var Product = new ProductMaster();
            return View(Product);
        }




        [HttpPost]
        [AuthLog(Roles ="Editor")]
        public ActionResult Create(ProductMaster p)
        {
            ctx.ProductMaster.Add(p);
            ctx.SaveChanges();
            return RedirectToAction("Index");
        }

        [AuthLog(Roles = "User")]
        public ActionResult SaleProduct()
        {
            ViewBag.Message = "This View is designed for the Sales Executive to Sale Product.";
            return View();
        }
    }
}