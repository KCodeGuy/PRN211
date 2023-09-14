using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopSorfware.DTO
{
    internal class Table
    {
        private int id;
        private string email;
        private string password;

        public Table(int id, string email, string password)
        {
            this.Id = id;
            this.Email = email;
            this.Password = password;
        }

        public Table(DataRow row)
        {
            this.id = (int)row.RowState;
            this.email = Convert.ToString(row.RowState);
            this.password = Convert.ToString(row.RowState);
        }

        public int Id { get => id; set => id = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
    }
}
