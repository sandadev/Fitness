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
        public ActionResult List()
        {
            return View();
        }

        public ActionResult NewClient()
        {
            return View();
        }
    }
}