using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    public class Student
    {
        public int ID { get; set; }
        public string StudentName { get; set; }
        public int? Age { get; set; }
        public int? ClassID { get; set; }
        public virtual Class Class { get; set; }
    }
}
