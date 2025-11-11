using MvcKutuphane.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcKutuphane.Controllers
{
    public class KategoriController : Controller
    {
		// GET: Kategori
		DbKutuphaneEntities db = new DbKutuphaneEntities();//veritabanı için oluşturuldu ve nesne türettik
		public ActionResult Index()
        {
            var kategoriler = db.Kategoriler.ToList();//Kategoriler tablosundaki tüm verileri listeledik
			return View(kategoriler);
        }
    }
}