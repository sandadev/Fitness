using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls.WebParts;

namespace FitnessproWebApp.Areas.Saloon.Controllers
{
    public class StaffController : Controller
    {
        // GET: Saloon/Staff
        public ActionResult StaffMembers()
        {
            return View();
        }

        public ActionResult NewStaff()
        {
            return View();
        }



    }
}