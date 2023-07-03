using CIS3309Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_CarRental
{
    public partial class frmRent : Form
    {
        private Car selectedCar;
        private CarInventory inventory;
        public frmRent(Car selectedCar, CarInventory inventory)
        {
            InitializeComponent();
            this.selectedCar = selectedCar;
            this.inventory = inventory;
           
        }

        private void frmRent_Load(object sender, EventArgs e)
        {
            rtbCarDisplay.Text = $"Category: {selectedCar.Category}\n" +
                              $"Manufacturer: {selectedCar.Manufacturer}\n" +
                              $"Model: {selectedCar.Model}\n" +
                              $"Year: {selectedCar.Year}\n" +
                              $"Mileage: {selectedCar.Mileage}\n" +
                              $"Rental Cost: {selectedCar.RentalCost}\n" +
                              $"Is Available: {(selectedCar.IsAvailable ? "Yes" : "No")}\n" +
                              $"Description: {selectedCar.Description}\n" +
                              $"Location: {selectedCar.Location}\n";

            try
            {
                pbCar.Load(selectedCar.Image);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading car image: {ex.Message}");
            }
        }

        private void rtbCarDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnRentCar_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string phone = txtNumber.Text;
            string license = txtLicence.Text;
            string insurance = txtInsurance.Text;
            DateTime time = dtpTime.Value;
            int rentDays = (int)nupRentDays.Value;

            

            Transaction rental = new Transaction(name, phone, license, insurance, selectedCar, time, rentDays);
            selectedCar.IsAvailable = false;
            inventory.SaveInventoryToFile("Car_Inventory.txt");
            

            frmReceipt frmrecipt = new frmReceipt(rental);
            frmrecipt.ShowDialog();
        }
    }
}
