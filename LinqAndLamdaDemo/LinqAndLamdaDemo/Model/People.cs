using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndLamdaDemo.Model
{
    public class People
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        public string ToString()
        {
            return "ID:"+ID+" ,Name:"+Name+" ,Age:"+Age+" ,"+Age+" ,Address:"+Address;
        }
    }
}
