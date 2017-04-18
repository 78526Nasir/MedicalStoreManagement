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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            loginForm loginForm = new loginForm();
            loginForm.Show();
            this.Hide();
        }

        private void btnAvailableProduct_Click(object sender, EventArgs e)
        {
            AvaiableProduct availableProduct = new AvaiableProduct();
            availableProduct.Show();
            this.Hide();
        }

        
        private void btnAvailableCustomer_Click(object sender, EventArgs e)
        {
            AvailableCustomer availableCustomer = new AvailableCustomer();
            availableCustomer.Show();
            this.Hide();

        }

        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            AddNewProduct addNewProduct = new AddNewProduct();
            addNewProduct.Show();
            this.Hide();

        }
    }
}
