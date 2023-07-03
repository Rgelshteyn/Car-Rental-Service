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
    public partial class frmInventory : Form
    {
        private CarInventory inventory;

        

        public frmInventory()
        {
            InitializeComponent();
            inventory = new CarInventory();
            inventory.LoadInventoryFromFile("Car_Inventory.txt");
            UpdateListView();
           
        }
        private void UpdateListView(string category = "")
        {
            lvInventory.Items.Clear();
            foreach (Car car in inventory.GetCars())
            {
                if (string.IsNullOrEmpty(category) || car.Category.Contains(category))
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        car.Category,
                        car.Manufacturer,
                        car.Model,
                        car.Year.ToString(),
                        car.Mileage.ToString(),
                        car.RentalCost.ToString(),
                        car.IsAvailable ? "Yes" : "No",
                        car.Description,
                        car.Location,
                        car.Image
                    });

                    item.Tag = car;
                    lvInventory.Items.Add(item);
                }
            }
        }

        private void lvInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

            if (lvInventory.SelectedItems.Count > 0)
            {
                Car selectedCar = (Car)lvInventory.SelectedItems[0].Tag;
                inventory.RemoveCar(selectedCar);
                inventory.SaveInventoryToFile("Car_Inventory.txt");
                UpdateListView();
            }
            else
            {
                MessageBox.Show("Please select a car to delete.");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            if (lvInventory.SelectedItems.Count > 0)
            {
                Car selectedCar = (Car)lvInventory.SelectedItems[0].Tag;


                if (selectedCar.IsAvailable)
                {
                    
                    frmRent frmrent = new frmRent(selectedCar, inventory);  
                    frmrent.ShowDialog();
                    this.Close();
                    
                }
                else
                {
                    MessageBox.Show("Already Rented");
                }

            }
            else
            {
                MessageBox.Show("Please select a car to rent.");
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string category = txtSearch.Text;
            UpdateListView(category);

        }

        private void frmInventory_Load(object sender, EventArgs e)
        {

        }
    }
}
