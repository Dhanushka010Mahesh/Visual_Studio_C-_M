using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DMeduCLUB_MY_ICT_PROJECT
{
    public partial class menuWindowForm : Form
    {
        public menuWindowForm()
        {
            InitializeComponent();
        }
        bool UpAndDown = true;
        private void heloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UpAndDown == true)
            {
                menuCategary.Dock = DockStyle.Left;
                UpAndDown = false;
                heloToolStripMenuItem.Image = Image.FromFile(@"E:\Semasters(1-2) Notes\All Main Projects\DMeduCLUB_MY_ICT_PROJECT\DMeduCLUB_MY_ICT_PROJECT\bin\Debug\pic\menuIcons1.png");
            }
            else
            {
                menuCategary.Dock = DockStyle.Top;
                UpAndDown = true;
                heloToolStripMenuItem.Image = Image.FromFile(@"E:\Semasters(1-2) Notes\All Main Projects\DMeduCLUB_MY_ICT_PROJECT\DMeduCLUB_MY_ICT_PROJECT\bin\Debug\pic\menuIcons2.png");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loginWindowForm1 loginForm = new loginWindowForm1();
            loginForm.MdiParent = this;
            loginForm.WindowState = FormWindowState.Normal;
            loginForm.Show();
        }

        private void menuWindowForm_Load(object sender, EventArgs e)
        {
            heloToolStripMenuItem.Image = Image.FromFile(@"E:\Semasters(1-2) Notes\All Main Projects\DMeduCLUB_MY_ICT_PROJECT\DMeduCLUB_MY_ICT_PROJECT\bin\Debug\pic\menuIcons2.png");
        }

        private void editAndViewMemberDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editAndViewForm editAndViewForm = new editAndViewForm();
            editAndViewForm.MdiParent = this;
            editAndViewForm.WindowState = FormWindowState.Normal;
            editAndViewForm.Show();
        }
        private void addMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addMemberForm addMembersForm = new addMemberForm();
            addMembersForm.MdiParent = this;
            addMembersForm.WindowState = FormWindowState.Normal;
            addMembersForm.Show();
        }

        private void noticeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Notification notificationForm = new Notification();
            notificationForm.MdiParent = this;
            notificationForm.WindowState = FormWindowState.Normal;
            notificationForm.Show();
        }
    }
}
