using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDemo2
{

    class Program
    {

        static void Main(string[] args)
        {
            #if DEBUG
                Console.WriteLine("debug");
            #endif

            #warning abc
            Console.WriteLine("warning");
           
            Console.ReadKey();
        }
    }
}
