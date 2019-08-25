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
        //https://www.cnblogs.com/knowledgesea/p/4930469.html
        static void Main(string[] args)
        {
            
            Console.WriteLine(DateTime.Now.ToString());
            
            //调度器工厂
            ISchedulerFactory factory = new StdSchedulerFactory();

            //创建一个调度器
            Task<IScheduler> taskScheduler = factory.GetScheduler();
            IScheduler scheduler = taskScheduler.Result;

            IJobDetail job = JobBuilder.Create<JobDemo>().Build();
            IJobDetail job2 = JobBuilder.Create<JobDemo2>().Build();

            //3、创建一个触发器
            DateTimeOffset startTime = DateBuilder.NextGivenSecondDate(DateTime.Now.AddSeconds(1), 2);
            DateTimeOffset endTime = DateBuilder.NextGivenSecondDate(DateTime.Now.AddHours(20), 5);

            //DateTimeOffset starRunTime = DateBuilder.NextGivenSecondDate(DateTime.Now, 1);
            //DateTimeOffset endRunTime = DateBuilder.NextGivenSecondDate(DateTime.MaxValue.AddDays(-1), 1);



            ISimpleTrigger trigger2 = (ISimpleTrigger)TriggerBuilder.Create().StartAt(startTime).EndAt(endTime)
                                        .WithSimpleSchedule(x => x.WithIntervalInSeconds(3).WithRepeatCount(100))
                                        .Build();
            ICronTrigger trigger = (ICronTrigger)TriggerBuilder.Create().StartAt(startTime).EndAt(endTime)
                                        .WithCronSchedule("1,10,14 10,20,25,26,35,36,42,43 * * * ? ")
                                        .Build();
            //https://www.cnblogs.com/lihaiming93/p/6619124.html
            //0 0 10,14,16 * * ? 每天上午10点，下午2点，4点整触发

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
                await Task.Delay(1);
                Console.WriteLine(DateTime.Now.ToString()+"---1---");
            }
        }

        public class JobDemo2 : IJob
        {

            public async Task Execute(IJobExecutionContext context)
            {
                await Task.Delay(1);
                Console.WriteLine(DateTime.Now.ToString() + "---2---");
            }
        }
    }
}
