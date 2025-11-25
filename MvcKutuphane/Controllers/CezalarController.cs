using MvcKutuphane.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcKutuphane.Controllers
{
    public class CezalarController : Controller
    {
		// GET: Cezalar
		DbKutuphaneEntities db = new DbKutuphaneEntities();
		public ActionResult Index()
        {
            var cezalar = db.Cezalar.ToList();
			return View(cezalar);
        }
    }
}