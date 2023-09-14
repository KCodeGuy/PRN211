using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.IO;

namespace DataAccess
{
    public class BaseDAL
    {
        public SalesDataProvier dataProvider { get; set; } = null;
        public SqlConnection connection = null;
        
        public BaseDAL()
        {
            var connectionString = GetConnectionString();
            dataProvider = new SalesDataProvier(connectionString);
        }
        public string GetConnectionString()
        {
            return "Data Source=LAPTOP-F7OGOM4I\\SQLEXPRESS01;Initial Catalog=MyFStore;Integrated Security=True";
        }

        public void CloseConnection()=>dataProvider.CloseConnection(connection);
    }
}
