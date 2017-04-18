using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessAccessLayer;

namespace MedicalStoreManagement
{
    public partial class AddNewProduct : Form
    {
        public AddNewProduct()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
            this.Hide();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCompantName.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtProductID.Text = string.Empty;
            txtProductName.Text = string.Empty;
            txtProductType.Text = string.Empty;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product product = new Product(txtProductID.Text,txtProductName.Text,txtProductType.Text,double.Parse(txtPrice.Text),txtCompantName.Text);

            BusinessAccess.InsertProductData(product.getProductID(), product.getProductName(), product.getPrice().ToString(), product.getProductType(), product.getProductCompanyName());
            MessageBox.Show(this, "Successfully Saved Data into Database", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
