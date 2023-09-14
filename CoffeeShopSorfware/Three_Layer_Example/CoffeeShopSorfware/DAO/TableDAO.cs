using CoffeeShopSorfware.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopSorfware.DAO
{
    internal class TableDAO
    {
        private static TableDAO instance;
        public static TableDAO Instance
        {
            get {
                if(instance == null)
                {
                    instance = new TableDAO();
                }
                return instance; 
            }
            set { instance = value; }
        }

        private TableDAO() { }

        public List<Table> loadTableList()
        {
            List<Table> listTables = new List<Table>();
            string query = "select * from Account;";
            DataTable data = DBContext.Instance.executeQuery(query);
            
            foreach(DataRow item in data.Rows)
            {
                Table table = new Table(item);
                listTables.Add(table);
            }
            return listTables;
        }
    }
}
