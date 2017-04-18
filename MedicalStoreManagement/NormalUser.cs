using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalStoreManagement
{
    public partial class NormalUser : Form
    {
        string identity;
        public NormalUser()
        {
            InitializeComponent();
        }
        
        public NormalUser(string identity)
        {
            InitializeComponent();
            this.identity = identity;
        }
        private void NormalUser_Load(object sender, EventArgs e)
        {
            lblUserName.Text = lblUserName.Text + " "+identity;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "This Form Was Under Construction", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            loginForm loginForm = new loginForm();
            loginForm.Show();
            this.Hide();
        }

        private void btnShowProduct_Click(object sender, EventArgs e)
        {
            AvaiableProduct availableProduct = new AvaiableProduct();
            availableProduct.Show();
            this.Hide();
        }
    }
}
