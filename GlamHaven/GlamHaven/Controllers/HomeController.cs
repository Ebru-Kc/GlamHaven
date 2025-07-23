using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GlamHaven.Controllers;
using GlamHaven.Models.entity;

namespace GlamHaven.Controllers
{

    public class HomeController : Controller
    {
        private readonly GlamHavenDbEntities3 db = new GlamHavenDbEntities3();
        public ActionResult Index()
        {

            return View();
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
       
        public ActionResult Hakkımızda()
        {

            ViewBag.Message = "Your application description page.";

            return View(db.Hakkimizdas.ToList());
        }
       
        [HttpPost]
       
        public ActionResult Hakkımızda([Bind(Include = "ID,Baslık,Acıklama")] Hakkimizdas HakkimizdasInfo)
        {
            if (ModelState.IsValid)
            {
                db.Hakkimizdas.Add(HakkimizdasInfo);
                db.SaveChanges();
                return RedirectToAction("Hakkimizdas");
            }

            return View(HakkimizdasInfo);

        }
    

       

    }
}