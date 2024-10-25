using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Proje1
{
    internal class Order
    {
        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        public int EmployedID { get; set; }
        public DateTime OrderDate { get; set; }
        public Customer customer { get; set; }

        //siparişleri çeken metot
        public List<Order> GetOrder()
        {
            List<Order> orders = new List<Order>();
            //sql den almak istediğim veri nedir?sql e gidiyoruz
            string sqlSorgu =
                @"select o.CustomerID,o.EmployeeID, o.OrderID, o.OrderDate,
                (select ContactName from Customers where CustomerID = o.CustomerID) 
                as ContactName
                from Orders o";
            DataTable dt = GetDataTable(sqlSorgu);
            foreach (DataRow item in dt.Rows)
            {
                //getDataTable kısmı
                Order o = new Order();
                o.OrderID = (int)item["OrderID"];
                o.CustomerID = (string)item["CustomerID"];
               // o.EmployedID = (int)item["EmployedID"];
                o.OrderDate = (DateTime)item["OrderDate"];
                o.customer = new Customer();
                o.customer.ContactName = item["ContactName"].ToString();
                o.customer.CustomerID = (string)item["CustomerID"];
                orders.Add(o);
            }
            return orders;
        }

        private DataTable GetDataTable(string sqlSorgu)
        {
            string cs = "Server=DESKTOP-CU1M14V\\SQLKODLAB;Database=sqlexample1;Trusted_Connection=True";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlSorgu, cs);
            DataTable dt = new DataTable();
            //bu verilerin içini dolduracağız tabloyu
            int v = sqlDataAdapter.Fill(dt);
            return dt;
        }
    }
    class Customer
    {
        public string CustomerID { get; set; }
        public string ContactName { get; set; }
        public List<Order>Orders { get; set; }
        public int OrderCount 
        {
            get { return Orders.Count; } 
        }
    }

}
