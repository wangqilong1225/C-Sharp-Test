using JSDataTable.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JSDataTable.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<People> list = new List<People>();         
            list.Add(new People
            {
                ID = 9,
                Name = "Tomser",
                Address = "中国广州",
                Description = "我是汤姆逊",
                BirthDay = Convert.ToDateTime("1996/02/18"),
                UpdatedDate = Convert.ToDateTime("2019/01/23")
            });
            list.Add(new People
            {
                ID = 8,
                Name = "Json",
                Address = "中国合肥",
                Description = "我是杰森",
                BirthDay = Convert.ToDateTime("1986/06/20"),
                UpdatedDate = Convert.ToDateTime("2019/03/16")
            });
            list.Add(new People
            {
                ID = 1,
                Name = "Jane",
                Address = "中国上海",
                Description = "我是杰恩",
                BirthDay = Convert.ToDateTime("1994/12/25"),
                UpdatedDate = Convert.ToDateTime("2019/04/03")
            });
            list.Add(new People
            {
                ID = 2,
                Name = "Amy",
                Address = "中国深圳",
                Description = "我是艾米",
                BirthDay = Convert.ToDateTime("1980/03/15"),
                UpdatedDate = Convert.ToDateTime("2018/08/23")
            });
            list.Add(new People
            {
                ID = 3,
                Name = "Alina",
                Address = "中国杭州",
                Description = "我是艾琳",
                BirthDay = Convert.ToDateTime("2010/10/12"),
                UpdatedDate = Convert.ToDateTime("2019/01/15")
            });
            list.Add(new People
            {
                ID = 4,
                Name = "Bear",
                Address = "中国北京",
                Description = "我是贝尔",
                BirthDay = Convert.ToDateTime("1988/04/16"),
                UpdatedDate = Convert.ToDateTime("2019/02/22")
            });
            list.Add(new People
            {
                ID = 5,
                Name = "Jack",
                Address = "中国南京",
                Description = "我是杰克",
                BirthDay = Convert.ToDateTime("1998/09/06"),
                UpdatedDate = Convert.ToDateTime("2019/09/11")
            });
            list.Add(new People
            {
                ID = 6,
                Name = "Meria",
                Address = "中国天津",
                Description = "我是没瑞尔",
                BirthDay = Convert.ToDateTime("2000/08/11"),
                UpdatedDate = Convert.ToDateTime("2018/12/03")
            });
            list.Add(new People
            {
                ID = 7,
                Name = "Tom",
                Address = "中国苏州",
                Description = "我是汤姆",
                BirthDay = Convert.ToDateTime("1998/02/28"),
                UpdatedDate = Convert.ToDateTime("2019/01/01")
            });

            return View("index",list);
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