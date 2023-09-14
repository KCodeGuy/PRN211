using CoffeeShopSorfware.DAO;
using CoffeeShopSorfware.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopSorfware
{
    public partial class MainLayout : Form
    {
        public MainLayout()
        {
            InitializeComponent();
            loadTables();
        }

        #region Method
        public void loadTables()
        {
            List<Table> list = TableDAO.Instance.loadTableList();
            foreach(Table table in list)
            {
                Button btn = new Button();
                btn.Width =  130;
                btn.Height = 130;
                tableListPanel.Controls.Add(btn);
                btn.Text = table.Name.ToString() + Environment.NewLine + table.Status;
            }
        }
        #endregion

        #region Events
        private void admindToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Admin ad = new Admin();
            this.Hide();
            //ad.ShowDialog();
        }

        private void logouToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void yourProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // AccountInfo ai = new AccountInfo();
           // ai.ShowDialog();
        }

        private void tableListPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        #endregion

        private void MainLayout_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                    }
    }
}
