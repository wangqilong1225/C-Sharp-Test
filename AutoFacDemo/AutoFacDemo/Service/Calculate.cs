using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoFacDemo.Service
{
    public class Calculate : ICalculate
    {
        public int add(int a, int b)
        {
            return a + b;
        }
    }
}