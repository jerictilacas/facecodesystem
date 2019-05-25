using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace curfew
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            sn.Text = ConfigurationManager.AppSettings["oServer"];
            dn.Text = ConfigurationManager.AppSettings["oCompanyDB"];
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {

        }

        private void sn_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            SqlSettings.SetSetting("oServer", sn.Text);
            SqlSettings.SetSetting("oCompanyDB", dn.Text);
            MessageBox.Show("New Settings Applied!", "Connection Settings", MessageBoxButtons.OK, MessageBoxIcon.None);
            Application.Restart();
        }

        private void clsBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
