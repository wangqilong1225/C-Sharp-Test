using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FilterDemo.Models
{
    public class MyActionFilterAttribute: ActionFilterAttribute
    {
        public string Name { get; set; }

        //在Action执行之前先执行此方法
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
            filterContext.HttpContext.Response.Write("OnActionExecuting---" + Name + "<br/>");
        }

        //在Action执行之中执行此方法
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            base.OnActionExecuted(filterContext);
            filterContext.HttpContext.Response.Write("OnActionExecuted---" + Name+"<br/>");
        }

        //在Action执行结果前执行此方法
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            base.OnResultExecuting(filterContext);
            filterContext.HttpContext.Response.Write("OnResultExecuting---" + Name + "<br/>");
        }

        //在Action执行结果后执行此方法
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            base.OnResultExecuted(filterContext);
            filterContext.HttpContext.Response.Write("OnResultExecuted---" + Name + "<br/>");
        }
    }
}