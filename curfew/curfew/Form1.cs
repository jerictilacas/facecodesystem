using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace curfew
{
    public partial class Form1 : Form
    {
        public static Form1 _instance;
        public static Form1 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Form1();
                return _instance;
            }
        }

        public Panel GlobalPanel
        {
            get { return ucpanel; }
            set { ucpanel = value; }
        }
        public Form1()
        {
            InitializeComponent();
            container.Controls.Add(exitbtn);
            exitbtn.Location = new Point(285, 6);
            exitbtn.BackColor = Color.Transparent;
            
            container.Controls.Add(resdownbtn);
            resdownbtn.Location = new Point(240, 4);
            resdownbtn.BackColor = Color.Transparent;

            container.Controls.Add(minimizer);
            minimizer.Location = new Point(190, 21);
            minimizer.BackColor = Color.Transparent;

            DisplayHome();
        }
       
        private void minimizer_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                Application.Exit();

        }

        private void slideron_Click(object sender, EventArgs e)
        {
            if (slidepanel.Width == 60)
            {
                slidepanel.Visible = false;
                slidepanel.Width = 210;
                slidepanelanimator.ShowSync(slidepanel);
            }
            else
            {
                slidepanel.Visible = false;
                slidepanel.Width = 60;
                slidepanelanimator.ShowSync(slidepanel);
            }

        }


        public void DisplayHome()
        {
            if (!ucpanel.Controls.Contains(homeuc.Instance))
            {
                ucpanel.Controls.Add(homeuc.Instance);
                homeuc.Instance.Dock = DockStyle.Fill;
                homeuc.Instance.BringToFront();
                slidepanel.Visible = true;

                toppanel.Visible = true;
                
            }
            else
                homeuc.Instance.BringToFront();

        }



        private void accbtn_Click(object sender, EventArgs e)
        {
            if (!ucpanel.Controls.Contains(smsuc.Instance))
            {
                ucpanel.Controls.Add(smsuc.Instance);
                smsuc.Instance.Dock = DockStyle.Fill;
                smsuc.Instance.BringToFront();
            }
            else
                smsuc.Instance.BringToFront();
        }
        
        private void recordbtn_Click(object sender, EventArgs e)
        {
            if (!ucpanel.Controls.Contains(recorduc.Instance))
            {
                ucpanel.Controls.Add(recorduc.Instance);
                recorduc.Instance.Dock = DockStyle.Fill;
                recorduc.Instance.BringToFront();
                recorduc.Instance.checkProps();
            }
            
            else
            {
                recorduc.Instance.checkProps();
                recorduc.Instance.BringToFront();
            }
       
        }

        private void resaddbtn_Click(object sender, EventArgs e)
        {
            if (!ucpanel.Controls.Contains(adduc.Instance))
            {
                ucpanel.Controls.Add(adduc.Instance);
                adduc.Instance.Dock = DockStyle.Fill;
                adduc.Instance.BringToFront();
            }

            else
            {
                adduc.Instance.BringToFront();
            }
            
        }

        public void triggerClickAdd()
        {
            this.resaddbtn_Click(null, null);
        }

        private void ucpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (!ucpanel.Controls.Contains(recorddatauc.Instance))
            {
                ucpanel.Controls.Add(recorddatauc.Instance);
                recorddatauc.Instance.Dock = DockStyle.Fill;
                recorddatauc.Instance.BringToFront();
            }
            else
                recorddatauc.Instance.BringToFront();
        }

        private void ucpanel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void bunifuiOSSwitch1_OnValueChange(object sender, EventArgs e)
        {
            if (slidepanel.Width == 60)
            {
                slidepanel.Visible = false;
                slidepanel.Width = 210;
                slidepanelanimator.ShowSync(slidepanel);
            }
            else
            {
                slidepanel.Visible = false;
                slidepanel.Width = 60;
                slidepanelanimator.ShowSync(slidepanel);
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            DialogResult resu = MessageBox.Show("Are you sure you want to logout?", "Exiting FaceCode", MessageBoxButtons.YesNo);
            if (resu == DialogResult.Yes)
            {
                this.Hide();
                Login login = new Login();
                login.Show();
            }
            else if (resu == DialogResult.No)
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void slidepanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
              if (!ucpanel.Controls.Contains(homeuc.Instance))
            {
                ucpanel.Controls.Add(homeuc.Instance);
                homeuc.Instance.Dock = DockStyle.Fill;
                homeuc.Instance.BringToFront();
            }
            else
                homeuc.Instance.BringToFront();
        }

        private void container_Click(object sender, EventArgs e)
        {

        }
    }
}

