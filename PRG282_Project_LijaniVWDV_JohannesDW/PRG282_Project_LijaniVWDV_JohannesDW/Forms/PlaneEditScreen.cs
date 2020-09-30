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
    public partial class frmPlaneEdit : Form
    {
        private List<Plane> myPlaneCollection = new List<Plane>();
        private DatabaseDataHandler myDatabase = new DatabaseDataHandler();
        private List<string> myselectedBombs = new List<string>();

        public frmPlaneEdit()
        {
            InitializeComponent();
        }

        private void frmPlaneEdit_Load(object sender, EventArgs e)
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
            List<TextBox> myAltitudeLable = new List<TextBox> { txtAlittude1, txtAlittude2, txtAlittude3, txtAlittude4 };
            for (int i = 0; i < myAltitudeLable.Count; i++)
            {
                myAltitudeLable[i].Text = myPlaneCollection[i].MaxAltitude.ToString();
            }
            List<TextBox> myRangeLable = new List<TextBox> { txtRange1, txtRange2, txtRange3, txtRange4 };
            for (int i = 0; i < myRangeLable.Count; i++)
            {
                myRangeLable[i].Text = myPlaneCollection[i].FuelCapacity.ToString();
            }
            List<TextBox> myHPLable = new List<TextBox> { txtHp1, txtHp2, txtHp3, txtHp4 };
            for (int i = 0; i < myHPLable.Count; i++)
            {
                myHPLable[i].Text = myPlaneCollection[i].PlaneHP.ToString();
            }
            List<TextBox> mySpeedLable = new List<TextBox> { txtSpeed1, txtSpeed2, txtSpeed3, txtSpeed4 };
            for (int i = 0; i < mySpeedLable.Count; i++)
            {
                mySpeedLable[i].Text = myPlaneCollection[i].MaxSpeed.ToString();
            }
            List<TextBox> myWeightLable = new List<TextBox> { txtWeight1, txtWeight2, txtWeight3, txtWeight4 };
            for (int i = 0; i < myWeightLable.Count; i++)
            {
                myWeightLable[i].Text = myPlaneCollection[i].Payload.ToString();
            }
            List<TextBox> myHardLable = new List<TextBox> { txtHardPoints1, txtHardPoints2, txtHardPoints3, txtHardPoints4 };
            for (int i = 0; i < myHardLable.Count; i++)
            {
                myHardLable[i].Text = myPlaneCollection[i].MountingPoints.ToString();
            }
        }

        private void btnEditPllane1_Click(object sender, EventArgs e)
        {
            myDatabase.EditPlanes(myPlaneCollection[0].PlaneID,Convert.ToInt32(txtHp1.Text), Convert.ToInt32(txtAlittude1.Text), Convert.ToInt32(txtWeight1.Text), Convert.ToInt32(txtSpeed1.Text), Convert.ToInt32(txtRange1.Text), Convert.ToInt32(txtHardPoints1.Text));
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            Hide();
            frmLoginScreen myLoginScreen = new frmLoginScreen();
            myLoginScreen.ShowDialog();
            Close();
        }
    }
}
