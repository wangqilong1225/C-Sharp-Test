using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDemo1
{
    public class A
    {
       public A() {
            Console.WriteLine("A实例化了");       
        }
        public virtual void Print() {
            Console.WriteLine("A");
        }
    }
}
