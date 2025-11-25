using MvcKutuphane.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcKutuphane.Controllers
{
    public class UyelerController : Controller
    {
		// GET: Uyeler
		DbKutuphaneEntities db = new DbKutuphaneEntities();
		public ActionResult Index()
        {
            var uyeler = db.Uyeler.ToList();
			return View(uyeler);
        }
    }
}