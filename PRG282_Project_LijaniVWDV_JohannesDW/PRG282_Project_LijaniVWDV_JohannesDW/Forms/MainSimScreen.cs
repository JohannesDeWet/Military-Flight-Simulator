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
        private Thread mPFThread = null;         //the thread for when the run button is clicked
        private IPathFinder mPathFinder = null;         //interface created in the Algorithms class
        private int mDelay;
        private bool mPaused;
        private bool mRunning;

        public MainSimScreen()
        {
            InitializeComponent();
            ucObstaclesDetected1.Hide();
            ucObstacles1.Show();
            

            //have to just make this so that the right user control show when necessary

        }

        private delegate void PathFinderDebugDelegate(int parentX, int parentY, int x, int y, PathFinderNodeType type, int totalCost, int cost);
        private void PathFinderDebug(int parentX, int parentY, int x, int y, PathFinderNodeType type, int totalCost, int cost)
        {
            if (InvokeRequired)
            {
                while (mPaused)
                    Thread.Sleep(100);

                Thread.Sleep(mDelay);
                Invoke(new PathFinderDebugDelegate(PathFinderDebug), new object[] { parentX, parentY, x, y, type, totalCost, cost });
                return;
            }

            ucGrid1.DrawDebug(parentX, parentY, x, y, type, totalCost, cost);
        }

        private delegate void BtnStartStop_ClickDelegate(object sender, EventArgs e);

        private void btnStartSimulation_Click(object sender, EventArgs e)
        {
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

        public void Run()
        {
            ucGrid1.Refresh();
            //BtnStartStop.Text = STOP;
            ToolStrp.Enabled = false;
            //PnlSettings.Enabled = false;
            //BtnPause.Enabled = true;


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

           // mPaused = false;
           // BtnStartStop.Text = RUN;
           // BtnPause.Text = PAUSE;
           // ToolStrp.Enabled = true;
           // PnlSettings.Enabled = true;
           // BtnPause.Enabled = false;
        }

        public void RunPathFinder()
        {
            //if (ChkUseFastPathFinder.Checked)
            //{
            //    if (!(mPathFinder is PathFinderFast))
            //    {
            //        if (mPathFinder != null)
            //            mPathFinder.PathFinderDebug -= new PathFinderDebugHandler(PathFinderDebug);

            //        mPathFinder = new PathFinderFast(PnlGUI.Matrix);
            //        mPathFinder.PathFinderDebug += new PathFinderDebugHandler(PathFinderDebug);
            //    }
            //}
            //else
            //{
                if (!(mPathFinder is PathFinder))
                {
                    if (mPathFinder != null)
                        mPathFinder.PathFinderDebug -= new PathFinderDebugHandler(PathFinderDebug);

                    mPathFinder = new PathFinder(ucGrid1.Matrix);
                    mPathFinder.PathFinderDebug += new PathFinderDebugHandler(PathFinderDebug);
                }
            //}

            mPathFinder.Formula = ucGrid1.Formula;
            //mPathFinder.Diagonals = ChkDiagonals.Checked;
            //mPathFinder.HeavyDiagonals = ChkHeavyDiagonals.Checked;
            //mPathFinder.HeuristicEstimate = (int)NumUpDownHeuristic.Value;
            //mPathFinder.PunishChangeDirection = ChkPunishChangeDirection.Checked;
            //mPathFinder.TieBreaker = ChkTieBraker.Checked;
            //mPathFinder.SearchLimit = (int)NumSearchLimit.Value;
            //mPathFinder.DebugProgress = ChlShowProgress.Checked;
            //mPathFinder.ReopenCloseNodes = ChkReopenCloseNodes.Checked;
            mPathFinder.DebugFoundPath = true;

            List<PathFinderNode> path = mPathFinder.FindPath(ucGrid1.Start, ucGrid1.End);
            //UpdateTimeLabel(mPathFinder.CompletedTime);

            if (path == null)
                MessageBox.Show("Path Not Found");

            //if (BtnStartStop.Text == STOP)
            //    BtnStartStop_Click(null, EventArgs.Empty);
        }

    }
}
