using Microsoft.VisualStudio.TestTools.UnitTesting;
using FilterDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterDemo.Models.Tests
{
    [TestClass()]
    public class MyExceptionFilterAttributeTests
    {
        [TestMethod()]
        public void OnExceptionTest()
        {
            Assert.Fail();
        }
    }
}