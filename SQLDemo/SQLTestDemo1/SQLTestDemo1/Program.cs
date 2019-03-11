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
    public class Program
    {
        static void Main(string[] args)
        {

            //ExecuteReader()方法
            FunExecuteReader();

            // ExecuteScalar()方法
            FunExecuteScalar();

            //ExecuteNonQuery()方法
            FunExecuteNonQuery();
        }

        /// <summary>
        /// ExecuteNonQuery()方法
        /// </summary>
        public static void FunExecuteNonQuery()
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLConnection"].ConnectionString))

            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandType = CommandType.Text; //默认 Text               
                cmd.CommandText = "Update Student SET name='王丽' Where id='1004'";
                cmd.Connection = conn;
                conn.Open();

                //对连接执行 Transact-SQL 语句并返回受影响的行数。
                int id = (Int32)cmd.ExecuteNonQuery();

                Console.ReadKey();
            }
        }

        /// <summary>
        /// ExecuteScalar()方法
        /// </summary>
        public static void FunExecuteScalar()
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLConnection"].ConnectionString))

            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandType = CommandType.Text; //默认 Text
                cmd.CommandTimeout = 30;
                cmd.CommandText = "SELECT * FROM Student";
                cmd.Connection = conn;
                conn.Open();

                //查询返回的结果集中的第一行的第一列
                int id = (Int32)cmd.ExecuteScalar();
                
                Console.ReadKey();
            }
        }
        
        /// <summary>
        ///  ExecuteReader()方法
        /// </summary>
        public static void FunExecuteReader()
        {
            List<Student> StuList = new List<Student>();
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLConnection"].ConnectionString))

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
                if (StuList != null)
                {
                    foreach (Student stu in StuList)
                    {
                        Console.WriteLine(stu.ToString());
                    }
                }
                Console.ReadKey();
            }
        }
    }
}
