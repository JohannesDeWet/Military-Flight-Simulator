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
        string mySelectedBuilding = "";
        string selectedPlaneName = "";
        int mSearchLimit=0;
        List<string> myInventory = new List<string>();
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
            FillBuildingList();
            FillSpecific();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            myBuilding = mydatabase.GetBuildings();
            FillScreen();

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
        private void FillBuildingList() 
        {
            lstAllTargets.Items.Clear();
            foreach (var dr in myBuilding)
            {
                ListViewItem item = new ListViewItem(dr.BuildingName);

                lstAllTargets.Items.Add(item);
            }
        }
        private void FillSpecific()
        {
            int selected = GenerateUniqueNumbers(1, myBuilding.Count, -1)[0];
            mySelectedBuilding = myBuilding[selected].BuildingName;
            lstBuildingChosen.Items.Clear();
            ListViewItem item = new ListViewItem(mySelectedBuilding);

            lstBuildingChosen.Items.Add(item);
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
    }
}
