using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Data;
using SQLTestDemo1.Model;

namespace SQLTestDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> StuList = new List<Student>();
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLConnection"].ConnectionString))
            //string connString = "Server=.;Database=test;UID=sa;PWD=123456;";
            //SqlConnection conn = new SqlConnection();
            //conn.ConnectionString = connString;
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandType = CommandType.Text; //默认 Text
                cmd.CommandTimeout = 30;
                cmd.CommandText = "SELECT * FROM Student";
                cmd.Connection = conn;
                conn.Open();
                
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Student stu = new Student();
                    stu.id = Convert.ToInt32(reader["id"]);
                    stu.name = reader["name"].ToString();
                    stu.password = reader["password"].ToString();
                    stu.score = Convert.ToInt32(reader["score"]);
                    StuList.Add(stu);
                }
                if (StuList!=null)
                {              
                    foreach (Student stu in StuList) {
                        Console.WriteLine(stu.ToString());
                    }
                }
                Console.ReadKey();
            }
        }
    }
}
