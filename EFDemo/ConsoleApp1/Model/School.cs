using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    public class School
    {
        public int ID { get; set; }
        public string SchoolName { get; set; }
        public virtual IList<Class> Classes { get;set;}
    }
}
