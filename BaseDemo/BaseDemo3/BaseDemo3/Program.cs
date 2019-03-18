using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDemo3
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("1", "1111");
            ht.Add("2", "2222");
            ht.Add("3", "3333");
            ht.Add("4", "4444");

            //遍历方法一：遍历哈希表中的键
            foreach (string key in ht.Keys)
            {
                //Console.WriteLine(string.Format("{0}-{1}"), key, ht[key]);
                Console.WriteLine(string.Format("{0}-{1}", key, ht[key]));
            }
            Console.WriteLine("**********************************************************");
            //遍历方法二：遍历哈希表中的值
            foreach (string value in ht.Values)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine("**********************************************************");
            //遍历方法三：遍历哈希表中的键值
            foreach (DictionaryEntry de in ht)
            {
                Console.WriteLine(string.Format("{0}-{1}", de.Key, de.Value));
            }
            Console.WriteLine("**********************************************************");
            //遍历方法四：遍历哈希表中的键值
            IDictionaryEnumerator myEnumerator = ht.GetEnumerator();
            bool flag = myEnumerator.MoveNext();
            while (flag)
            {
                Console.WriteLine(myEnumerator.Key + "-" + myEnumerator.Value);
                //  Console.WriteLine(ht[myEnumerator.Key]);//ht[myEnumerator.Key]== myEnumerator.Value=true;
                flag = myEnumerator.MoveNext();
            }
            Console.Read();

        }
    }
}
