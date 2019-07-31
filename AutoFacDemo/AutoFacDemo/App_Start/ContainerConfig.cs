using Autofac;
using Autofac.Integration.Mvc;
using AutoFacDemo.Service;
using System.Reflection;
using System.Web.Mvc;

namespace AutoFacDemo.App_Start
{
    public class ContainerConfig
    {
        public static void RegisterContainer()
        {
            // 创建注册组件的builder
            var builder = new ContainerBuilder();

            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            //根据类型注册组件 Calculate 暴漏服务：ICalculate
            builder.RegisterType<Calculate>().As<ICalculate>();

            //构建一个容器完成注册
            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            //https://www.01hai.com/note/av127925
        }
    }
}