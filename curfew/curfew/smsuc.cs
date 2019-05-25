using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Collections.Specialized;
using System.IO;

namespace curfew
{
    public partial class smsuc : UserControl
    {
        private static smsuc _instance;
  
        public static smsuc Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new smsuc();
                return _instance;
            }
        }

        public smsuc()
        {
            InitializeComponent();
        }

        private void UseraccUC_Load(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }
        //########################################################################################
        //iTexmo API for C# / ASP --> go to www.itexmo.com/developers.php for API Documentation
        //########################################################################################
        public object itexmo(string Number, string Message, string API_CODE)
        {
            object functionReturnValue = null;
            using (System.Net.WebClient client = new System.Net.WebClient())
            {
                System.Collections.Specialized.NameValueCollection parameter = new System.Collections.Specialized.NameValueCollection();
                string url = "https://www.itexmo.com/php_api/api.php";
                parameter.Add("1", Number);
                parameter.Add("2", Message);
                parameter.Add("3", API_CODE);
                dynamic rpb = client.UploadValues(url, "POST", parameter);
                functionReturnValue = (new System.Text.UTF8Encoding()).GetString(rpb);
            }
            return functionReturnValue;
        }



        //########################################################################################
        //API END     '###########################################################################
        //########################################################################################
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            dynamic result = itexmo(contactnum.Text, messagebox.Text, "TR-JERIC125140_Q7FLJ");
            if (result == "0")
            {
                MessageBox.Show("Message has Successfully Sent !");
            }
            else
            {
                MessageBox.Show("Error num " + result + " was encountered");
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void message_Click(object sender, EventArgs e)
        {

        }

       
        private void sendername_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            messagebox.Text = "Your child Commited the First Offence";
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            messagebox.Text = "Your child Commited the Second Offence";
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            messagebox.Text = "Your child Commited the Third Offence";
        }

        private void contactnum_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {

        }
    }
}
