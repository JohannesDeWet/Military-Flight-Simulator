using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace PRG282_Project_LijaniVWDV_JohannesDW.Classes.Path_Finding_Classes
{
    interface IPathFinder
    {
        #region Event
        event PathFinderDebugHandler PathFinderDebug;
        #endregion


        #region Properties
        bool Stopped
        {
            get;
        }

        HeuristicFormula Formula
        {
            get;
            set;
        }

        bool Diagonals
        {
            get;
            set;
        }

        bool HeavyDiagonals
        {
            get;
            set;
        }

        int HeuristicEstimate
        {
            get;
            set;
        }

        int SearchLimit
        {
            get;
            set;
        }

        double CompletedTime
        {
            get;
            set;
        }

        bool DebugProgress
        {
            get;
            set;
        }

        bool DebugFoundPath
        {
            get;
            set;
        }
        #endregion

        void FindPathStop();

        List<PathFinderNode> FindPath(Point start, Point end);
    }
}
