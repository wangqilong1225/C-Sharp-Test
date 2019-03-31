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
            //FunExecuteReader();

            // ExecuteScalar()方法
            //FunExecuteScalar();

            //ExecuteNonQuery()方法
            //FunExecuteNonQuery();
            Product product = new Product();
            product.ProductID = new Guid("AC1245CD-AC12-EF56-1234-ACBD1234ACBD");
            product.Description = "5000";
            SQLFunction(product);
        }

        public static void SQLFunction2(Product product) {
            string sql = "SELECT ProductID,Name,Price,Description FROM [test].[dbo].[Product] WHERE 1=1";
            if (product.ProductID!=null) {
                sql = sql + " AND ProductID='"+ product.ProductID + "'";
            }
            if (product.Description != "") {
                sql = sql + " AND Description like '%" + product.Description + "%'";
            }
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLConnection"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandType = CommandType.Text;            
                cmd.CommandText = sql;
                cmd.Connection = conn;
                conn.Open();
           
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Product pro = new Product();                   
                    pro.Description = reader["Description"].ToString();
                    //...
                }
            }
        }


        public static void SQLFunction(Product product) {
            List<Product> productList = new List<Product>();

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLConnection"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandType = CommandType.StoredProcedure; //默认 Text               0
                cmd.CommandText = "dbo.GetProductList";
                cmd.Connection = conn;
                conn.Open();
                cmd.Parameters.AddWithValue("ProductID", product.ProductID);
                cmd.Parameters.AddWithValue("Price", product.Price);
                cmd.Parameters.AddWithValue("Description", product.Description);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    Product pro = new Product();
                    //pro.ProductID = reader.GetGuid(reader["ProductID"]);
                    pro.Description = reader["Description"].ToString();
                }

               // Console.ReadKey();
            }
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
