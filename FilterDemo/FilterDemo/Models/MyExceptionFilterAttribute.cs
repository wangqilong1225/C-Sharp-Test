using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FilterDemo.Models
{
    public class MyExceptionFilterAttribute : FilterAttribute,IExceptionFilter
    {
        public string Name { get; set; }
        public void OnException(ExceptionContext filterContext)
        {
            filterContext.HttpContext.Response.Write("异常发生");
            //throw new NotImplementedException();
        }
    }
}