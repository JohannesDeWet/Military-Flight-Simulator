using System;
using System.IO;
using System.Data;
using System.Text;
using System.Drawing;
using System.Threading;
using System.Collections;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;

using PRG282_Project_LijaniVWDV_JohannesDW.Classes.Path_Finding_Classes;
using System.Globalization;

namespace PRG282_Project_LijaniVWDV_JohannesDW.Forms
{
    public partial class MainSimScreen : Form
    {
        #region Constants
        private const string STOP = "Stop";
        private const string RUN = "Run";
        private const string PAUSE = "Pause";
        private const string CONTINUE = "Continue";

        private const string NODE_START = "Start";
        private const string NODE_END = "End";
        private const string NODE_X = "X";

        #endregion

        #region Variables
        private Thread mPFThread = null;                     //the thread for when the run button is clicked
        private IPathFinder mPathFinder = null;             //interface created in the Algorithms class
        private int mDelay;                                //this will be the speed of the plane at the end of the day
        private bool mPaused;
        private bool mRunning;
        private int mSearchLimit;
        private string selectedPlaneName;
        private int planeHP;
        private int planePayload;
        private int planeAlt;

        public static int globalAltitude;
        public static int globalAltitudeChosenPlane;
        #endregion

        #region Constructors
        public MainSimScreen()
        {
            InitializeComponent();
        }

        List<string> inventoryList = new List<string>();
        frmInventory frmIn = new frmInventory();

        public MainSimScreen(string planeName, int range, int hp, int payload, int speed, int alt)
        {
            selectedPlaneName = planeName;
            mSearchLimit = range;
            planeHP = hp;
            planePayload = payload;
            mDelay = speed;
            planeAlt = alt;
            globalAltitudeChosenPlane = planeAlt;

           
            InitializeComponent();

            frmReport rep = new frmReport(selectedPlaneName, range, inventoryList);
        }
        #endregion

        private delegate void PathFinderDebugDelegate(int parentX, int parentY, int x, int y, PathFinderNodeType type, int totalCost, int cost);
        private void PathFinderDebug(int parentX, int parentY, int x, int y, PathFinderNodeType type, int totalCost, int cost)
        {
            if (InvokeRequired)
            {
                Thread.Sleep(mDelay);
                Invoke(new PathFinderDebugDelegate(PathFinderDebug), new object[] { parentX, parentY, x, y, type, totalCost, cost });
                return;
            }

            ucGrid1.DrawDebug(parentX, parentY, x, y, type, totalCost, cost);
        }

        private delegate void BtnStartStop_ClickDelegate(object sender, EventArgs e);


        #region Methods

