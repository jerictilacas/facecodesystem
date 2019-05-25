using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace curfew
{
    public partial class Registration : Form
    {
        String ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=MinorInformation;Integrated Security=True";
        public Registration()
        {
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x00020000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
        private void BunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.Show();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            if (firstname.Text == "" || lastname.Text == "" || username.Text == "" || password.Text == "")
                MessageBox.Show("Please fill mandatory fields!");

            else if (password.Text != confirmpass.Text)
                MessageBox.Show("Password not matched!");

            else
            {
                using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("Admin_Registration", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@FirstName", firstname.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@LastName", lastname.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@UserName", username.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Password", password.Text.Trim());
                    sqlCmd.ExecuteNonQuery();

                    MessageBox.Show("Registration is successful");
                    Clear();

                    this.Hide();
                    Login log = new Login();
                    log.Show();
                }
            }
        }
        void Clear()
        {
            firstname.Text = lastname.Text = username.Text = password.Text = "";

        }
    }
    
}
