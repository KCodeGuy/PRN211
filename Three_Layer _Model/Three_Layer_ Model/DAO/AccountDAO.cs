using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Three_Layer__Model.DAO
{
    internal class AccountDAO
    {
        private static AccountDAO instance;
        public static AccountDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AccountDAO();
                }
                return instance;
            }
            private set { instance = value; }
        }

        private AccountDAO() { }

        public bool login(string username, string password)
        {
            string query = "select * from Account where userName = '" + username + "' and password = '" + password + "'";
            DataTable result = DBContext.Instance.executeQuery(query);
            if (result.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
    }
}
