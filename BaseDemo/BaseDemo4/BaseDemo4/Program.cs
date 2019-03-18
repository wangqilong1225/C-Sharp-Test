using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDemo4
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "今天周一";

            //使用UTF8编码
            Byte[] utf8 =StrToByte(str, Encoding.UTF8);
            System.Text.Encoding.UTF8.GetBytes(str);
            System.Text.Encoding.Default.GetBytes(str);
            
            Console.WriteLine("今天周一,长度是:{0}", utf8.Length);
            foreach (var item in utf8)
            {
                Console.Write(item);
            }
            
            //用utf8编码的字节数组转换为str
            string utf8Str = ByteToStr(utf8, Encoding.UTF8);
            System.Text.Encoding.Default.GetString(utf8);
            System.Text.Encoding.UTF8.GetString(utf8);

            Console.WriteLine("\n\nutf8: {0}", utf8Str);           
            Console.ReadKey();

        }


        //C#通常使用System.Text.Encoding编码

        //字符串转数组
        static Byte[] StrToByte(string str, Encoding encoding)
        {
            return encoding.GetBytes(str);
        }

        //数组转换字符串
        static String ByteToStr(Byte[] bt, Encoding encoding)
        {
            return encoding.GetString(bt);
        }

    }
}
