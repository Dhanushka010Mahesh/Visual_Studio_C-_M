using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Data.SqlClient;
using System.Globalization;
using System.Text.RegularExpressions;

namespace DMeduCLUB_MY_ICT_PROJECT
{
    public partial class addMemberForm : Form
    {

        
        SqlConnection connection1 = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\My Project 2023\\DMeduCLUB_MY_ICT_PROJECT\\DMeduCLUB_MY_ICT_PROJECT\\MainDatabase.mdf\";Integrated Security=True");
        public int checkValue;
        //check
        private void dtpAddingBirth_ValueChanged(object sender, EventArgs e)
        {
            

        }

    
       
        
        private void txtAddingMemberID_Leave(object sender, EventArgs e)
        {
            // && typeof(int) GetType()
           /* if(int.TryParse(txtAddingMemberID.Text,out checkValue))
            {
                int mId=int.Parse(txtAddingMemberID.Text);
                
                if(txtAddingMemberID.Text.Length >= 3)
                {
                    txtAddingName.Focus();
                    MemberDetailsError.Clear();
                }
                else
                {
                    MemberDetailsError.SetError(txtAddingMemberID, "Messing charcter");

                    //MessageBox.Show("Messing charcter");
                    txtAddingMemberID.Focus();
                }

            }
            else
            {
                MemberDetailsError.SetError(txtAddingMemberID, "Enter Valid Member Id");
                //MessageBox.Show("Enter Valid Member Id");
                txtAddingMemberID.Focus();
            } */
        }

        private void txtAddingMemberID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddingAge_Leave(object sender, EventArgs e)
        {
            /* if (int.TryParse(txtAddingAge.Text, out checkValue))
            {
                int mAge = int.Parse(txtAddingAge.Text);
                if(mAge>15 && mAge < 50)
                {
                    txtAddingTelephone.Focus();
                    MemberDetailsError.Clear();
                }
                else
                {
                    MemberDetailsError.SetError(txtAddingAge, "you can't membership this club ");
                    txtAddingAge.Focus();
                }
                

            }
            else
            {
                MemberDetailsError.SetError(txtAddingAge, "member age is not valid");
                //MessageBox.Show("Enter Valid Member Age");
                txtAddingAge.Focus();
            } */
        }

        private void txtAddingTelephone_Leave(object sender, EventArgs e)
        {
           /* if (int.TryParse(txtAddingTelephone.Text, out checkValue))
            {
                int mId = int.Parse(txtAddingTelephone.Text);

                if (txtAddingTelephone.Text.Length == 10)
                {
                    txtAddingEmail.Focus();
                    MemberDetailsError.Clear();
                }
                else
                {
                    MemberDetailsError.SetError(txtAddingTelephone, "Messing Number");

                    //MessageBox.Show("Messing charcter");
                    txtAddingTelephone.Focus();
                }

            }
            else
            {
                MemberDetailsError.SetError(txtAddingTelephone, "Enter Valid Member Telephone Number");
                //MessageBox.Show("Enter Valid Member Id");
                txtAddingTelephone.Focus();
            } */
        }

        public addMemberForm()
        {
            InitializeComponent();
        }
        
