using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG282_Project_LijaniVWDV_JohannesDW.Forms.User_Control
{
    public partial class ucPlaneStats : UserControl
    {
        string selectedPlaneName;
        int mSearchLimit;
        int planeHP;
        int planePayload;

        public ucPlaneStats()
        {
            InitializeComponent();
        }

        public ucPlaneStats(string planeName, int range, int hp, int payload)
        {
            selectedPlaneName = planeName;
            mSearchLimit = range;
            planeHP = hp;
            planePayload = payload;
        }


    }
}
