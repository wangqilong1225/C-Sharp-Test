using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDemo1
{
    public class A
    {
       public int numA2 = 3;

       static int numA=1;

       public A() {
            Console.WriteLine("A 非静态构造函数实例化了");
        }
        static A() {
            Console.WriteLine("A 静态构造函数实例化了");
        }
        public virtual void Print() {
            Console.WriteLine("A");
        }
    }
}
