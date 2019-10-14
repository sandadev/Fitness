using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FitnessproWebApp.Areas.Admin.Controllers
{
    public class EntityController : Controller
    {
        // GET: Admin/Entity
        public ActionResult List()
        {
            return View();
        }

        public ActionResult CreateEntity()
        {
            return View();
        }
    }
}