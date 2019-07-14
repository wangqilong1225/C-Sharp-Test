using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FilterDemo.Models
{
    public class MyAuthorizationFilterAttribute :FilterAttribute, IAuthorizationFilter
    {
        public string Name { get; set; }

        public void OnAuthorization(AuthorizationContext filterContext)
        {
            if (!filterContext.HttpContext.User.Identity.IsAuthenticated)
            {
                filterContext.HttpContext.Response.Redirect("/Home/Index");
            }

            filterContext.HttpContext.Response.Write("权限验证处理...");
            throw new NotImplementedException();
        }
    }
}