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
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductInfo Product = new ProductInfo();
            Product.Show();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartForm Product = new StartForm();
            Product.Show();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Thank you for shopping with us. Your order will be there within 7-11 business days "
                , "Thank You",
MessageBoxButtons.OK) == DialogResult.OK) 
   {
                Application.Exit();
            }
        }
    }
}
