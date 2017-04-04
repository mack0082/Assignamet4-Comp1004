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
    public partial class StartForm : Form
    {
        public Form previousForm;
        public StartForm()
        {
            InitializeComponent();
        }

        private void startOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectForm Select = new SelectForm();
            Select.Show();
        }

        private void savedOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductInfo Product = new ProductInfo();
            Product.Show();
            
        }

        private void exit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }
    }
}
