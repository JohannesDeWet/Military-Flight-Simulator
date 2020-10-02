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
using PRG282_Project_LijaniVWDV_JohannesDW.Classes.Path_Finding_Classes;

namespace PRG282_Project_LijaniVWDV_JohannesDW.Forms
{
    public partial class frmPlane : Form
    {
        private DatabaseDataHandler myDatabase = new DatabaseDataHandler();
        private List<Plane> myPlaneCollection = new List<Plane>();
        private List<string> myselectedBombs = new List<string>();
        private string myselectedPlane = "";
        private float myremainingRange = 0;
        private Bomb myBomb = new Bomb();

        public frmPlane()
        {
            InitializeComponent();
        }

        public frmPlane(List<string> myBombList, string selectedplanename, float rangeLeft)
        {
            myselectedBombs = myBombList;
            myselectedPlane = selectedplanename;
            myremainingRange = rangeLeft;
            InitializeComponent();
        }

        private void frmPlane_Load(object sender, EventArgs e)
        {
            myPlaneCollection = myDatabase.SelectAllPlanes();
            FillPlaneForm();
        }

        private void FillPlaneForm() 
        {
            List<PictureBox> myPicBox = new List<PictureBox> { pbPlane1, pbPlane2, pbPlane3, pbPlane4 };
            for (int i = 0; i < myPicBox.Count; i++)
            {
                myPicBox[i].ImageLocation = @"Resources\Images\Planes\" + myPlaneCollection[i].PlaneName + ".jpg";
            }
            fillAllLables();
        }

        private void fillAllLables() 
        {
            List<Label> myNameLable = new List<Label> { lblPlaneName1, lblPlaneName2, lblPlaneName3, lblPlaneName4 };
            for (int i = 0; i < myNameLable.Count; i++)
            {
                myNameLable[i].Text = myPlaneCollection[i].PlaneName;
            }
            List<Label> myTypeLable = new List<Label> { lblPlaneType1, lblPlaneType2, lblPlaneType3, lblPlaneType4 };
            for (int i = 0; i < myTypeLable.Count; i++)
            {
                myTypeLable[i].Text = myPlaneCollection[i].PlaneType;
            }
            List<Label> myAltitudeLable = new List<Label> { lblAltitude1, lblAltitude2, lblAltitude3, lblAltitude4 };
            for (int i = 0; i < myAltitudeLable.Count; i++)
            {
                myAltitudeLable[i].Text = myPlaneCollection[i].MaxAltitude.ToString();
            }
            List<Label> myRangeLable = new List<Label> { lblRange1, lblRange2, lblRange3, lblRange4 };
            for (int i = 0; i < myRangeLable.Count; i++)
            {
                myRangeLable[i].Text = myPlaneCollection[i].FuelCapacity.ToString();
            }
            List<Label> myHPLable = new List<Label> { lblHp1, lblHp2, lblHp3, lblHp4 };
            for (int i = 0; i < myHPLable.Count; i++)
            {
                myHPLable[i].Text = myPlaneCollection[i].PlaneHP.ToString();
            }
            List<Label> mySpeedLable = new List<Label> { lblSpeed1, lblSpeed2, lblSpeed3, lblSpeed4 };
            for (int i = 0; i < mySpeedLable.Count; i++)
            {
                mySpeedLable[i].Text = myPlaneCollection[i].MaxSpeed.ToString();
            }
            List<Label> myWeightLable = new List<Label> { lblWeight1, lblWeight2, lblWeight3, lblWeight4 };
            for (int i = 0; i < myWeightLable.Count; i++)
            {
                myWeightLable[i].Text = myPlaneCollection[i].Payload.ToString();
            }
            List<Label> myHardLable = new List<Label> { lblHardPoints1, lblHardPoints2, lblHardPoints3, lblHardPoints4 };
            for (int i = 0; i < myHardLable.Count; i++)
            {
                myHardLable[i].Text = myPlaneCollection[i].MountingPoints.ToString();
            }
        }

        private void btnInventorySelection1_Click(object sender, EventArgs e)
        {
            Hide();
            frmInventory myInventoryScreen = new frmInventory(myPlaneCollection[0].PlaneName, myPlaneCollection[0].Payload, myPlaneCollection[0].FuelCapacity, myPlaneCollection[0].MountingPoints);
            myInventoryScreen.ShowDialog();
            Close();
        }

        private void btnInventorySelection2_Click(object sender, EventArgs e)
        {
            Hide();
            frmInventory myInventoryScreen = new frmInventory(myPlaneCollection[1].PlaneName, myPlaneCollection[1].Payload, myPlaneCollection[1].FuelCapacity, myPlaneCollection[1].MountingPoints);
            myInventoryScreen.ShowDialog();
            Close();
        }

        private void btnInventorySelection3_Click(object sender, EventArgs e)
        {
            Hide();
            frmInventory myInventoryScreen = new frmInventory(myPlaneCollection[2].PlaneName, myPlaneCollection[2].Payload, myPlaneCollection[2].FuelCapacity, myPlaneCollection[2].MountingPoints);
            myInventoryScreen.ShowDialog();
            Close();
        }

        private void btnInventorySelection4_Click(object sender, EventArgs e)
        {
            Hide();
            frmInventory myInventoryScreen = new frmInventory(myPlaneCollection[3].PlaneName, myPlaneCollection[3].Payload, myPlaneCollection[3].FuelCapacity, myPlaneCollection[3].MountingPoints);
            myInventoryScreen.ShowDialog();
            Close();
        }


        
        private void btnSelectPlane1_Click(object sender, EventArgs e)
        {
            MainSimScreen mainscreen = new MainSimScreen(myPlaneCollection[0].PlaneName, myPlaneCollection[0].FuelCapacity, myPlaneCollection[0].PlaneHP, myPlaneCollection[0].Payload, myPlaneCollection[0].MaxSpeed, myPlaneCollection[0].MaxAltitude);
            
            
            mainscreen.ShowDialog();
        }

        private void btnSelectPlane2_Click(object sender, EventArgs e)
        {

        }

        private void btnSelectPlane3_Click(object sender, EventArgs e)
        {

        }

        private void btnSelectPlane4_Click(object sender, EventArgs e)
        {

        }
    }
}
