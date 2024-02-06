using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.Text.RegularExpressions;

namespace DMeduCLUB_MY_ICT_PROJECT
{
    public partial class editAndViewForm : Form
    {
        int checkValue;
        SqlConnection connection1 = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\My Project 2023\\DMeduCLUB_MY_ICT_PROJECT\\DMeduCLUB_MY_ICT_PROJECT\\MainDatabase.mdf\";Integrated Security=True");
        public editAndViewForm()
        {
            InitializeComponent();
        }

      

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void editAndViewForm_Load(object sender, EventArgs e)
        {
            comEditProvince.Items.Add("Northern");
            comEditProvince.Items.Add("North Central");
            comEditProvince.Items.Add("North Western");
            comEditProvince.Items.Add("Eastern");
            comEditProvince.Items.Add("Central ");
            comEditProvince.Items.Add("Western");
            comEditProvince.Items.Add("Sabaragamuwa ");
            comEditProvince.Items.Add("Uwa");
            comEditProvince.Items.Add("Southern");

            comGender.Items.Add("Male");
            comGender.Items.Add("Female");

            selectMemberDetails();
        }

        private void dgvEditAndView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           // int row = e.RowIndex;
           // var data = Convert.ToString(dgvEditAndView[0, row].Value);
           // MessageBox.Show(data);

        }
        
        int key=0;
        private void dgvEditAndView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            key = Convert.ToInt32(dgvEditAndView.SelectedRows[0].Cells[0].Value.ToString());
            lblEditMemberID.Text = dgvEditAndView.SelectedRows[0].Cells[0].Value.ToString();
            txtEditName.Text = dgvEditAndView.SelectedRows[0].Cells[1].Value.ToString();
            txtEditNic.Text = dgvEditAndView.SelectedRows[0].Cells[2].Value.ToString();
            comEditProvince.Text = dgvEditAndView.SelectedRows[0].Cells[3].Value.ToString();
            dtpEditDob.Value = (DateTime)dgvEditAndView.SelectedRows[0].Cells[4].Value;
            comGender.Text = dgvEditAndView.SelectedRows[0].Cells[5].Value.ToString();
            txtEditCampusName.Text = dgvEditAndView.SelectedRows[0].Cells[6].Value.ToString();
            txtEditFacalty.Text = dgvEditAndView.SelectedRows[0].Cells[7].Value.ToString();
            txtEditAddress.Text = dgvEditAndView.SelectedRows[0].Cells[8].Value.ToString();
            txtEditAge.Text = dgvEditAndView.SelectedRows[0].Cells[9].Value.ToString();
            txtEditTelephone.Text = dgvEditAndView.SelectedRows[0].Cells[10].Value.ToString();
            txtEditEmail.Text = dgvEditAndView.SelectedRows[0].Cells[11].Value.ToString();
        }

        private void txtAddingMemberID_Leave(object sender, EventArgs e)
        {
           /* if (int.TryParse(txtEditMemberID.Text, out checkValue))
            {
                int mId = int.Parse(txtEditMemberID.Text);

                if (txtEditMemberID.Text.Length == 9)
                {
                    txtEditName.Focus();
                    MemberEditError.Clear();
                }
                else
                {
                    MemberEditError.SetError(txtEditMemberID, "Messing charcter");

                    //MessageBox.Show("Messing charcter");
                    txtEditMemberID.Focus();
                }

            }
            else
            {
                MemberEditError.SetError(txtEditMemberID, "Enter Valid Member Id");
                //MessageBox.Show("Enter Valid Member Id");
                txtEditMemberID.Focus();
            } */
        }

        private void btnEditSearch_Click(object sender, EventArgs e)
        {
            if(int.TryParse(txtEditSearch.Text, out int check))
            {
                int numSearch=int.Parse(txtEditSearch.Text);
                
             

            }
            else
            {
                MessageBox.Show("this number not valid");
            }
        }

        private void btnEditUpdate_Click(object sender, EventArgs e)
        {
            ValidateDetails();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            TextClear();
        }
        
        private void btnEditDelete_Click(object sender, EventArgs e)
        {
            connection1.Open();
            string deleteList = "delete from Members where MemberId='" + key + "'";
            SqlCommand sqlCommand1 = new SqlCommand(deleteList, connection1);
            sqlCommand1.ExecuteNonQuery();
            MessageBox.Show("Member details deleted");

            connection1.Close();
            selectMemberDetails();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void selectMemberDetails()
        {
            //connection1.Open();

            string MemberTableDetals = "select * from Members";
            SqlDataAdapter sda = new SqlDataAdapter(MemberTableDetals, connection1);
            SqlCommandBuilder bilder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            dgvEditAndView.DataSource = ds.Tables[0];


            //connection1.Close();
        }
        public void ValidateDetails()
        {
            try
            {
                MemberEditError.Clear();
                int check3;

                String id = lblEditMemberID.Text;
                String name = txtEditName.Text;
                String nic = txtEditNic.Text;
                String province = comEditProvince.Text;
                String campus = txtEditCampusName.Text;
                String faculty = txtEditFacalty.Text;
                String address = txtEditAddress.Text;
                String age = txtEditAge.Text;
                String numberPhone = txtEditTelephone.Text;
                String email = txtEditEmail.Text;
                String dob = (dtpEditDob.Text == "12/27/2002") ? "0" : "1";
                string gender=comGender.Text;



                if ((name == String.Empty) || (nic == String.Empty) || (province == "") || (campus == "") || (faculty == "") ||
                      (address == "") || (email == "") || (age == "") || (numberPhone == "") ||
                       (gender == "") || (dob == "0"))
                {
                    // chaked String value empty true
                    MessageBox.Show("You dont select Member details row or missing Details");
                }

           

                //validate member name
                else if ((Regex.IsMatch(name, "^[a-zA-Z_]+$")) == false)
                {
                    MemberEditError.SetError(txtEditName, "Please enter valid member name ( Dhanushka_Mahesh )");
                }

                //validate member NIC number
                else if (((Regex.IsMatch(nic, "^[A-Z0-9]+$")) == false))
                {
                    MemberEditError.SetError(txtEditNic, "Member NIC number is invalid ( 200236100669 or 727212167V )");
                }
                else if (nic.Length < 10 || nic.Length > 12)
                {
                    MemberEditError.SetError(txtEditNic, "Member NIC number is invalid ( 200236100669 or 727212167V )");
                }

                else if ((Regex.IsMatch(campus, "^[a-zA-Z_]+$")) == false)
                {
                    MemberEditError.SetError(txtEditCampusName, "Enter valid campus name ( Moratuwa_Campus )");
                }

                //validate faculty 
                else if ((Regex.IsMatch(faculty, "^[a-zA-Z_]+$")) == false)
                {
                    MemberEditError.SetError(txtEditFacalty, "Enter valid faculty ( Faculty_of_Information_technology )");
                }

                //validate member adress
                else if ((Regex.IsMatch(address, "^[a-zA-Z0-9 _,./]+$")) == false)
                {
                    MemberEditError.SetError(txtEditAddress, "Enter your home address correctly ( 54/1 , marawanagoda werellagama . )");
                }

                //validate member Age
                else if ((Regex.IsMatch(age, "^[0-9]+$")) == false)
                {
                    MemberEditError.SetError(txtEditAge, "Age is invalid please enter valid age ( 19-49 )");
                }
                else if ((int.Parse(age)) < 18 || (int.Parse(age)) > 50)
                {

                    MemberEditError.SetError(txtEditAge, "You can not Enroll this club ( 19-49 )");
                }

                //validate phone number
                else if ((Regex.IsMatch(numberPhone, "^[0-9]+$")) == false)
                {
                    MemberEditError.SetError(txtEditTelephone, "Enter valid Phone number ( 0766640384 )");

               
                }
                else if (!(numberPhone.Length == 10 || numberPhone.Length==9))
                {

                    MemberEditError.SetError(txtEditTelephone, "enter valid Phone Number ( 0706540384 )");
                }

                //validate email address
                else if ((Regex.IsMatch(email, "^[0-9A-Za-z@.]+$")) == false)
                {
                    MemberEditError.SetError(txtEditEmail, "enter valid Phone Number ( Asus515dhanushka@gmail.com )");
                }

                //execute
                else
                {
                    DetailsCorrectDoList();
                    TextClear();

                }
            }
            catch (Exception e)
            {
                MessageBox.Show("miss" + e);
            }
        }
        private void DetailsCorrectDoList()
        {

            connection1.Open();

            try
            {

                InsertData();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            connection1.Close();




        }
        public void InsertData()
        {
            string mId = lblEditMemberID.Text;
            string mName = txtEditName.Text;
            string mNic = txtEditNic.Text;
            string mProvince = comEditProvince.Text;
            string mDob = dtpEditDob.Value.ToString();
            string mGender = comGender.Text;
            string mCampus = txtEditCampusName.Text;
            string mFacalty = txtEditFacalty.Text;
            string mAddress = txtEditAddress.Text;
            string mAge = txtEditAge.Text;
            string mTel = txtEditTelephone.Text;
            string mEmail = txtEditEmail.Text;

            

            string updateList = "update Members set  MemberName='" + mName + "' , NIC='" + mNic + "' , Province='" + mProvince + "' , DateOFBirth='" + mDob + "' , Gender='" + mGender + "' , CampusName='" + mCampus + "' , Facalty='" + mFacalty + "' , MemberAddress='" + mAddress + "' , MemberAge='" + mAge + "' , PhoneNumber='" + mTel + "' , Email='" + mEmail + "' where MemberId='" + key + "' ";
            SqlCommand sqlCommand1 = new SqlCommand(updateList, connection1);
            sqlCommand1.ExecuteNonQuery();
            MessageBox.Show("Member details updated");

           
            selectMemberDetails();
        }
        private void TextClear()
        {
            lblEditMemberID.Text="";
            txtEditName.Clear();
            txtEditNic.Clear();
            txtEditCampusName.Clear();
            txtEditFacalty.Clear();
            txtEditEmail.Clear();
            txtEditAddress.Clear();
            txtEditAge.Clear();
            txtEditTelephone.Clear();
            comGender.Text = string.Empty;
            dtpEditDob.Text = "12/27/2002";
            comEditProvince.Text = string.Empty;
        }
    }
}
