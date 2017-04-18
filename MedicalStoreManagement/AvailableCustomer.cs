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
    public partial class AvailableCustomer : Form
    {
        public AvailableCustomer()
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
            dgvAvailableCustomer.DataSource= BusinessAccess.GetAvailableCustomer();
            dgvAvailableCustomer.AutoGenerateColumns = true;
            dgvAvailableCustomer.DataMember = "Account".ToString();
        }
    }
}
