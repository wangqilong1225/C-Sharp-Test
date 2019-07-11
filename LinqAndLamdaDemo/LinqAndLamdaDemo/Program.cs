using LinqAndLamdaDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndLamdaDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<People> peoples = new List<People>();
            peoples = GetData();

            //查询全部
            var queryAll = from p in peoples
                           select p;

            var queryAll2 = peoples.Select(p => p);

            //条件查找全部
            var query = from p in peoples
                        where p.ID > 3
                        select new PeopleTemp
                        {
                            Name = p.Name,
                            Age = p.Age,
                            Address = p.Address
                        };

            //PrintPeopleTempList(query.ToList());

            var query2 = peoples.Where(p => p.ID > 2).Select(p => new PeopleTemp
            {
                Name = p.Name,
                Age = p.Age,
                Address = p.Address
            });
            //PrintPeopleTempList(query2.ToList());

            People p00 = peoples.First(p => p.ID > 1);          // 取 ID=2 的数据
            People p01 = peoples.First(p => p.ID > 6);          // 异常
            People p02 = peoples.FirstOrDefault(p => p.ID > 1); // 取 ID=2 的数据
            People p03 = peoples.FirstOrDefault(p => p.ID > 6); // null


       
            People p10 = peoples.Single(p => p.ID > 5);         // 取 ID=6 的数据 ,此时搜索结果中只有1条数据
            People p11 = peoples.Single(p => p.ID > 1);         // 异常 ,此时搜索结果中有5条数据
            People p12 = peoples.SingleOrDefault(p => p.ID > 5);// 取 ID=6 的数据 ,此时搜索结果中只有1条数据
            People p13 = peoples.SingleOrDefault(p => p.ID > 1);// null ,此时搜索结果中有5条数据


            People p20 = peoples.Last(p => p.ID > 1);           // 取 ID=6 的数据
            People p21 = peoples.Last(p => p.ID > 6);           // 异常 ,此时搜索结果无数据
            People p22 = peoples.LastOrDefault(p => p.ID > 1);  // 取 ID=6 的数据
            People p23 = peoples.LastOrDefault(p => p.ID > 6);  // null ,此时搜索结果无数据
        }


        //Insert Data
        public static List<People> GetData()
        {
            List<People> peoples = new List<People>();
            peoples.Add(new People
            {
                ID = 1,
                Name = "zs",
                Age = 20,
                Address = "上海"
            });
            peoples.Add(new People
            {
                ID = 2,
                Name = "xm",
                Age = 25,
                Address = "苏州"
            });
            peoples.Add(new People
            {
                ID = 3,
                Name = "ls",
                Age = 23,
                Address = "无锡"
            });
            peoples.Add(new People
            {
                ID = 4,
                Name = "wt",
                Age = 28,
                Address = "南京"
            });
            peoples.Add(new People
            {
                ID = 5,
                Name = "ll",
                Age = 26,
                Address = "镇江"
            });
            peoples.Add(new People
            {
                ID = 6,
                Name = "ql",
                Age = 30,
                Address = "合肥"
            });

            return peoples;
        }

        //Print People List
        public static void PrintPeopleList(List<People> peoples)
        {
            foreach (People p in peoples)
            {
                Console.WriteLine(p.ToString());
            }
            Console.ReadKey();
        }

        //Print PeopleTemp List
        public static void PrintPeopleTempList(List<PeopleTemp> peopleTemps)
        {
            foreach (PeopleTemp p in peopleTemps)
            {
                Console.WriteLine(p.ToString());
            }
            Console.ReadKey();
        }


        // First 默认取第一个数据，如果没有数据会产生异常
        // FirstOrDefault 默认取第一个数据，如果没有数据则为null
        // Last 默认取最后一个数据，如果没有数据会产生异常
        // LastOrDefault 默认取最后一个数据，如果没有数据则为null
        // Single 只取一个数据，若集合中包含多个或者没有数据，抛异常
        // SingleOrDefault  只取一个数据，若集合中包含多个数据，抛异常；若没有数据则为null
    }
}
