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
    public partial class recorddatauc : UserControl
    {
        private static recorddatauc _instance;
        public static recorddatauc Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new recorddatauc();
                return _instance;
            }
        }
      

        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=MinorInformation;Integrated Security=True");
        public recorddatauc()
        {
            InitializeComponent();
            con.Open();
            SqlDataAdapter sd = new SqlDataAdapter("SELECT minorID as q, Firstname as A, Lastname as B, Age as C, Gender as D, Address as E, Contact as F, Offence as G, Date as H FROM minor_record", con);
            SqlCommandBuilder cd = new SqlCommandBuilder(sd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            recordData.DataSource = dt;
            con.Close();


        }

        string id;
        private void recordData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                label1.Text = (recordData.Rows[e.RowIndex].Cells[0].Value.ToString());
                id = (recordData.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }
        
        private void recorddatauc_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sd = new SqlDataAdapter("SELECT minorID as q, Firstname as A, Lastname as B, Age as C, Gender as D, Address as E, Contact as F, Offence as G, Date as H FROM minor_record", con);
            SqlCommandBuilder cd = new SqlCommandBuilder(sd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            recordData.DataSource = dt;
            con.Close();

        }

        private void recorddatauc_ControlAdded(object sender, ControlEventArgs e)
        {
            con.Open();
            SqlDataAdapter sd = new SqlDataAdapter("SELECT minorID as q, Firstname as A, Lastname as B, Age as C, Gender as D, Address as E, Contact as F, Offence as G, Date as H FROM minor_record", con);
            SqlCommandBuilder cd = new SqlCommandBuilder(sd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            recordData.DataSource = dt;
            con.Close();

        }

        private void recorddatauc_Load_1(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            Bitmap bmp = Properties.Resources.print;
            Image newImage = bmp;
            e.Graphics.DrawImage(newImage, 10, 10, newImage.Width, newImage.Height);
            e.Graphics.DrawString("This are the list of the minor offenders who committed the offense", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(100, 420));
            e.Graphics.DrawString("during the curfew ordinance operation.", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(80, 440));
            //e.Graphics.DrawString("List of Records", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(60, 520));
            e.Graphics.DrawString("Date Report:" + " " + DateTime.Now, new Font("Arial", 16, FontStyle.Bold), Brushes.Black, new Point(20, 500));



            Bitmap bm = new Bitmap(this.recordData.Width, this.recordData.Height);
            recordData.DrawToBitmap(bm, new Rectangle(0, 0, this.recordData.Width, this.recordData.Height));
            e.Graphics.DrawImage(bm, 0, 560);

            e.Graphics.DrawString("HON. MANOLITA M. ABARQUEZ", new Font("Arial Black", 12, FontStyle.Underline), Brushes.Black, new Point(80, 880));
            e.Graphics.DrawString("Barangay Captain", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(140, 910));

            e.Graphics.DrawString("LUCIANA L. ALFEREZ", new Font("Arial Black", 12, FontStyle.Underline), Brushes.Black, new Point(500, 880));
            e.Graphics.DrawString("Curfew Coordinator", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(520, 910));

        }

        private void searchBox_Enter(object sender, EventArgs e)
        {
            if (searchBox.Text == "Search")
            {
                searchBox.Text = "";
                searchBox.ForeColor = Color.Black;
            }
        }

        private void searchBox_Leave(object sender, EventArgs e)
        {
            if (searchBox.Text == "")
            {
                searchBox.Text = "Search";
                searchBox.ForeColor = Color.DarkGray;
            }
        }


        private void searchBtn_Click(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = recordData.DataSource;
            bs.Filter = "A like '%" + searchBox.Text + "%'";
            recordData.DataSource = bs;
        }

        private void searchBox_OnValueChanged(object sender, EventArgs e)
        {
            if (searchBox.Text == "")
            {
                SqlDataAdapter sd = new SqlDataAdapter("SELECT minorID as q, Firstname as A, Lastname as B, Age as C, Gender as D, Address as E, Contact as F, Offence as G, Date as H FROM minor_record", con);
                SqlCommandBuilder cd = new SqlCommandBuilder(sd);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                recordData.DataSource = dt;
                recordData.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        public void DisableButtons()
        {
           
            removeBtn.Visible = false;
        }

        public void EnableButtons()
        {
           
            removeBtn.Visible = true;
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            DialogResult resu = MessageBox.Show("Are you sure you want to delete this data ?", "Deleting a minor data", MessageBoxButtons.YesNo);
            if (resu == DialogResult.Yes)
            {

                SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=MinorInformation;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("Delete from minor_record  where minorID = '" + label1.Text + "'", con);
                //cmd.CommandText = "delete from minor_record where minorID = " + label1.Text ;
                con.Open();
                cmd.ExecuteNonQuery();
                DisplayInfo();
                MessageBox.Show("Removed");

            }
            else if (resu == DialogResult.No)
            {
                MessageBox.Show("Operation cancelled");
            }
        }
        public void DisplayInfo()
        {
            SqlDataAdapter sd = new SqlDataAdapter("SELECT minorID as q, Firstname as A, Lastname as B, Age as C, Gender as D, Address as E, Contact as F, Offense as G, Date as H FROM minor_record", con);
            SqlCommandBuilder cd = new SqlCommandBuilder(sd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            recordData.DataSource = dt;
        }

    }
}
