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
    public partial class frmReport : Form
    {
        TextFileDataHandler mydata = new TextFileDataHandler();
        DatabaseDataHandler mydatabase = new DatabaseDataHandler();
        List<Buildings> myBuilding = new List<Buildings>();
        string selectedPlaneName = "";
        int mSearchLimit=0;
        List<string> myInventory = new List<string>();
        Plane myPlane = new Plane();
        public frmReport()
        {
            InitializeComponent();
        }
        public frmReport(string planeName, int range, List<string> inventory)
        {
            selectedPlaneName = planeName;
            mSearchLimit = range;
            myInventory = inventory;
            InitializeComponent();
        }

        private void FillScreen() 
        {
            txtPlaneName.Text = selectedPlaneName;
            pbPlaneUsed.ImageLocation = @"Resources\Images\Planes\" + selectedPlaneName + ".jpg";
            FillBombList();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            myBuilding = mydatabase.GetBuildings();
            FillScreen();
            FillPostRunStats();
        }
        private void FillBombList() 
        {
                lstBombs.Items.Clear();
                foreach (var dr in myInventory)
                {
                    ListViewItem item = new ListViewItem(dr);

                    lstBombs.Items.Add(item);
                }
        }
        public List<int> GenerateUniqueNumbers(int amountOfNumbers, int maxRange, int excludeNumber)
        {
            Random random = new Random();

            List<int> randomContainer = new List<int>();

            for (int i = 0; i < amountOfNumbers; i++)
            {
                int randomNumber = random.Next(maxRange);

                if (!randomContainer.Contains(randomNumber))
                {
                    if (randomNumber != excludeNumber)
                    {
                        randomContainer.Add(randomNumber);
                    }
                    else
                    {
                        i--;
                    }

                }
                else
                {
                    i--;
                }
            }
            return randomContainer;
        }

        public void FillPostRunStats()
        {
            myPlane = mydatabase.GetSpecificPlane(selectedPlaneName);

            ListViewItem lvi = new ListViewItem(myPlane.PlaneName);
            lvi.SubItems.Add(myPlane.FuelCapacity.ToString());
            lvi.SubItems.Add(myPlane.MaxSpeed.ToString());
            lvi.SubItems.Add(myPlane.MaxAltitude.ToString());
            lvi.SubItems.Add(mSearchLimit.ToString());
            lstPostRun.Items.Add(lvi);

            //string[] row = { myPlane.PlaneName, myPlane.FuelCapacity.ToString(), myPlane.MaxSpeed.ToString(), myPlane.MaxAltitude.ToString(), mSearchLimit.ToString() };
            //lstPostRun.Items.Clear();
            
            //ListViewItem item = new ListViewItem(row);

            //lstBombs.Items.Add(item);
           
        }
    }
}
