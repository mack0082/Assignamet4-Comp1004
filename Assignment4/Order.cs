﻿// App name	           : Dollar Computers
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

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductInfo Product = new ProductInfo();
            Product.Show();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your form is been printed", "Print", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
