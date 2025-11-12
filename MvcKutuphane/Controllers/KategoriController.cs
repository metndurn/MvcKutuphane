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
    public class KategoriController : Controller
    {
		// GET: Kategori
		DbKutuphaneEntities db = new DbKutuphaneEntities();//veritabanı için oluşturuldu ve nesne türettik
		public ActionResult Index(int ktgsayfa = 1)
        {
			//var kategoriler = db.Kategoriler.ToList();
			var kategoriler = db.Kategoriler.ToList().ToPagedList(ktgsayfa, 10);//sayfalama burada var;//Kategoriler tablosundaki tüm verileri listeledik
			return View(kategoriler);
        }
        [HttpGet]
		public ActionResult KategoriEkle()//get işlemi yani sayfa yüklendiğinde bu metot çalışacak
		{
			return View();
		}
		[HttpPost]
		public ActionResult KategoriEkle(Kategoriler kategoriler)//post işlemi yani butona tıklandığında bu metot çalışacak
		{
			db.Kategoriler.Add(kategoriler);//ekleme işlemi
			db.SaveChanges();
			return RedirectToAction("Index");
		}
		public ActionResult KategoriSil(int id)
		{
			var kategori = db.Kategoriler.Find(id);//id ye göre kategoriyi bul
			db.Kategoriler.Remove(kategori);//kategoriyi sil
			db.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}