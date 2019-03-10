using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLTestDemo1.Model
{
    public class Student
    {
        public int id;
        public string name;
        public string password;
        public int score;

        public string ToString()
        {
            return "id:"+id+",name:"+name+",password:"+password+",score:"+score;
        }
    }
}
