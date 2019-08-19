using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendMethodDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string str = "";
            string result = str.ReturnString();

            Blog blog = new Blog();
            string blogName = blog.AddBlogName("小龙人");

            List<int> list = new List<int> { 3, 7, 2, 1, 8, 15, 99 };
            List<int> newList = list.MyWhere(a => a > 5);
        }
    }
}
