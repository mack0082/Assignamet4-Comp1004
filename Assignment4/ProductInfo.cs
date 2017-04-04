// App name	           : Dollar Computers
// Author's name       : Mayank Bhardwaj
// Student ID          : 200305245
// App Creation Date   : 3/13/2017
// App description     : The app will allow users to select a laptop they want to buy and 
//                       gives the user all the specifications and total price. 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    public partial class ProductInfo : Form
    {
        public ProductInfo()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectForm Product = new SelectForm();
            Product.Show();

        }

        private void next_Click(object sender, EventArgs e)
        {
            this.Hide();
            Order Product = new Order();
            Product.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
