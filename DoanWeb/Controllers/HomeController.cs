using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoanWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Bac()
        {
            ViewBag.Message = "Tin tuc mien Bac";

            return View();
        }

        public ActionResult Nam()
        {
            ViewBag.Message = "Tin tuc mien Nam";

            return View();
        }
        public ActionResult Account()
        {
            ViewBag.Message = "Tai khoan";

            return View();
        }
    }
}