        private void addMemberForm_Load(object sender, EventArgs e)
        {
            comAddingProvince.Items.Add("Northern");
            comAddingProvince.Items.Add("North Central");
            comAddingProvince.Items.Add("North Western");
            comAddingProvince.Items.Add("Eastern");
            comAddingProvince.Items.Add("Central");
            comAddingProvince.Items.Add("Western"); 
            comAddingProvince.Items.Add("Sabaragamuwa");
            comAddingProvince.Items.Add("Uwa");
            comAddingProvince.Items.Add("Southern");

            // connect1.Open();
            connection1.Open();
            string MemberTableDetals = "select * from Members";
            SqlDataAdapter sda = new SqlDataAdapter(MemberTableDetals, connection1);
            SqlCommandBuilder bilder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            dgvNewMember.DataSource = ds.Tables[0];
            connection1.Close();

            // connect1.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddingSave_Click(object sender, EventArgs e)
        {

            ValidateDetails();
           

        }
        private void btnAddingReset_Click(object sender, EventArgs e)
        {
            TextClear();
        }



        public void ValidateDetails()
        {
            try
            {
                MemberDetailsError.Clear();
                int check3;

                String id = txtAddingMemberID.Text;
                String name = txtAddingName.Text;
                String nic = txtAddingNic.Text;
                String province = comAddingProvince.Text;
                String campus = txtAddingCampusName.Text;
                String faculty = txtAddingFacalty.Text;
                String address = txtAddingAddress.Text;
                String age = txtAddingAge.Text;
                String numberPhone = txtAddingTelephone.Text;
                String email = txtAddingEmail.Text;
                String dob = (dtpAddingBirth.Text == "12/27/2002") ? "0" : "1";
                String gender1 = (rdoAddingMale.Checked == true) ? "male" : "female";
                String gender2 = (rdoAddingFemale.Checked == true) ? "female" : "male";
                String gender3 = (rdoAddingMale.Checked == false && rdoAddingFemale.Checked == false) ? "0" : "1`";
            


                if ((name == String.Empty) || (nic == String.Empty) || (province == "") || (campus == "") || (faculty == "") ||
                      (address == "") || (email == "") || (id == "") || (age == "") || (numberPhone == "") ||
                       (gender3 == "0") || (dob == "0"))
                {                  
                      // chaked String value empty true
                      MessageBox.Show("Enter all input details correctly");
                }

                //validate member id
                else if (!(int.TryParse(id, out check3)))
                {
                    MemberDetailsError.SetError(txtAddingMemberID, "Please enter valid member id ( 2240438 )");
                }
                else if (((Regex.IsMatch(id, "^[0-9]+$")) == false))
                {
                    MemberDetailsError.SetError(txtAddingMemberID, "Please enter valid member id ( 2240438 )");
                }
                else if (id.Length<7)
                {
                    MemberDetailsError.SetError(txtAddingMemberID, "Please enter valid member id ( 2240438 )");
                }

                //validate member name
                else if((Regex.IsMatch(name, "^[a-zA-Z_]+$"))==false)
                {
                    MemberDetailsError.SetError(txtAddingName, "Please enter valid member name ( Dhanushka_Mahesh )");
                }

                //validate member NIC number
                else if (((Regex.IsMatch(nic, "^[A-Z0-9]+$")) == false))
                {
                    MemberDetailsError.SetError(txtAddingNic, "Member NIC number is invalid ( 200236100669 or 727212167V )");
                }
                else if(nic.Length<10 || nic.Length > 12)
                {
                    MemberDetailsError.SetError(txtAddingNic, "Member NIC number is invalid ( 200236100669 or 727212167V )");
                }

                /*validate province
                label1:
                else if (province != "")
                {
                    String[] provinceList = { "Northern" , "North Central" , "North Western" , "Eastern" , "Central" , "Western", "Sabaragamuwa", "Uwa", "Southern" };
                    for(int i = 0; i < provinceList.Length; i++)
                    {
                        if (provinceList[i] == province)
                        {
                            goto label1;
                        }
                        MemberDetailsError.SetError(comAddingProvince, "Member NIC number is invalid ( 200236100669 or 727212167V )");
                    }
                } */

                //validate Member campus name
                else if ((Regex.IsMatch(campus, "^[a-zA-Z_]+$")) == false)
                {
                    MemberDetailsError.SetError(txtAddingCampusName, "Enter valid campus name ( Moratuwa_Campus )");
                }

                //validate faculty 
                else if ((Regex.IsMatch(faculty, "^[a-zA-Z_]+$")) == false)
                {
                    MemberDetailsError.SetError(txtAddingFacalty, "Enter valid faculty ( Faculty_of_Information_technology )");
                }

                //validate member adress
                else if ((Regex.IsMatch(address, "^[a-zA-Z0-9 _,./]+$")) == false)
                {
                    MemberDetailsError.SetError(txtAddingAddress, "Enter your home address correctly ( 54/1 , marawanagoda werellagama . )");
                }

                //validate member Age
                else if ((Regex.IsMatch(age, "^[0-9]+$")) == false)
                {
                    MemberDetailsError.SetError(txtAddingAge, "Age is invalid please enter valid age ( 19-49 )");
                }
                else if ((int.Parse(age)) < 18 || (int.Parse(age)) > 50)
                {

                    MemberDetailsError.SetError(txtAddingAge, "You can not Enroll this club ( 19-49 )");
                }

                //validate phone number
                else if ((Regex.IsMatch(numberPhone, "^[0-9]+$")) == false)
                {
                    MemberDetailsError.SetError(txtAddingTelephone, "Enter valid Phone number ( 0766640384 )");

                  /*  string phone = i["MyPhone"].ToString();
                    string area = phone.Substring(0, 3);
                    string major = phone.Substring(3, 3);
                    string minor = phone.Substring(6);
                    string formatted = string.Format("{0}-{1}-{2}", area, major, minor); */
                }
                else if (!(numberPhone.Length == 10))
                {

                    MemberDetailsError.SetError(txtAddingTelephone, "enter valid Phone Number ( 0706540384 )");
                }

                //validate email address
                else if ((Regex.IsMatch(email, "^[0-9A-Za-z@.]+$")) == false)
                {
                    MemberDetailsError.SetError(txtAddingEmail, "enter valid Phone Number ( Asus515dhanushka@gmail.com )");
                } 
                
                //execute
                else
                {
                    DetailsCorrectDoList();
                    TextClear();
                    
                }
            }catch(Exception e)
            {
                MessageBox.Show("miss"+e);
            }
        }
   
        private void TextClear()
        {
            txtAddingMemberID.Clear();
            txtAddingName.Clear();
            txtAddingNic.Clear();
            txtAddingCampusName.Clear();
            txtAddingFacalty.Clear();
            txtAddingEmail.Clear();
            txtAddingAddress.Clear();
            txtAddingAge.Clear();
            txtAddingTelephone.Clear();
            rdoAddingFemale.Checked = false;
            rdoAddingMale.Checked = false;
            dtpAddingBirth.Text = "12/26/2002";
            comAddingProvince.Text = string.Empty;
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
        private void InsertData()
        {

            String mid = txtAddingMemberID.Text;
            String mName = txtAddingName.Text;
            String mNic = txtAddingNic.Text;
            String mProvince = comAddingProvince.Text;
            String mCampus = txtAddingCampusName.Text;
            String mFaculty = txtAddingFacalty.Text;
            String mAddress = txtAddingAddress.Text;
            String mAge = txtAddingAge.Text;
            String mNumberPhone = txtAddingTelephone.Text;
            String mEmail = txtAddingEmail.Text;
            string mDob = dtpAddingBirth.Value.ToString();
            String gender1 = (rdoAddingMale.Checked == true) ? "male" : "female";
            String gender2 = (rdoAddingFemale.Checked == true) ? "female" : "male";
            String gender3 = (rdoAddingMale.Checked == false && rdoAddingFemale.Checked == false) ? "0" : "1`";

            
            string mGender;
            if (gender1=="male")
            {
                mGender = "Male";
            }
            else
            {
                mGender = "Female";
            }
     

            string recod1 = "insert into Members values('"+ mid +"' ,'"+mName+"','"+mNic+"','"+mProvince+"','"+mDob+"','"+mGender+"','"+mCampus+"','"+mFaculty+"','"+mAddress+"','"+mAge+"','"+ mNumberPhone + "','"+mEmail+"')";
            SqlCommand cmnd = new SqlCommand(recod1, connection1);
            cmnd.ExecuteNonQuery();
            
           


            // connect1.Open();

            string MemberTableDetals = "select * from Members";
            SqlDataAdapter sda = new SqlDataAdapter(MemberTableDetals, connection1);
            SqlCommandBuilder bilder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            dgvNewMember.DataSource = ds.Tables[0];


            // connect1.Close();


            MessageBox.Show("Save Sucassfull");
        }
    }
}
