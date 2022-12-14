using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Railway.Models;
using Railway.Models.DAL;

namespace Railway.Controllers
{

    public class HomeController : Controller
    {


        private IRepository<Reservation> interfaceObj;
        public HomeController()
        {
            this.interfaceObj = new Repository<Reservation>();

        }
        [HttpGet]
        public ActionResult Index()
        {
            var data = interfaceObj.GetModel();
            return View(data);
        }
        

        [HttpPost]
        public ActionResult Index(Reservation res)

        {
            if (ModelState.IsValid)
            {
                interfaceObj.InsertModel(res);
                interfaceObj.Save();
                return RedirectToAction("Index");
            }

            return View(res);
           
        }


    }
}