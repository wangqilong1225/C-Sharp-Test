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

            //添加Action Result全局过滤器
            filters.Add(new MyActionFilterAttribute() { Name= "全局Action Result过滤器" });

            //添加Exception全局过滤器
            //filters.Add(new MyExceptionFilterAttribute(){ Name= "全局Exception过滤器" });

            //添加Authorization全局过滤器
            //filters.Add(new MyAuthorizationFilterAttribute(){ Name= "全局Authorization过滤器" });
        }
    }
}
