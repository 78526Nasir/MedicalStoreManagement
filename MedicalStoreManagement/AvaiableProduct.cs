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
    public partial class AvaiableProduct : Form
    {
        public AvaiableProduct()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
            this.Hide();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            dataGidView.DataSource= BusinessAccess.GetAvailableProduct();
            dataGidView.AutoGenerateColumns = true;
            dataGidView.DataMember = "Product".ToString();
            
            
        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            txtSearch.Text = string.Empty;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string takeItemName = txtSearch.Text;
            if (!string.IsNullOrEmpty(takeItemName))
            {
                dataGidView.DataSource = BusinessAccess.SearchItem(takeItemName);
                dataGidView.AutoGenerateColumns = true;
                dataGidView.DataMember = "Product".ToString();
            }
            
        }
    }
}
