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
        private Plane mySelectedPlane = new Plane();
        private DatabaseDataHandler myDatabase = new DatabaseDataHandler();
        private BindingSource inventoryGrid = new BindingSource();
        private List<Bomb> myBombCollection = new List<Bomb>();
        private List<Bomb> myInventoryCollection = new List<Bomb>();


        public InventoryScreen()
        {
            InitializeComponent();
        }

        public InventoryScreen(string planeName, int payload, int fuelCapacity, int mountingPoints)
        {
            mySelectedPlane.PlaneName = planeName;
            mySelectedPlane.Payload = payload;
            mySelectedPlane.FuelCapacity = fuelCapacity;
            mySelectedPlane.MountingPoints = mountingPoints;
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
            lblMaxMountPoints.Text = mySelectedPlane.MountingPoints.ToString();
            lblFlyRange.Text = mySelectedPlane.FuelCapacity.ToString();
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
            myInventoryCollection.Add(myBombCollection[dgvAllBombs.CurrentCell.RowIndex]);
            inventoryGrid.DataSource = typeof(Bomb);
            inventoryGrid.Add(myBombCollection[dgvAllBombs.CurrentCell.RowIndex]);
            dgvCurrentInventory.DataSource = inventoryGrid;
            VisualOverOutput(CalculateCurrentWeight(), CalculateCurrentPoints());
            ChangeWeightPointFeulLable(CalculateCurrentWeight(), CalculateCurrentPoints(), CalculateRangeRemoved(CalculateCurrentWeight()));
        }

        private void btnRemoveBomb_Click(object sender, EventArgs e)
        {
            myInventoryCollection.RemoveAt(dgvCurrentInventory.CurrentCell.RowIndex);
            inventoryGrid.DataSource = typeof(Bomb);
            inventoryGrid.RemoveAt(dgvCurrentInventory.CurrentCell.RowIndex);
            dgvCurrentInventory.DataSource = inventoryGrid;
            VisualOverOutput(CalculateCurrentWeight(), CalculateCurrentPoints());
            ChangeWeightPointFeulLable(CalculateCurrentWeight(), CalculateCurrentPoints(), CalculateRangeRemoved(CalculateCurrentWeight()));

        }

        private void btnFinished_Click(object sender, EventArgs e)
        {
            if (CanAddAllToInventory(CalculateCurrentWeight(),CalculateCurrentPoints()))
            {
                Hide();
                frmPlane myInventoryScreen = new frmPlane(CreateListofInventoryBombItems(), mySelectedPlane.PlaneName, (mySelectedPlane.FuelCapacity-CalculateRangeRemoved(CalculateCurrentWeight())));
                myInventoryScreen.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Please insure that you have less or equal the amount of the max weight and points values");
            }

        }
        private List<string> CreateListofInventoryBombItems()
        {
            List<string> myInventoryBombIDCollection = new List<string>();
            for (int i = 0; i < myInventoryCollection.Count; i++)
            {
                myInventoryBombIDCollection.Add(myInventoryCollection[i].BombID);
            }
            return myInventoryBombIDCollection;
        }
        private int CalculateCurrentWeight() 
        {
            int currentWeight = 0;
            for (int i = 0; i < myInventoryCollection.Count; i++)
            {
                currentWeight += myInventoryCollection[i].BombWeight;
            }
            return currentWeight;
        }
        private int CalculateCurrentPoints()
        {
            int currentPoints = 0;
            for (int i = 0; i < myInventoryCollection.Count; i++)
            {
                currentPoints += myInventoryCollection[i].MountPoints;
            }
            return currentPoints;
        }
        private bool CanAddAllToInventory(int currentWeight, int currentPoints) 
        {
            if (currentWeight <= mySelectedPlane.Payload && currentPoints <= mySelectedPlane.MountingPoints)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void VisualOverOutput(int currentWeight, int currentPoints) 
        {
            if (currentWeight <= mySelectedPlane.Payload)
            {
                lblCurrentWeight.ForeColor = Color.FromArgb(0, 0, 0);
            }
            else
            {
                lblCurrentWeight.ForeColor = Color.FromArgb(255, 0, 0);
            }

            if (currentPoints <= mySelectedPlane.MountingPoints)
            {
                lblCurrentPoints.ForeColor = Color.FromArgb(0, 0, 0);
            }
            else
            {
                lblCurrentPoints.ForeColor = Color.FromArgb(255, 0, 0);
            }
        }
        private float CalculateRangeRemoved(int currentWeight) 
        {
            //change the factor of how much the feul range will change based on weight
            float weightFactor = 3.6f;
            return currentWeight * weightFactor;
        }
        private void ChangeWeightPointFeulLable(int currentWeight, int currentPoints, float rangeRemoved) 
        {
            lblCurrentWeight.Text = currentWeight.ToString();
            lblCurrentPoints.Text = currentPoints.ToString();
            lblRangeremoved.Text = "-" + rangeRemoved;
            lblRangeLeft.Text = (mySelectedPlane.FuelCapacity - rangeRemoved).ToString();
        }
    }
}
