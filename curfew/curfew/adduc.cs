using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace curfew
{
    public partial class adduc : UserControl 
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=MinorInformation;Integrated Security=True";

        public static bool checkVal = false;

        private static adduc _instance;
        public static adduc Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new adduc();
                return _instance;
            }
        }

        public adduc()
        {
            InitializeComponent();
            DOB.MaxDate = DateTime.Now;
        }

        public void UpdateAge()
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand acmd = new SqlCommand("update minor_record set Age = datediff(YY, DateOfBirth,GETDATE())",con);
            con.Open();
            acmd.ExecuteNonQuery();
            con.Close();
        }
        


        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
           
            if (fname.Text == "" || lname.Text == "" || gender.Text == "" || address.Text == "" || contact.Text == "")
                MessageBox.Show("Please fill Mandatory Fields");
            else
            {

                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                { 
                    

                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("AddMinor", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@FirstName", fname.Text);
                    sqlCmd.Parameters.AddWithValue("@LastName", lname.Text);
                    sqlCmd.Parameters.AddWithValue("@DOB", DOB.Value);
                    sqlCmd.Parameters.AddWithValue("@Gender", gender.Text);
                    sqlCmd.Parameters.AddWithValue("@Address", address.Text);
                    sqlCmd.Parameters.AddWithValue("@Contact", contact.Text);
                    sqlCmd.Parameters.AddWithValue("@Offence", 1);
                    sqlCmd.Parameters.AddWithValue("@Date",  DateTime.Now);

                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Minor Identity Added Successfully");
                    UpdateAge();
                    Clear();
                }
                
            }       
            
        }


        void Clear()
        {
            fname.Text = lname.Text = gender.Text = address.Text = contact.Text = "";
            DOB.Value = DOB.MaxDate;
        }

        private void sendbtn_Click(object sender, EventArgs e)
        {
            if (fname.Text == "" || lname.Text == "" || gender.Text == "" || address.Text == "" || contact.Text == "")
            {
                MessageBox.Show("Please fill up all the fields!");
            }
            else
            {
                recordFaceFrm.lname = lname.Text;
                recordFaceFrm.fname = fname.Text;

                recordFaceFrm captureFace = new recordFaceFrm();
                captureFace.Show();
            }
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (checkVal == true) { 
                sendbtn.Visible = true;
                capturebtn.Enabled = false;
            }
            else
            { 
                sendbtn.Visible = false;
                capturebtn.Enabled = true;
            }
        }

        private void adduc_Load(object sender, EventArgs e)
        {
            fname.Text = lname.Text = address.Text = gender.Text = contact.Text = "";
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void age_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Lname_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Contact_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
