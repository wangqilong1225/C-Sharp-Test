using FilterDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FilterDemo.Controllers
{
    [MyActionFilter(Name ="Home 控制器过滤")]   //控制器过滤器
    public class HomeController : Controller
    {

       [MyActionFilter(Name = "Home/Index 方法过滤")]   //方法过滤器
        public ActionResult Index()
        {
            HttpContext.Response.Write("&nbsp;&nbsp;&nbsp;&nbsp;<font color='red'>Action方法执行中</font><br/>");
            return View();
        }

        [MyAuthorizationFilter]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [MyExceptionFilter]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    }
}