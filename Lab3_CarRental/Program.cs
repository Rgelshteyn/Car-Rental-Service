using CIS3309Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_CarRental
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            
            CarInventory inventory = new CarInventory();
            inventory.LoadInventoryFromFile("Car_Inventory.txt");
            frmCar carForm = new frmCar();
            Application.Run(carForm);

        }
    }
}
