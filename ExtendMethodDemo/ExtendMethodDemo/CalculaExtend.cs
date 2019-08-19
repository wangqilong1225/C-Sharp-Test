using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendMethodDemo
{
    // 1.必须是定义在静态类中的静态方法；
    // 2.第一个参数的类型是要扩展的类型；
    // 3.第一个参数需要添加this关键字以标识其为扩展方法。
    
    public static class MyString
    {
        public static string ReturnString(this string s)
        {
            return "string类的扩展方法ReturnString";
        } 

        public static string AddBlogName(this Blog blog,string name)
        {
            string ResName =blog.RenName(name)+"的博客";
            return ResName;
        }

        public static List<int> MyWhere(this List<int> list,Func<int,bool> func)
        {
            List<int> newList = new List<int>();
            foreach (int i in list)
            {
                if (func(i))
                {
                    newList.Add(i);
                }
            }
            return newList;
        }

    }
}
