using PRG282_Project_LijaniVWDV_JohannesDW.ClassesFolder;
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
    public partial class frmEditAdmin : Form
    {
        private DatabaseDataHandler myDatabase = new DatabaseDataHandler();
        private List<Admin> myAdminCollection = new List<Admin>();
        public frmEditAdmin()
        {
            InitializeComponent();
        }

        private void frmEditAdmin_Load(object sender, EventArgs e)
        {
            myAdminCollection = myDatabase.SelectAllAdmins();
            FillInventoryForm();
        }
        private void FillInventoryForm()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = typeof(Admin);
            for (int i = 0; i < myAdminCollection.Count; i++)
            {
                bs.Add(myAdminCollection[i]);
            }
            dgvAllAdmins.DataSource = bs;
        }
    }
}
