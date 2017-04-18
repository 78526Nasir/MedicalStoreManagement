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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Account account = new Account(txtUserName.Text, txtPassword.Text, txtGender.Text, int.Parse(txtAge.Text));
            string getType = cbUserType.SelectedItem.ToString();

            BusinessAccess.InsertAccountData(account.getName(), account.getPassword(), account.getGender(), account.getAge(), getType);
            MessageBox.Show(this, "Successfully Creating an Account", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUserName.Text = string.Empty;
            txtGender.Text = string.Empty;
            txtAge.Text = string.Empty;
            txtPassword.Text = string.Empty;
            cbUserType.SelectedIndex = 0;

        }

        private void Registration_Load(object sender, EventArgs e)
        {
            cbUserType.SelectedIndex = 0;
        }

        private void lnkLblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loginForm loginForm = new loginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
