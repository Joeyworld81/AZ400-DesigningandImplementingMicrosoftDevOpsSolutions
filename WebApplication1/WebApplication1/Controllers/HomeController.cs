using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            WebApplication1.GoDoWa goDowa = new WebApplication1.GoDoWa();
            string strTemp = string.Empty;
            strTemp = goDowa.ReturnReturn(new string[] { "저그와 ", "테란" });
            System.Threading.Thread.Sleep(3000);
            ViewData["Message"] = strTemp;
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}