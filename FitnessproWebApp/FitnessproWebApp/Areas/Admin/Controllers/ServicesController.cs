using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FitnessproWebApp.Areas.Admin.Controllers
{
    public class ServicesController : Controller
    {
        // GET: Admin/Services
        public ActionResult Gym()
        {
            return View();
        }

        public ActionResult Saloon()
        {
            return View();
        }

        public ActionResult Spa()
        {
            return View();
        }
        public ActionResult AddGym()
        {
            return View();
        }


        public ActionResult AddSpa()
        {
            return View();
        }

        public ActionResult AddSaloon()
        {
            return View();
        }

    }
}