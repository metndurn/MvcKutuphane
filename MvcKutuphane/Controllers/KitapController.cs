using MvcKutuphane.Models.Entity;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcKutuphane.Controllers
{
    public class KitapController : Controller
    {
		// GET: Kitap
		DbKutuphaneEntities db = new DbKutuphaneEntities();
		public ActionResult Index(int ktpsayfa = 1)
        {
			//var kitaplar = db.Kitaplar.ToList();
			var kitaplar = db.Kitaplar.ToList().ToPagedList(ktpsayfa, 10);
			return View(kitaplar);
        }
		[HttpGet]/*bu sefer ıcınde degerler olmasını ıstıyoruz o sekılde gelecek*/
		public ActionResult KitapEkle()
		{
			/*liste halinde verileri cektik from ile nereden alacagını soyledık ve listeledik
			 select new ile ogeleri listeledik istenenleri ise asagıda verdık*/
			List<SelectListItem> kitap = (from i in db.Kategoriler.ToList()
										select new SelectListItem
										{
											Text = i.Ad,
											Value = i.Id.ToString()
										}).ToList();
			ViewBag.kitapdegeri = kitap;//viewbag ıle gonderdık yani view ıcınde kullanabılırız

			List<SelectListItem> yazar = (from i in db.Yazarlar.ToList()
										  select new SelectListItem
										  {
											  Text = i.Ad + ' ' + i.Soyad,
											  Value = i.Id.ToString()
										  }).ToList();
			ViewBag.yazardegeri = yazar;//viewbag ıle gonderdık yani view ıcınde kullanabılırız

			return View();
		}
		[HttpPost]
		public ActionResult KitapEkle(Kitaplar kitaplar)
		{
			//db.Kitaplar.Add(kitaplar);
			//db.SaveChanges();
			//return RedirectToAction("Index");
			return View();
		}
	}
}