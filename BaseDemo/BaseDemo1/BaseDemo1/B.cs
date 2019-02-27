using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDemo1
{
    public class B : A
    {
        public int numB2 = 4;
        static int numB = 2;

        public B() {
            Console.WriteLine("B 非静态构造函数实例化了");
        }

        static B() {
            Console.WriteLine("B 静态构造函数实例化了");
        }
        public virtual void Print() {
            Console.WriteLine("B");
        }
    }
}
