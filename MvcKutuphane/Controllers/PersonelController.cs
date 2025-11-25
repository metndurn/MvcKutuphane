using MvcKutuphane.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcKutuphane.Controllers
{
    public class PersonelController : Controller
    {
		// GET: Personel
		DbKutuphaneEntities db = new DbKutuphaneEntities();
		public ActionResult Index()
        {
            var personeller = db.Personeller.ToList();
			return View(personeller);
        }
    }
}