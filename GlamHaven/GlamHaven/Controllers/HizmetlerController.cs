using GlamHaven.Models.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GlamHaven.Controllers;


namespace GlamHaven.Controllers
{
    public class HizmetlerController : Controller
    {
        // GET: Hizmetler
        private readonly GlamHavenDbEntities3 db = new GlamHavenDbEntities3();
        public ActionResult Index()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }
        public ActionResult Hizmet()
        {
            
            return View(db.Hizmetlers.ToList());
        }
        [HttpPost]

        public ActionResult Hizmet([Bind(Include = "ID,Baslık1,Acıklama1,Baslık2,Acıklama2,Baslık3,Acıklama3")] Hizmetlers HizmetlersInfo)
        {
            if (ModelState.IsValid)
            {
                db.Hizmetlers.Add(HizmetlersInfo);
                db.SaveChanges();
                return View(HizmetlersInfo);
            }
            return View(HizmetlersInfo);
        }
       

        



    }
}