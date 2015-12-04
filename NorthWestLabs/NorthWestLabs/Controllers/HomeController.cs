using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthWestLabs.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FlotCharts()
        {
            return View("FlotCharts");
        }

        public ActionResult MorrisCharts()
        {
            return View("MorrisCharts");
        }

        public ActionResult Tables()
        {
            return View("Tables");
        }

        public ActionResult Forms()
        {
            return View("Forms");
        }

        public ActionResult Panels()
        {
            return View("Panels");
        }

        public ActionResult Buttons()
        {
            return View("Buttons");
        }

        public ActionResult Notifications()
        {
            return View("Notifications");
        }

        public ActionResult Typography()
        {
            return View("Typography");
        }

        public ActionResult Icons()
        {
            return View("Icons");
        }

        public ActionResult Grid()
        {
            return View("Grid");
        }

        public ActionResult Blank()
        {
            return View("Blank");
        }

        public ActionResult Login()
        {
            return View("Login");
        }

        public ActionResult Reports()
        {
            return View();
        }

        public ActionResult Reports2()
        {
            return View();
        }

        public ActionResult Reports3()
        {
            return View();
        }

        public ActionResult Reports4()
        {
            return View();
        }
        public ActionResult Reports4_5()
        {
            return View();
        }
        public ActionResult Reports5()
        {
            return View();
        }
        public ActionResult Reports6()
        {
            return View();
        }
        public ActionResult customers()
        {
            return View();
        }
        public ActionResult customers2()
        {
            return View();
        }
        public ActionResult customers3()
        {
            return View();
        }
        public ActionResult GenerateQuote()
        {
            return View();
        }
        public ActionResult GenerateQuote2()
        {
            return View();
        }
        public ActionResult GenerateQuote2_5()
        {
            return View();
        }
        public ActionResult GenerateQuote3()
        {
            return View();
        }
        public ActionResult GenerateQuote4()
        {
            return View();
        }
        public ActionResult GenerateQuote5()
        {
            return View();
        }
    }
}