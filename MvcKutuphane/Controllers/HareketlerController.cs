using MvcKutuphane.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcKutuphane.Controllers
{
    public class HareketlerController : Controller
    {
		// GET: Hareketler
		DbKutuphaneEntities db = new DbKutuphaneEntities();
		public ActionResult Index()
        {
            var hareketler = db.Hareketler.ToList();
			return View(hareketler);
        }
    }
}