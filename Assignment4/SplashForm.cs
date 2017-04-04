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
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {

        }

        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            // 1. Instantiate the next form
            StartForm startForm = new StartForm();

            // 2. pass a reference to the current form to the next form
            startForm.previousForm = this;

            this.SplashFormTimer.Enabled = false;
            startForm.Show();
            this.Hide();

        }
    }
}
