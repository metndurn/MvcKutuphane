using MvcKutuphane.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcKutuphane.Controllers
{
    public class KasaController : Controller
    {
		// GET: Kasa
		DbKutuphaneEntities db = new DbKutuphaneEntities();
		public ActionResult Index()
        {
            var kasa = db.Kasa.ToList();
			return View(kasa);
        }
    }
}