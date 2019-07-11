using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndLamdaDemo.Model
{
    public class PeopleTemp
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        public string ToString()
        {
            return "Name:"+Name+", Age:"+Age+", Address:"+Address;
        }
    }
}
