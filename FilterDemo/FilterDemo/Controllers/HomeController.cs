using FilterDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FilterDemo.Controllers
{
    [MyActionFilter(Name ="Home")]   //控制器过滤器
    public class HomeController : Controller
    {

        [MyActionFilter(Name = "Home")]   //方法过滤器
        public ActionResult Index()
        {
            HttpContext.Response.Write("Action方法执行中<br/>");
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