using EFTestDemo03.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTestDemo03
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var db = new DBModel())
            {
                //var student = (from s in db.Students where s.Name == "ls" select s).First();

                //db.Students.Add(new Student { Name="ls",Age=18});
                //student.ClassID = 2;
                var student = (from s in db.Students where s.ID ==3  select s).First();

                db.Students.Remove(student);

                db.SaveChanges();
                Console.WriteLine(student.s());
                Console.ReadKey();
            }
        }
    }
}
