using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FitnessproWebApp.Areas.Saloon.Controllers
{
    public class ClientController : Controller
    {
        // GET: Saloon/Client
        [HttpGet]
        public ActionResult List()
        {
            return View();
        }

       // [HttpPost]
        public ActionResult NewClient()
        {
            return View();
        }

       // [HttpPut]
        public ActionResult UpdateClient(int id)
        {
            return View();
        }

        [HttpGet]
        public ActionResult ClientProfile()
        {
            return View();
        }

        [HttpDelete]
        public ActionResult DeleteClient(int id)
        {
            return View();
        }


    }
}