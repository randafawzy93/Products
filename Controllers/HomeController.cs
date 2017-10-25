using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Products.Models;
namespace Products.Controllers
{
    public class HomeController : Controller
    {
        MyDBEntities context = new MyDBEntities();
        public ActionResult Index()
        {
            var query = (from p in context.ProudctTask select p);
            return View(query);
        }
        public ActionResult Details(int id)
        {
            ProudctTask query = (from p in context.ProudctTask where p.id == id select p).FirstOrDefault<ProudctTask>();
            return View(query);
        }

        public ActionResult Create()
        {
            ProudctTask p = new ProudctTask();
            return View(p);
        }


        [HttpPost]
        public ActionResult Create(string name, decimal? price, int? amount, DateTime bought_date)
        {
            try
            {
                ProudctTask p = new ProudctTask();

                p.name = name;
                p.price = price;
                p.amount = amount;
                p.bought_date = bought_date;
                context.ProudctTask.Add(p);
                context.SaveChanges();
                return RedirectToAction("Index");
            }


            catch
            {
                return View();
            }


        }



        public ActionResult Edit(int id)
        {
            ProudctTask query = (from p in context.ProudctTask where p.id == id select p).FirstOrDefault<ProudctTask>();

            return View(query);
        }
        [HttpPost]
        public ActionResult Edit(int id, string name, decimal? price, int? amount, DateTime bought_date)
        {
            ProudctTask p = (from prod in context.ProudctTask where prod.id == id select prod).FirstOrDefault<ProudctTask>();
            try
            {


                p.name = name;
                p.price = price;
                p.amount = amount;
                p.bought_date = bought_date;

                context.SaveChanges();
                return RedirectToAction("Index");
            }


            catch
            {
                return View();
            }


        }




        public ActionResult Delete(int id)
        {
            ProudctTask p = (from prod in context.ProudctTask where prod.id == id select prod).FirstOrDefault<ProudctTask>();

            return View(p);
        }



        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {

            try
            {
                ProudctTask p = (from prod in context.ProudctTask where prod.id == id select prod).FirstOrDefault<ProudctTask>();

                context.ProudctTask.Remove(p);
                context.SaveChanges();
                return RedirectToAction("Index");
            }


            catch
            {
                return View();
            }


        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }


        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Visitors()
        {
            

            return View();
        }
  
      



    }
}