using AutoFacDemo.Service;
using System.Web.Mvc;

namespace AutoFacDemo.Controllers
{
    public class HomeController : Controller
    {
        private ICalculate _calculate;

        public HomeController()
        {
            _calculate = DependencyResolver.Current.GetService<ICalculate>();
        }
       
        public ActionResult Index()
        {
            int c=_calculate.add(1,2);
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