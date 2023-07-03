using CIS3309Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_CarRental
{
    public partial class frmCar : Form
    {
        private CarInventory inventory;
        public frmCar()
        {
           InitializeComponent();
            inventory = new CarInventory();
            
         
        }

        private void frmCar_Load(object sender, EventArgs e)
        {
           
         
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            frmInventory frminventory = new frmInventory();
            frminventory.ShowDialog();

        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            string cat = ddlCat.SelectedItem.ToString();
            string manu = txtManufactur.Text;
            string model = txtModel.Text;
            int year = (int)nupYear.Value;
            int mileage = (int)nupMileage.Value;
            int cost = (int)nupCPD.Value;
            bool isAvailable = radAvailible.Checked;
            string desc = rtbDescription.Text;
            string loc = txtLocation.Text;
            string img = rtbImageURL.Text;
            


            Car car = new Car(cat, manu, model, year, mileage, cost, isAvailable, desc, loc, img);
            inventory.AddCar(car);
            inventory.SaveInventoryToFile("Car_Inventory.txt");
            

            try
            {
                pbcar.Load(car.Image);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading car image: {ex.Message}");
            }

            MessageBox.Show("Car added successfully!");

        }

        private void nupYear_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pbcar_Click(object sender, EventArgs e)
        {

        }

        private void frmCar_Load_1(object sender, EventArgs e)
        {

        }
    }
}
