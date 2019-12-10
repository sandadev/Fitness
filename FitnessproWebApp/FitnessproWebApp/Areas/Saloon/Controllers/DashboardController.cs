using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FitnessproWebApp.Areas.Saloon.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Saloon/Dashboard
        public ActionResult Index()
        {
            return View();
        }
    }
}