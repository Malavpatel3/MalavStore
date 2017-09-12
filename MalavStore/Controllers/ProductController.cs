using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MalavStore.Controllers
{
    public class ProductController : Controller
    {
        Models.MalavStoreDBEntities db = new Models.MalavStoreDBEntities();

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            } 
            base.Dispose(disposing);
        }
        // GET: Product
        public ActionResult Index(int id)
        {
            var product = db.Products.Find(id);
            return View(product);
        }
    }
}