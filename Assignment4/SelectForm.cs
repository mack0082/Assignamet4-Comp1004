using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    public partial class SelectForm : Form
    {
        ProductsContent ProductsDB = new ProductsContent();



        public SelectForm()
        {
            InitializeComponent();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'comp1004DataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.comp1004DataSet.products);

            try
            {
                /// selects all the prodcuts from the Products DB
                var ProductsList = (from product in ProductsDB.products
                                    select product).ToList();

                productsGridView.DataSource = ProductsList;

            }
            catch (Exception exception)
            {

                Debug.WriteLine(exception.Message);
            }

        }

        private void productsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

         }
        private void productsGridView_SelectionChanged(object sender, EventArgs e)
        {
            int rowindex = productsGridView.CurrentRow.Index;
            int currentId = (int)productsGridView.Rows[rowindex].Cells[0].Value;

            try
            {
                var SelectedName = (from product in ProductsDB.products
                                    where product.productID == currentId
                                    select product).FirstOrDefault();



            }
            catch (Exception exception)
            {

                Debug.WriteLine(exception.Message);
            }
        }
    }
}
