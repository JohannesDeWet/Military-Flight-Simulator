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
        string selectedPlaneName = "";
        int mSearchLimit=0;
        public frmReport()
        {
            InitializeComponent();
        }
        public frmReport(string planeName, int range, List<string> inventory)
        {
            selectedPlaneName = planeName;
            mSearchLimit = range;
            InitializeComponent();
        }

        private void FillScreen() 
        {
        
        }
    }
}
