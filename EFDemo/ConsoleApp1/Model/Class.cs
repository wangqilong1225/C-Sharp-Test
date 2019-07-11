using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    public class Class
    {
        public int ID { get; set; }
        public string ClassName { get; set; }
        public int SchoolID { get; set; }
        public virtual School School { get; set; }
        public virtual IList<Student> Students { get; set; }
    }
}
