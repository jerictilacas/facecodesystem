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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            //this.AcceptButton = signinbtn; 
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

        private void Signinbtn_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=MinorInformation;Integrated Security=True");
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand("Select * From registration Where UserName = '" + username.Text.Trim() + "' and Password = '" + Password.Text.Trim() + "'", sqlcon);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            int count = 0;

            while (dr.Read())
            {
                count += 1;
            }

            if (username.Text == "" || Password.Text == "")
            {
                MessageBox.Show("Please fill Mandatory Fields");
            }

            else if (count == 1)
            {
                this.Hide();
                Form1 f1 = new Form1();
                f1.DisplayHome();
                f1.Show();
            }
            else
            {
                MessageBox.Show("Check your Username or Password");
                username.Text = "";
                Password.Text = "";
            }

        }

        private void BunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration reg = new Registration();
            reg.Show();
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                Application.Exit();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void settings_Click(object sender, EventArgs e)
        {
            curfew.Settings set = new Settings();
            set.ShowDialog();
        }   
    }
}

