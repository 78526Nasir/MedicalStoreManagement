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
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void txtUserName_Click(object sender, EventArgs e)
        {

        }

        private void pnlLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int returnValue = BusinessAccess.IsAuthenticateUser(txtUserName.Text, txtPassword.Text);

            if (returnValue== -1)
            {
                MessageBox.Show(this, "Username or Password not matched", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(returnValue==0)
            { 
                MessageBox.Show(this, "You are a Authenticate User", "Confirmation", MessageBoxButtons.OK,MessageBoxIcon.Information);
                AdminForm adminForm = new AdminForm();
                adminForm.Show();
                this.Hide();
            }
            else if(returnValue==1)
            {
                MessageBox.Show(this, "You are a Authenticate User", "Confirmation", MessageBoxButtons.OK,MessageBoxIcon.Information);
                NormalUser normalUser = new NormalUser(txtUserName.Text);

                normalUser.Show();
                this.Hide();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration r = new Registration();
            r.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtUserName.Text = String.Empty;
            txtPassword.Text = String.Empty;
        }
        
    }
}
