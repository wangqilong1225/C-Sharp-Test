using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskDemo1
{
    class Program
    {
        static void Main(string[] args)
        {

            ////实例化的方式启动Task
            //Task task = new Task(()=> {
            //    Console.WriteLine("我是工作线程：tid{0}",Thread.CurrentThread.ManagedThreadId);
            //});
            //task.Start();


            ////TaskFactory的方式启动Task
            //var task = Task.Factory.StartNew(()=> {
            //    Console.WriteLine("我是工作线程：tid{0}", Thread.CurrentThread.ManagedThreadId);
            //});

            //使用Task的Run方法
            //var task = Task.Run(()=> {
            //    Console.WriteLine("我是工作线程：tid{0}", Thread.CurrentThread.ManagedThreadId);
            //});

            //Task<TResult>
            var task = new Task<string>(()=> {
                return "hello world";

            });

            task.Start();
            var msg = task.Result;
            Console.WriteLine(msg);
            Console.Read();
        }
    }
}
