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
    public partial class InventoryScreen : Form
    {
        Plane mySelectedPlane = new Plane();
        DatabaseDataHandler myDatabase = new DatabaseDataHandler();
        BindingSource inventoryGrid = new BindingSource();
        List<Bomb> myBombCollection = new List<Bomb>();
        List<Bomb> myInventoryCollection = new List<Bomb>();

        public InventoryScreen()
        {
            InitializeComponent();
        }
        private void InventoryScreen_Load(object sender, EventArgs e)
        {
            myBombCollection = myDatabase.SelectAllBombs();
            FillInventoryForm();
        }
        private void FillInventoryForm()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = typeof(Bomb);
            for (int i = 0; i < myBombCollection.Count; i++)
            {
                bs.Add(myBombCollection[i]);
            }
            dgvAllBombs.DataSource = bs;

            lblPlaneName.Text = mySelectedPlane.PlaneName;
            lblMaxWeight.Text = mySelectedPlane.Payload.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
            frmPlane myIPlaneScreen = new frmPlane();
            myIPlaneScreen.ShowDialog();
            Close();
        }

        private void btnAddBomb_Click(object sender, EventArgs e)
        {
            inventoryGrid.DataSource = typeof(Bomb);
            inventoryGrid.Add(myBombCollection[dgvAllBombs.CurrentCell.RowIndex]);
            dgvCurrentInventory.DataSource = inventoryGrid;
        }

        private void btnRemoveBomb_Click(object sender, EventArgs e)
        {
            inventoryGrid.DataSource = typeof(Bomb);
            inventoryGrid.RemoveAt(dgvCurrentInventory.CurrentCell.RowIndex);
            dgvCurrentInventory.DataSource = inventoryGrid;
        }

        private void btnFinished_Click(object sender, EventArgs e)
        {

        }

        public void SharedInformaiton(string planeName, int payload, int fuelCapacity, int mountingPoints)
        {
            mySelectedPlane.PlaneName = planeName;
            mySelectedPlane.Payload = payload;
            mySelectedPlane.FuelCapacity = fuelCapacity;
            mySelectedPlane.MountingPoints = mountingPoints;
        }
    }
}
