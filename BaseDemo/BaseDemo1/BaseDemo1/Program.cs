using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDemo1
{
    class Program
    {
        public static void Main(string[] args)
        {
            B b = new B();
            C c = new C();
            b.Print();
            c.Print();

            A b1 = new B();
            A c1 = new C();
            //b1.Print();
            //c1.Print();
            Console.ReadKey();

        }
    }
}
