using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopSorfware.DAO
{
    public class DBContext
    {
        // create statis to use once time only
        private static DBContext instance; 

        // getter and setter
        public static DBContext Instance
        {
            get { if (instance == null) instance = new DBContext(); return instance; }
            private set { instance = value; }
        }

        // Constructor
        private DBContext() {}

        // string connection
        private string connectionString = "Data Source=LAPTOP-F7OGOM4I\\SQLEXPRESS01;Initial Catalog=QLDH;Integrated Security=True";
        // contains returned data
        DataTable data = new DataTable();
       
        public DataTable executeQuery(string query)
        {
            using (SqlConnection connecttion = new SqlConnection(connectionString))
            {
                connecttion.Open();
                SqlCommand command = new SqlCommand(query, connecttion);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connecttion.Close();
            }
            return data;
        }
    }
}
