using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG282_Project_LijaniVWDV_JohannesDW.Forms
{
    public partial class MainSimScreen : Form
    {
        
        public MainSimScreen()
        {
            InitializeComponent();
            ucObstaclesDetected1.Hide();
            ucObstacles1.Show();
            

            //have to just make this so that the right user control show when necessary

        }

        
    }
}
