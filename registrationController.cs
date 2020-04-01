using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace air_area.Areas.Customer.Controllers
{
    public class registrationController : Controller
    {
        // GET: Customer/registration
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Reg()
        {
            return View();
        }
    }
}