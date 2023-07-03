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
    public partial class frmReceipt : Form
    {
        private Transaction rental;
        public frmReceipt(Transaction rental)
        {
            InitializeComponent();
            this.rental = rental;

        }

        private void frmReceipt_Load(object sender, EventArgs e)
        {
            rtbReceipt.Text = rental.PrintReceipt();
            
        }
       
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
