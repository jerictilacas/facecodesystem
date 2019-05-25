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
    public partial class homeuc : UserControl
    {
        private static homeuc _instance;
        public static homeuc Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new homeuc();
                return _instance;
            }
        }
        public homeuc()
        {
            InitializeComponent();

            pictureBox1.Controls.Add(pictureBox5);
            pictureBox5.Location = new Point(430, 441);
            pictureBox5.BackColor = Color.Transparent;

            pictureBox1.Controls.Add(pictureBox4);
            pictureBox4.Location = new Point(219, 441);
            pictureBox4.BackColor = Color.Transparent;

            pictureBox1.Controls.Add(pictureBox3);
            pictureBox3.Location = new Point(8, 441);
            pictureBox3.BackColor = Color.Transparent;

            pictureBox1.Controls.Add(pictureBox7);
            pictureBox7.Location = new Point(641, 441);
            pictureBox7.BackColor = Color.Transparent;

            InitializeComponent();
        }

        private void homeuc_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Loginuc1_Load(object sender, EventArgs e)
        {
        }
    

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void BunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void BunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void BunifuCustomLabel6_Click(object sender, EventArgs e)
        {

        }

        private void BunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void BunifuCustomLabel5_Click(object sender, EventArgs e)
        {

        }

        private void BunifuCustomLabel4_Click(object sender, EventArgs e)
        {

        }

        private void BunifuCustomLabel7_Click(object sender, EventArgs e)
        {

        }

        private void BunifuCustomLabel8_Click(object sender, EventArgs e)
        {

        }

        private void BunifuCustomLabel10_Click(object sender, EventArgs e)
        {

        }

        private void BunifuCustomLabel9_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox7_Click(object sender, EventArgs e)
        {

        }
    }
}
