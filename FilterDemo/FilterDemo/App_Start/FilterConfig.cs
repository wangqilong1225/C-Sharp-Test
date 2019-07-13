using FilterDemo.Models;
using System.Web;
using System.Web.Mvc;

namespace FilterDemo
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());

            //添加全局过滤器
            filters.Add(new MyActionFilterAttribute() { Name="全局过滤器"});
        }
    }
}
