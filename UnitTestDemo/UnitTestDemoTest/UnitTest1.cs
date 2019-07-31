using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestDemo.Controllers;

namespace UnitTestDemoTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            System.Diagnostics.Debug.WriteLine("-----单元测试 方法TestMethod1 开始-----");
            HomeController homeController = new HomeController();
            int c = homeController.UnitMethodTest(1,2);
            System.Diagnostics.Debug.WriteLine("测试结果："+c);
            System.Diagnostics.Debug.WriteLine("-----单元测试 方法TestMethod1 结束-----");
        }
    }
}
