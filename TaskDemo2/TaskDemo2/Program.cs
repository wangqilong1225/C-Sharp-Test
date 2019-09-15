using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Task task1 = new Task(()=> {
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("我是工作线程:{0}",DateTime.Now);
            });

            task1.Start();

            Task task2 = new Task(() => {
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("我是工作线程2:{0}", DateTime.Now);
            });
   
            task2.Start();

            Task.Factory.ContinueWhenAll(new Task[2] { task1, task2 }, (t) =>
            {
                Console.WriteLine("我是主线程:{0}", DateTime.Now);
            });


            //Task.WhenAll(task1, task2);
            //Task.WaitAny(task1, task2);
            //Task.WhenAll(task1, task2).ContinueWith(t=>{
            //    Console.WriteLine("我是主线程:{0}", DateTime.Now);
            //});

            //Thread t = new Thread(()=> {
            //    System.Threading.Thread.Sleep(100);
            //    Console.WriteLine("我是工作线程");
            //});

            //Thread t2 = new Thread(()=> {
            //    System.Threading.Thread.Sleep(100);
            //    Console.WriteLine("我是工作线程2");
            //});

            //t.Start();
            //t2.Start();

            //t.Join();
            //t2.Join();

            //Console.WriteLine("我是主线程:{0}", DateTime.Now);

            Console.Read();
        }
    }
}
