using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace QuartzDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("工作调度开始，当前时间为："+DateTime.Now.ToString());
            
            //1. 调度器工厂
            ISchedulerFactory factory = new StdSchedulerFactory();

            //2. 创建一个调度器
            Task<IScheduler> taskScheduler = factory.GetScheduler();
            IScheduler scheduler = taskScheduler.Result;

            IJobDetail job = JobBuilder.Create<JobDemo>().Build();
            IJobDetail job2 = JobBuilder.Create<JobDemo2>().Build();

            //3、创建一个触发器
            // 开始执行时间 与 结束时间
            DateTimeOffset startTime = DateBuilder.NextGivenSecondDate(DateTime.Now.AddSeconds(1), 2);
            DateTimeOffset endTime = DateBuilder.NextGivenSecondDate(DateTime.Now.AddHours(2), 2);

            //DateTimeOffset startTime = DateBuilder.NextGivenSecondDate(DateTime.Now, 1);
            //DateTimeOffset endTime = DateBuilder.NextGivenSecondDate(DateTime.MaxValue.AddDays(-1), 1);

            //每隔 10s 触发一次
            ICronTrigger trigger = (ICronTrigger)TriggerBuilder.Create().StartAt(startTime).EndAt(endTime)
                                        .WithCronSchedule("0/10 * * * * ?")
                                        .Build();
            //每隔 3s 触发一次，一百次后结束，这里不规定最大触发次数默认为1次
            ISimpleTrigger trigger2 = (ISimpleTrigger)TriggerBuilder.Create().StartAt(startTime).EndAt(endTime)
                                        .WithSimpleSchedule(x => x.WithIntervalInSeconds(3).WithRepeatCount(100))
                                        .Build();
            
            //4、将任务与触发器添加到调度器中           
            scheduler.ScheduleJob(job, trigger);
            scheduler.ScheduleJob(job2, trigger2);

            //5、开始执行
            scheduler.Start();

            Console.ReadKey();
        }

        public class JobDemo : IJob
        {           
            public async Task Execute(IJobExecutionContext context)
            {
                Console.WriteLine(DateTime.Now.ToString()+ " ---Trigger 1---");
            }
        }

        public class JobDemo2 : IJob
        {
            public async Task Execute(IJobExecutionContext context)
            {
                Console.WriteLine(DateTime.Now.ToString() + " ---Trigger 2---");
            }
        }
    }
}