using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SQLTestDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["foundation"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "";
                cmd.Connection = conn;
                conn.Open();

                //SqlParameter para = new SqlParameter()
                //{
                //    ParameterName = "PurchaseOrderNumber",
                //    DbType = DbType.String,
                //    Value = PurchaseOrderNo
                //};
                //cmd.Parameters.Add(para);

                //SqlDataReader reader = cmd.ExecuteReader();
                //if (reader.Read())
                //{
                //    purchaseOrder.VendorID = Convert.ToInt32(reader["VendorID"]);
                //    purchaseOrder.VendorName = reader["VendorName"].ToString();
                //    purchaseOrder.ProfileID = Convert.ToInt32(reader["ProfileID"]);
                //    purchaseOrder.PurchaseOrderID = Convert.ToInt32(reader["PurchaseOrderID"]);
                //    purchaseOrder.PurchaseOrderNumber = reader["PurchaseOrderNumber"].ToString();
                //    purchaseOrder.OrderDate = Convert.ToDateTime(reader["OrderDate"]);
                //    purchaseOrder.IsStockRotation = Convert.ToBoolean(reader["IsStockRotation"]);
                //    purchaseOrder.Status = reader["Status"].ToString();
                //    purchaseOrder.ContactPMBeforeRec = reader["ContactPMBeforeRec"].ToString();
                //}
            }
        }
    }
}
