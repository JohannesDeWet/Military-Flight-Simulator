using PRG282_Project_LijaniVWDV_JohannesDW.DataHandlers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG282_Project_LijaniVWDV_JohannesDW.Forms
{
    public partial class frmLoginScreen : Form
    {
        private DatabaseDataHandler myDatabase = new DatabaseDataHandler();
        public frmLoginScreen()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            if (myDatabase.AdminCanLogin(txtUsername.Text,txtPassWord.Text))
            {
                Hide();
                frmPlane myAdminScreen = new frmPlane();
                myAdminScreen.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Please enter the correct username and password");
            }
        }

        private void btnEditPlane_Click(object sender, EventArgs e)
        {
            if (myDatabase.AdminCanLogin(txtUsername.Text, txtPassWord.Text))
            {
                Hide();
                frmPlaneEdit myAdminScreen = new frmPlaneEdit();
                myAdminScreen.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Please enter the correct username and password");
            }
        }

        private void btnEditAdmins_Click(object sender, EventArgs e)
        {
            if (myDatabase.AdminCanLogin(txtUsername.Text, txtPassWord.Text))
            {
                Hide();
                frmEditAdmin myAdminScreen = new frmEditAdmin();
                myAdminScreen.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Please enter the correct username and password");
            }
        }
    }
}
