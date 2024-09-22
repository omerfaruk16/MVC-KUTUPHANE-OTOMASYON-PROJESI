using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcKutuphane.Models;
using MvcKutuphane.Models.Entity;

namespace MvcKutuphane.Controllers
{
    public class GrafikController : Controller
    {
        // GET: Grafik

        DBKUTUPHANEEntities db = new DBKUTUPHANEEntities(); 
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult VisualizeKitapResult() 
        {
            return Json(liste());
        
        }  


        public List<Class1> liste()
        {
            List<Class1> cs = new List<Class1>();
            cs.Add(new Class1()
            {
                yayinevi="Altın Kitaplar",
                sayi = 1
            });
            cs.Add(new Class1()
            {
				yayinevi= "Ay Yıldız",
				sayi = 6
			});

			cs.Add(new Class1()
			{
				yayinevi = "Can",
				sayi = 19
			});

			cs.Add(new Class1()
			{
				yayinevi = "Yıldız",
				sayi = 10
			});

			cs.Add(new Class1()
			{
				yayinevi = "Satürn",
				sayi = 3
			});
			cs.Add(new Class1()
			{
				yayinevi = "Mars",
				sayi = 5
			});
			cs.Add(new Class1()
			{
				yayinevi = "Pars",
				sayi = 7
			});
			cs.Add(new Class1()
			{
				yayinevi = "Timaş",
				sayi = 20
			});

			cs.Add(new Class1()
			{
				yayinevi = "Akça",
				sayi = 9
			});

			cs.Add(new Class1()
			{
				yayinevi = "Limon",
				sayi = 2
			});

			cs.Add(new Class1()
			{
				yayinevi = "MARS",
				sayi = 6
			});

			cs.Add(new Class1()
			{
				yayinevi = "Güneş",
				sayi = 6
			});

			cs.Add(new Class1()
			{
				yayinevi = "Neptün",
				sayi = 5
			});


			cs.Add(new Class1()
			{
				yayinevi = "Tarih Yayınevi",
				sayi = 4
			});

			



			return cs;

		}

    }

}