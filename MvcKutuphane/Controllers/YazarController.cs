using MvcKutuphane.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;

namespace MvcKutuphane.Controllers
{
    public class YazarController : Controller
    {
		// GET: Yazar
		DbKutuphaneEntities db = new DbKutuphaneEntities();
		public ActionResult Index(int yzrsayfa = 1)
        {
			//var kitaplar = db.Kitaplar.ToList();
			var yazarlar = db.Yazarlar.ToList().ToPagedList(yzrsayfa, 10);
			return View(yazarlar);
		}
		[HttpGet]
		public ActionResult YazarEkle()
		{
			return View();
		}
		[HttpPost]
		public ActionResult YazarEkle(Yazarlar yazarlar)
		{
			db.Yazarlar.Add(yazarlar);
			db.SaveChanges();
			return RedirectToAction("Index");
		}
		public ActionResult YazarSil(int id)
		{
			var yazar = db.Yazarlar.Find(id);
			db.Yazarlar.Remove(yazar);
			db.SaveChanges();
			return RedirectToAction("Index");
		}
		public ActionResult YazarGetir(int id)
		{
			var yazar = db.Yazarlar.Find(id);
			return View("YazarGetir", yazar);
		}
		public ActionResult YazarGuncelle(Yazarlar yazarlar)
		{
			var yazar = db.Yazarlar.Find(yazarlar.Id);
			yazar.Ad = yazarlar.Ad;
			yazar.Soyad = yazarlar.Soyad;
			yazar.Detay = yazarlar.Detay;
			db.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}