using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncDemo
{
    public class Program
    {
        static int i = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("主线程：{0},当前时间：{1}", Thread.CurrentThread.ManagedThreadId, DateTime.Now.ToString("HH:MM:ss"));
            TestAsycAsync();
            i++;
            Console.WriteLine("i="+i);
            Console.WriteLine("主线程结束：{0},当前时间：{1}", Thread.CurrentThread.ManagedThreadId, DateTime.Now.ToString("HH:MM:ss"));

            Console.ReadKey();
        }

        public static async Task TestAsycAsync()
        {
            Console.WriteLine("当前线程是：{0},当前时间：{1}", Thread.CurrentThread.ManagedThreadId, DateTime.Now.ToString("HH:MM:ss"));
            await GetReturnResult();
            Console.WriteLine("i=" + i);
            Console.WriteLine("当前线程是：{0},当前时间：{1}", Thread.CurrentThread.ManagedThreadId, DateTime.Now.ToString("HH:MM:ss"));
        }

        static async Task<int> GetReturnResult()
        {
            Console.WriteLine("当前线程是：{0},当前时间：{1}", Thread.CurrentThread.ManagedThreadId, DateTime.Now.ToString("HH:MM:ss"));
            //异步开始
            int s = await Task.Run(() =>
            {               
                Console.WriteLine("当前线程是：{0},当前时间：{1}", Thread.CurrentThread.ManagedThreadId, DateTime.Now.ToString("HH:MM:ss"));
                Thread.Sleep(3000);  //睡眠3s
                i++;
                return i;
            });
            return s;
        }
    }
}
