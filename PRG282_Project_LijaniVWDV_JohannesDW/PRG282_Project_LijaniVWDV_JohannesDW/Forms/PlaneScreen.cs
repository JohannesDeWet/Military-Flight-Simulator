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
    public partial class frmPlane : Form
    {
        DatabaseDataHandler myDatabase = new DatabaseDataHandler();
        List<Plane> myPlaneCollection = new List<Plane>(); 
        public frmPlane()
        {
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

            List<Label> myLable = new List<Label> { txtPlaneName1, txtPlaneName2, txtPlaneName3, txtPlaneName4 };
            for (int i = 0; i < myPicBox.Count; i++)
            {
                myLable[i].Text = myPlaneCollection[i].PlaneName;
            }

        }

        private void btnInventorySelection_Click(object sender, EventArgs e)
        {
            Hide();
            InventoryScreen myInvertoryScreen = new InventoryScreen();
            //myChallegngeTwo.SharedInformaiton(myGame.Multiplayer, myGame.CurrentPlayer, myGame.Player1Name, myGame.Player2Name, myGame.Player1Score, myGame.Player2Score);
            myInvertoryScreen.ShowDialog();
            Close();
        }
    }
}
