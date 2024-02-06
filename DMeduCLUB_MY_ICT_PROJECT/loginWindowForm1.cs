using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMeduCLUB_MY_ICT_PROJECT
{
    public partial class loginWindowForm1 : Form
    {
        public loginWindowForm1()
        {
            InitializeComponent();
        }

        private void loginWindowForm1_Load(object sender, EventArgs e)
        {
            pnlLog.BackColor=Color.FromArgb(200,0,0,0);
            pnlLog.BorderStyle=BorderStyle.Fixed3D;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void logNext()
        {
            String userName = txtLogUserName.Text;
            String code = txtLogPassword.Text;


            if (userName == "dhanushka" && code == "admin1234"
               || userName == "mahesh" && code == "123456")
            {
                menuWindowForm menuForm = new menuWindowForm();
                menuForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("This Password or User Name is Incorrect", "Alart Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblLogError1.Text = "This is Not Valid";
                lblLogError.Text = "This is Not Valid";
                txtLogPassword.Clear();
                txtLogUserName.Clear();
                txtLogUserName.Focus();
            }
        }
        private void btnLogLogin_Click(object sender, EventArgs e)
        {
            logNext();
        }

        private void txtLogUserName_KeyDown(object sender, KeyEventArgs e)
        {
           // txtLogPassword.Focus();

        }

        private void txtLogUserName_KeyUp(object sender, KeyEventArgs e)
        {
         //   btnLogLogin.Focus();    
        }

        private void txtLogPassword_KeyDown(object sender, KeyEventArgs e)
        {
            //btnLogLogin.Focus();
        }

        private void txtLogPassword_KeyUp(object sender, KeyEventArgs e)
        {
           // txtLogUserName.Focus();
        }

        private void txtLogUserName_Enter(object sender, EventArgs e)
        {
           // txtLogPassword.Focus();
        }

        private void txtLogPassword_Enter(object sender, EventArgs e)
        {
           // btnLogLogin.Focus();
        }

        private void btnLogLogin_Enter(object sender, EventArgs e)
        {
           //logNext();
        }

        private void btnLogLogin_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnLogLogin_KeyDown(object sender, KeyEventArgs e)
        {
           // pictureBox4.Focus();
        }
    }
}
