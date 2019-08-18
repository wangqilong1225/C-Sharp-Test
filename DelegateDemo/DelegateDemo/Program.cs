using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    public class Program
    {
        public delegate int Method(int num);
        public static void Main(string[] args)
        {
            Method m = Add1;
            m += Add2;
            Calculate(m,10);
            Console.ReadKey();
        }

        public static int Add1(int a)
        {
            int b = 10 + a;
            Console.WriteLine("——Add1———");
            return b;

        }

        public static int Add2(int a)
        {
            int b = 10 - a;
            Console.WriteLine("——Add2———");
            return b;

        }

        public static void Calculate(Method ex, int a)
        {
            var result = ex(a);
            Console.WriteLine(result + "\n");
        }
    }
}
