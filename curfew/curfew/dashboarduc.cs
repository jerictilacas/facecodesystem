using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace curfew
{
    public partial class dashboarduc : UserControl
    {
        private static dashboarduc _instance;

        public static dashboarduc Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new dashboarduc();
                return _instance;
            }
        }

        public dashboarduc()
        {
            InitializeComponent();
        }

        private void DashboardUC_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
