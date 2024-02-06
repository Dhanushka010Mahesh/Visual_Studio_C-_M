using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace DMeduCLUB_MY_ICT_PROJECT
{
    public partial class Notification : Form
    {
        SqlConnection connection1 = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\My Project 2023\\DMeduCLUB_MY_ICT_PROJECT\\DMeduCLUB_MY_ICT_PROJECT\\MainDatabase.mdf\";Integrated Security=True");
        public Notification()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void selectMemberDetails()

        {
            connection1.Open();

            string MemberTableDetals = "select MemberId , MemberName from Members";
            SqlDataAdapter sda = new SqlDataAdapter(MemberTableDetals, connection1);
            SqlCommandBuilder bilder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            dgvNoteMemberDetails.DataSource = ds.Tables[0];


            selectComment();


            connection1.Close();
         

        }
        private void DoCode()
        {
            connection1.Open();

            string NId = txtNoteId1.Text;
            string NComment = txtNoteComment.Text;

            string NoteRecod = "insert into CommentTable values('" + NId + "' ,'" + NComment + "')";
            SqlCommand cmnd = new SqlCommand(NoteRecod, connection1);
            cmnd.ExecuteNonQuery();
            selectComment();


        }
        private void selectComment()
        {
            string commentTable = "select * from CommentTable";
            SqlDataAdapter comSda = new SqlDataAdapter(commentTable, connection1);
            var NewDs = new DataSet();
            comSda.Fill(NewDs);
            dgvNoteComment.DataSource = NewDs.Tables[0];
            connection1.Close();
        }
        private void Notification_Load(object sender, EventArgs e)
        {
            selectMemberDetails();
            selectCheck();
            selectComment();
        }

        private void btnNoteSave_Click(object sender, EventArgs e)
        {
            
            
            if (txtNoteId1.Text !=string.Empty && txtNoteComment .Text !=string.Empty )
            {


                DoCode();
               



            }
            else
            {
                MessageBox.Show("Fill text box And after press save");
            }
            
        }
        int key = 0;
        private void dgvNoteComment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void btnNoteRemove1_Click(object sender, EventArgs e)
        {
            connection1.Open();
            string deleteList = "delete from CommentTable where MemberId='" + key + "'";
            SqlCommand sqlCommand1 = new SqlCommand(deleteList, connection1);
            sqlCommand1.ExecuteNonQuery();
            MessageBox.Show("Member comment deleted");

            connection1.Close();
            
            selectComment();
        }

        private void dgvNoteComment_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            key = Convert.ToInt32(dgvNoteComment.SelectedRows[0].Cells[0].Value.ToString());
            txtNoteId1.Text = dgvNoteComment.SelectedRows[0].Cells[0].Value.ToString();
            txtNoteComment.Text = dgvNoteComment.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void btnNoteClear_Click(object sender, EventArgs e)
        {
            txtNoteComment.Clear();
            txtNoteId1.Clear();
        }

        private void btnNoteSubmit_Click(object sender, EventArgs e)
        {
            if(txtNoteId2.Text!=string.Empty && cbNoteSeason.Checked==true || cbNoteTrip.Checked == true)
            {
                DoServise();
            }
            else
            {
                MessageBox.Show("Click one Check box and fill member id");
            }
        }
        private void DoServise()
        {
            string CheckSeason="Not Need";
            string checkTrip="Not Join";



                if (cbNoteSeason.Checked == true && cbNoteTrip.Checked == true)
                {
                    CheckSeason = "Need";
                    checkTrip = "Join";
                }
                else if (cbNoteSeason.Checked == true)
                {
                    CheckSeason = "Need";
                    if (cbNoteTrip.Checked == false)
                    {
                        checkTrip = "Not Join";
                    }

                }
                else if (cbNoteSeason.Checked == false)
                {
                    CheckSeason = "Not Need";
                    if (cbNoteTrip.Checked == true)
                    {
                        checkTrip = "Join";
                    }
                }



            connection1.Open();

            string NoteRecod1 = "insert into ServiseTable values('" + txtNoteId2.Text + "' ,'" + CheckSeason + "' , '" + checkTrip + "')";
            SqlCommand cmnd = new SqlCommand(NoteRecod1, connection1);
            cmnd.ExecuteNonQuery();
            selectCheck();

            connection1.Close();
        }
        private void selectCheck()
        {
            string ServiseTable1 = "select * from ServiseTable";
            SqlDataAdapter comSda = new SqlDataAdapter(ServiseTable1, connection1);
            var NewDs = new DataSet();
            comSda.Fill(NewDs);
            dgvNoteServises.DataSource = NewDs.Tables[0];
            connection1.Close();
        }

        private void btnNoteRemove2_Click(object sender, EventArgs e)
        {
            connection1.Open();
            string deleteList = "delete from ServiseTable where MemberId='" + key + "'";
            SqlCommand sqlCommand1 = new SqlCommand(deleteList, connection1);
            sqlCommand1.ExecuteNonQuery();
            MessageBox.Show("Member choise deleted");

            connection1.Close();

            selectCheck();
        }

        private void btnNoteclear2_Click(object sender, EventArgs e)
        {
            txtNoteId2.Clear();
            cbNoteSeason.Checked = false;
            cbNoteTrip.Checked = false;
        }

        private void dgvNoteServises_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            key = Convert.ToInt32(dgvNoteServises.SelectedRows[0].Cells[0].Value.ToString());
            txtNoteId2.Text = dgvNoteServises.SelectedRows[0].Cells[0].Value.ToString();
            string CheckSeason1 = dgvNoteServises.SelectedRows[0].Cells[1].Value.ToString();
            string checkTrip11 = dgvNoteServises.SelectedRows[0].Cells[2].Value.ToString();
           
            
            

             if (CheckSeason1 == "Need")
             {
                 
                cbNoteSeason.Checked = true;
             }
             else if (CheckSeason1 == "Not Need")
             {
                
                cbNoteSeason.Checked = false;
             }
             else
             {
                 MessageBox.Show("END");
             }
           /* string checkTrip2 = checkTrip11.Replace(" ", "");
           MessageBox.Show("and trip  :" + checkTrip2 + ":   :");

           MessageBox.Show("Begin If");

           if(checkTrip2 == "join")
           {
               MessageBox.Show("hi");
           }*/

        }
    }
}
