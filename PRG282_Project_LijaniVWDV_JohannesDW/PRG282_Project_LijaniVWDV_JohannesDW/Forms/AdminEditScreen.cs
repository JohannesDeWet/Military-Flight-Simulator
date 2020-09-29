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
            fillCollection();
            FillInventoryForm();
        }
        private void fillCollection() 
        {
            myAdminCollection = myDatabase.SelectAllAdmins();
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

        private void dgvAllAdmins_MouseClick(object sender, MouseEventArgs e)
        {
            int currentSelectedAdmin = dgvAllAdmins.CurrentCell.RowIndex;
            txtUsername.Text = myAdminCollection[currentSelectedAdmin].AdminName;
            txtPassWord.Text = myAdminCollection[currentSelectedAdmin].AdminPassword;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int amountOfAdmins = myAdminCollection.Count;
            myDatabase.AddAdmin(txtUsername.Text,txtPassWord.Text);
            myAdminCollection.Add(new Admin(txtUsername.Text, txtPassWord.Text));
            FillInventoryForm();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUsername.Text))
            {
                bool exists = false;
                for (int i = 0; i < myAdminCollection.Count; i++)
                {
                    if (txtUsername.Text == myAdminCollection[i].AdminName && txtPassWord.Text == myAdminCollection[i].AdminPassword)
                    {
                        exists = true;
                    }
                }
                if (exists)
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove: " + txtUsername.Text, "Confirmation", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        int currentSelectedAdmin = dgvAllAdmins.CurrentCell.RowIndex;
                        myAdminCollection.RemoveAt(currentSelectedAdmin);
                        myDatabase.DeleteAdmin(txtUsername.Text);
                        FillInventoryForm();
                    }
                }
                else
                {
                    MessageBox.Show("This user does not exist in the database, the username and or password does not match");
                }
            }
            else
            {
                MessageBox.Show("Please select a Admin to Delete");
            }

            
        }
    }
}