        public void WelcomeUser()
        {
            string welcomeMessage = "Welcome to the simulation screen! Here you will place the obstacles to navigate and then run the simulation. \n Enjoy!";

            MessageBox.Show(welcomeMessage, "Main Simulation Screen", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("Let's start with the obstacles. Just draw them on the grid.", "Main Simulation Screen", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cmbDrawMode.Focus();
            cmbDrawMode.SelectedIndex = 0;
        }

        public void Run()
        {
            ucGrid1.Refresh();

            //path finder thread
            mPFThread = new Thread(new ThreadStart(RunPathFinder));
            mPFThread.Name = "Path Finder Thread";
            mPFThread.Start();
        }

        public void Stop()
        {
            if (mPathFinder != null)
                mPathFinder.FindPathStop();

            mPFThread.Abort();
        }

        public void RunPathFinder()
        {
            if (ChkUseFastPathFinder.Checked)
            {
                if (!(mPathFinder is PathFinderFast))
                {
                    if (mPathFinder != null)
                        mPathFinder.PathFinderDebug -= new PathFinderDebugHandler(PathFinderDebug);

                    mPathFinder = new PathFinderFast(ucGrid1.Matrix);
                    mPathFinder.PathFinderDebug += new PathFinderDebugHandler(PathFinderDebug);
                }
            }
            else
            {
                if (!(mPathFinder is PathFinder))
                {
                    if (mPathFinder != null)
                        mPathFinder.PathFinderDebug -= new PathFinderDebugHandler(PathFinderDebug);

                    mPathFinder = new PathFinder(ucGrid1.Matrix);
                    mPathFinder.PathFinderDebug += new PathFinderDebugHandler(PathFinderDebug);
                }
            }

            mPathFinder.Formula = ucGrid1.Formula;
            mPathFinder.SearchLimit = (int)NumSearchLimit.Value;
            mPathFinder.DebugProgress = ChlShowProgress.Checked;
            mPathFinder.DebugFoundPath = true;

            List<PathFinderNode> path = mPathFinder.FindPath(ucGrid1.Start, ucGrid1.End);

            if (path == null  )
                MessageBox.Show("The plane could not reach the enemy base safely and had to abort mission.", "MISSION ABORTED", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            if (btnStartSimulation.Text == STOP)
                btnStartSimulation_Click(null, EventArgs.Empty);
        }


        public void DeterminAlt()
        {
            if (nrAltirude.Value > 15 && nrAltirude.Value <= 20)
            {
                ucGrid1.ObstacleAlt = ObstacleAltitude.High;
            }
            else if (nrAltirude.Value > 10 && nrAltirude.Value <= 15)
            {
                ucGrid1.ObstacleAlt = ObstacleAltitude.Medium;
            }
            else if (nrAltirude.Value <= 10)
            {
                ucGrid1.ObstacleAlt = ObstacleAltitude.Low;
            }

        }

        #endregion

        #region Events

        private void btnStartSimulation_Click(object sender, EventArgs e)
        {
            mSearchLimit = (int)NumSearchLimit.Value;

            mDelay = TBarSpeed.Value;

            if (InvokeRequired)
            {
                this.Invoke(new BtnStartStop_ClickDelegate(btnStartSimulation_Click), new object[] { sender, e });
                return;
            }

            if (!mRunning)
                Run();
            else
                Stop();
            mRunning = !mRunning;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDrawMode.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose the object you want to place");
            } 
            else if (cmbDrawMode.SelectedIndex == 1)
            {
                ucGrid1.DrawModeSetup = DrawModeSetup.Start;
                nrAltirude.Visible = false;
                lblHint.Visible = false;
                lblAltitude.Visible = false;
            }            
            else if (cmbDrawMode.SelectedIndex == 2)
            {
                ucGrid1.DrawModeSetup = DrawModeSetup.End;
                nrAltirude.Visible = false;
                lblHint.Visible = false;
                lblAltitude.Visible = false;
            }
            else if (cmbDrawMode.SelectedIndex == 0)
            {
                ucGrid1.NodeWeight = 0;
                ucGrid1.DrawModeSetup = DrawModeSetup.Block;

                nrAltirude.Visible = true;
                lblHint.Visible = true;
                lblAltitude.Visible = true;

                DeterminAlt(); 
                
            }
            else
            {
                ucGrid1.DrawModeSetup = DrawModeSetup.Block;

                nrAltirude.Visible = true;
                lblHint.Visible = true;
                lblAltitude.Visible = true;

                DeterminAlt();
            }
        }

        private void btnRefreshGrid_Click(object sender, EventArgs e)       // to clear the grid completely and start again
        {
            ucGrid1.ResetMatrix();
            ucGrid1.Invalidate();

            MessageBox.Show("Let's start with the obstacles. Just draw them on the grid.", "Main Simulation Screen", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cmbDrawMode.Focus();
            cmbDrawMode.SelectedIndex = 0;
        }

        #endregion

        private void ucGrid1_MouseDown(object sender, MouseEventArgs e)
        {
            DeterminAlt();      //to get the right color according to the altitude of the obstacle
        }

        private void btnSubmitObstacles_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you satisfied with your obstacles?",
                      "Confirm Submission", MessageBoxButtons.YesNo);

            switch (dr)
            {
                case DialogResult.Yes:
                    pnlPlaceObstacles.Visible = false;
                    grpbxRunSim.Visible = true;
                    panel1.Visible = true;
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to quit?",
                     "Confirm Exit", MessageBoxButtons.YesNo);

            switch (dr)
            {
                case DialogResult.Yes:
                    Environment.Exit(1);         // this throws an error ? I do not understand it
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            frmReport report = new frmReport();
            report.Show();
        }

        private void ucGrid1_Enter(object sender, EventArgs e)
        {
            globalAltitude = (int)nrAltirude.Value;
        }

        private void MainSimScreen_Load(object sender, EventArgs e)
        {

            inventoryList = frmIn.CreateListofInventoryBombItems();

            WelcomeUser();

            //making sure the user follows the right path of events
            grpbxRunSim.Visible = false;
            panel1.Visible = false;

            nrAltirude.Visible = true;
            lblHint.Visible = true;
            lblAltitude.Visible = true;

            lblPlaneName.Text = selectedPlaneName;
            lblPlaneAlt.Text += planeAlt.ToString();
            lblPlaneHP.Text += planeHP.ToString();
            lblPlanePayload.Text += planePayload.ToString();
            lblPlaneRange.Text += mSearchLimit.ToString();
            lblPlaneSpeed.Text += mDelay.ToString();

        }
    }
}
