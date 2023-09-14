using AutomobileLibrary.BussinessObject;
using AutomobileLibrary.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomobileWinApp
{
    public partial class frmCarDetails : Form
    {
        public frmCarDetails()
        {
            InitializeComponent();
        }
        
        // Declare some of attributes
        public ICarRepository CarRepository { get; set; }
        public bool InsertOrUpdate { get; set; } 
        public Car CarInfo { get; set; }

        // For load list of cars.
        private void frmCarDetails_Load(object sender, EventArgs e)
        {
            cboManufacture.SelectedIndex = 0;
            txtCarID.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate == true) 
            {
                txtCarID.Text = CarInfo.CarID.ToString();
                txtCarName.Text = CarInfo.CarName;
                txtPrice.Text = CarInfo.Price.ToString();
                txtReleaseYear.Text = CarInfo.ReleaseYear.ToString();
                cboManufacture.Text = CarInfo.Manufacture.Trim();
            }
        }

        // Save when add new car.
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var car = new Car
                {
                    CarID = int.Parse(txtCarID.Text),
                    CarName = txtCarName.Text,
                    Manufacture = cboManufacture.Text,
                    Price = decimal.Parse(txtPrice.Text),
                    ReleaseYear = int.Parse(txtReleaseYear.Text)
                };
                if (InsertOrUpdate == false)  
                {
                    CarRepository.InsertCar(car);
                }
                else
                {
                    CarRepository.UpdateCar(car);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Do you want to add a new car" : "Do you want to add update a car");

            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

        private void txtPrice_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void lbManufacture_Click(object sender, EventArgs e)
        {

        }

        private void lbReleaseYear_Click(object sender, EventArgs e)
        {

        }
    }
}
