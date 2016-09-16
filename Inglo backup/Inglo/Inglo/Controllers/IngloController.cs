using Inglo.Models;
using Inglo.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inglo.Controllers
{
    public class IngloController : Controller
    {
        private Inglodb _db = new Inglodb();


        // GET: Inglo
        //forsíða
        public ActionResult Index()
        {
            return View();
        }

        //vörur
        //get
        public ActionResult Products()
        {
            List<ProductViewModel> items = new List<ProductViewModel>();
            
            foreach(var item in _db.Product)
            {
                ProductViewModel next = new ProductViewModel();

                next.ID = item.ID;
                next.Name = item.Name;
                next.Description = item.Description;
                next.Price = item.Price;

                items.Add(next);
            }

            return View(items);
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Necklece()
        {
            return View();
        }

        public ActionResult SaleSide(int ID)
        {
            ProductViewModel product = new ProductViewModel();

            var item = _db.Product.Where(x => x.ID == ID).SingleOrDefault();

            product.ID = item.ID;
            product.Name = item.Name;
            product.Price = item.Price;
            product.Description = item.Description;

            return View(product);
        }
    }
}