using PRG282_Project_LijaniVWDV_JohannesDW.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG282_Project_LijaniVWDV_JohannesDW
{
    public partial class frmIntro : Form
    {
        public frmIntro()
        {
            InitializeComponent();
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
            Hide();
            frmLoginScreen myAdminLogin = new frmLoginScreen();
            myAdminLogin.ShowDialog();
            Close();
        }
    }
}
