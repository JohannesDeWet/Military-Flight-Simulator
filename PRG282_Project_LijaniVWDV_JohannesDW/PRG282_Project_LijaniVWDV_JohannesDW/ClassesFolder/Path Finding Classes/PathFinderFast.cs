﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace PRG282_Project_LijaniVWDV_JohannesDW.Classes.Path_Finding_Classes
{
    public class PathFinderFast : IPathFinder
    {

        internal struct PathFinderNodeFast
        {
            public int F; // f = gone + heuristic
            public int G;
            public ushort PX; // Parent
            public ushort PY;
            public byte Status;
        }

        public event PathFinderDebugHandler PathFinderDebug;

        #region Variables
        private byte[,] mGrid = null;
        private PriorityQueueB<int> mOpen = null;
        private List<PathFinderNode> mClose = new List<PathFinderNode>();
        private bool mStop = false;
        private bool mStopped = true;
        //private int mHoriz = 0;
        private HeuristicFormula mFormula = HeuristicFormula.Manhattan;
        private bool mDiagonals = true;
        private int mHEstimate = 2;
        private bool mPunishChangeDirection = false;
        private bool mReopenCloseNodes = true;
        private bool mTieBreaker = false;
        private bool mHeavyDiagonals = false;
        private int mSearchLimit = 2000;
        private double mCompletedTime = 0;
        private bool mDebugProgress = false;
        private bool mDebugFoundPath = false;
        private PathFinderNodeFast[] mCalcGrid = null;
        private byte mOpenNodeValue = 1;
        private byte mCloseNodeValue = 2;

        public static int travelled;

        //Promoted local variables to member variables to avoid recreation between calls
        private int mH = 0;
        private int mLocation = 0;
        private int mNewLocation = 0;
        private ushort mLocationX = 0;
        private ushort mLocationY = 0;
        private ushort mNewLocationX = 0;
        private ushort mNewLocationY = 0;
        private int mCloseNodeCounter = 0;
        private ushort mGridX = 0;
        private ushort mGridY = 0;
        private ushort mGridXMinus1 = 0;
        private ushort mGridYLog2 = 0;
        private bool mFound = false;
        private sbyte[,] mDirection = new sbyte[8, 2] { { 0, -1 }, { 1, 0 }, { 0, 1 }, { -1, 0 }, { 1, -1 }, { 1, 1 }, { -1, 1 }, { -1, -1 } };
        private int mEndLocation = 0;
        private int mNewG = 0;
        #endregion

        #region Properties
        public bool Stopped
        {
            get { return mStopped; }
        }

        public HeuristicFormula Formula
        {
            get { return mFormula; }
            set { mFormula = value; }
        }

        public bool Diagonals
        {
            get { return mDiagonals; }
            set
            {
                mDiagonals = value;
                if (mDiagonals)
                    mDirection = new sbyte[8, 2] { { 0, -1 }, { 1, 0 }, { 0, 1 }, { -1, 0 }, { 1, -1 }, { 1, 1 }, { -1, 1 }, { -1, -1 } };
                else
                    mDirection = new sbyte[4, 2] { { 0, -1 }, { 1, 0 }, { 0, 1 }, { -1, 0 } };
            }
        }

        public bool HeavyDiagonals
        {
            get { return mHeavyDiagonals; }
            set { mHeavyDiagonals = value; }
        }

        public int HeuristicEstimate
        {
            get { return mHEstimate; }
            set { mHEstimate = value; }
        }

        public bool PunishChangeDirection
        {
            get { return mPunishChangeDirection; }
            set { mPunishChangeDirection = value; }
        }

        public bool ReopenCloseNodes
        {
            get { return mReopenCloseNodes; }
            set { mReopenCloseNodes = value; }
        }

        public bool TieBreaker
        {
            get { return mTieBreaker; }
            set { mTieBreaker = value; }
        }

        public int SearchLimit
        {
            get { return mSearchLimit; }
            set { mSearchLimit = value; }
        }

        public double CompletedTime
        {
            get { return mCompletedTime; }
            set { mCompletedTime = value; }
        }

        public bool DebugProgress
        {
            get { return mDebugProgress; }
            set { mDebugProgress = value; }
        }

        public bool DebugFoundPath
        {
            get { return mDebugFoundPath; }
            set { mDebugFoundPath = value; }
        }
        #endregion

        public PathFinderFast(byte[,] grid)
        {
            if (grid == null)
                throw new Exception("Grid cannot be null");

            mGrid = grid;
            mGridX = (ushort)(mGrid.GetUpperBound(0) + 1);
            mGridY = (ushort)(mGrid.GetUpperBound(1) + 1);
            mGridXMinus1 = (ushort)(mGridX - 1);
            mGridYLog2 = (ushort)Math.Log(mGridY, 2);

            // This should be done at the constructor, for now we leave it here.
            if (Math.Log(mGridX, 2) != (int)Math.Log(mGridX, 2) ||
                Math.Log(mGridY, 2) != (int)Math.Log(mGridY, 2))
                throw new Exception("Invalid Grid, size in X and Y must be power of 2");

            if (mCalcGrid == null || mCalcGrid.Length != (mGridX * mGridY))
                mCalcGrid = new PathFinderNodeFast[mGridX * mGridY];

            mOpen = new PriorityQueueB<int>(new ComparePFNodeMatrix(mCalcGrid));
        }

        public PathFinderFast()
        {

        }

        #region Internal Class
        internal class ComparePFNodeMatrix : IComparer<int>
        {
            #region Variables Declaration
            PathFinderNodeFast[] mMatrix;
            #endregion

            #region Constructors
            public ComparePFNodeMatrix(PathFinderNodeFast[] matrix)
            {
                mMatrix = matrix;
            }
            #endregion

            #region IComparer Members
            public int Compare(int a, int b)
            {
                if (mMatrix[a].F > mMatrix[b].F)
                    return 1;
                else if (mMatrix[a].F < mMatrix[b].F)
                    return -1;
                return 0;
            }
            #endregion
        }
        #endregion

        public void FindPathStop()
        {
            mStop = true;
        }

        public List<PathFinderNode> FindPath(Point start, Point end)
        {
            lock (this)
            {

                mFound = false;
                mStop = false;
                mCloseNodeCounter = 0;
                mOpenNodeValue += 2;
                mCloseNodeValue += 2;
                mOpen.Clear();
                mClose.Clear();

               
                //to get the start and end node
                if (mDebugProgress && PathFinderDebug != null)
                    PathFinderDebug(0, 0, start.X, start.Y, PathFinderNodeType.Start, -1, -1);      //get start
                if (mDebugProgress && PathFinderDebug != null)
                    PathFinderDebug(0, 0, end.X, end.Y, PathFinderNodeType.End, -1, -1);            //get end
              

                mLocation = (start.Y << mGridYLog2) + start.X;
                mEndLocation = (end.Y << mGridYLog2) + end.X;
                mCalcGrid[mLocation].G = 0;
                mCalcGrid[mLocation].F = mHEstimate;
                mCalcGrid[mLocation].PX = (ushort)start.X;
                mCalcGrid[mLocation].PY = (ushort)start.Y;
                mCalcGrid[mLocation].Status = mOpenNodeValue;

                mOpen.Push(mLocation);

                while (mOpen.Count > 0 )
                {
                    mLocation = mOpen.Pop();

                    //Is it in closed list? means this node was already processed
                    if (mCalcGrid[mLocation].Status == mCloseNodeValue)
                        continue;

                    mLocationX = (ushort)(mLocation & mGridXMinus1);
                    mLocationY = (ushort)(mLocation >> mGridYLog2);


                    if (mDebugProgress && PathFinderDebug != null)
                        PathFinderDebug(0, 0, mLocation & mGridXMinus1, mLocation >> mGridYLog2, PathFinderNodeType.Current, -1, -1);

                    // when the pathfinder finds the last block (i.e. the end)
                    if (mLocation == mEndLocation)      
                    {
                        mCalcGrid[mLocation].Status = mCloseNodeValue;
                        mFound = true;
                        break;
                    }

                    // this will have to do with the fuel limits of the plane (thwew and back)
                    if (mCloseNodeCounter > mSearchLimit/2)       
                    {
                        mStopped = true;
                        //mCompletedTime = HighResolutionTime.GetTime();
                        return null;
                    }

                    //Lets calculate each successors
                    for (int i = 0; i < (mDiagonals ? 8 : 4); i++)
                    {
                        mNewLocationX = (ushort)(mLocationX + mDirection[i, 0]);
                        mNewLocationY = (ushort)(mLocationY + mDirection[i, 1]);
                        mNewLocation = (mNewLocationY << mGridYLog2) + mNewLocationX;

                        if (mNewLocationX >= mGridX || mNewLocationY >= mGridY)
                            continue;

                        if (mCalcGrid[mNewLocation].Status == mCloseNodeValue && !mReopenCloseNodes)
                            continue;

                        // Unbreakeable?
                        if (mGrid[mNewLocationX, mNewLocationY] == 0) {
                            continue;
                        }
                         

                        //Is it open or closed?
                        if (mCalcGrid[mNewLocation].Status == mOpenNodeValue || mCalcGrid[mNewLocation].Status == mCloseNodeValue)
                        {
                            // The current node has less code than the previous? then skip this node
                            if (mCalcGrid[mNewLocation].G <= mNewG)
                                continue;
                        }
                        

                        mCalcGrid[mNewLocation].PX = mLocationX;
                        mCalcGrid[mNewLocation].PY = mLocationY;
                        mCalcGrid[mNewLocation].G = mNewG;

                        mH = mHEstimate * (Math.Abs(mNewLocationX - end.X) + Math.Abs(mNewLocationY - end.Y));


                        mCalcGrid[mNewLocation].F = mNewG + mH;


                        if (mDebugProgress && PathFinderDebug != null)
                            PathFinderDebug(mLocationX, mLocationY, mNewLocationX, mNewLocationY, PathFinderNodeType.Open, mCalcGrid[mNewLocation].F, mCalcGrid[mNewLocation].G);

                        mOpen.Push(mNewLocation);
                        
                        mCalcGrid[mNewLocation].Status = mOpenNodeValue;
                    }

                    mCloseNodeCounter++;
                    mCalcGrid[mLocation].Status = mCloseNodeValue;


                    if (mDebugProgress && PathFinderDebug != null)
                        PathFinderDebug(0, 0, mLocationX, mLocationY, PathFinderNodeType.Close, mCalcGrid[mLocation].F, mCalcGrid[mLocation].G);

                }

                

                // PATHFINDER HAS REACHED THE END NODE

                if (mFound)
                {
                    
                    mClose.Clear();
                    int posX = end.X;
                    int posY = end.Y;

                    PathFinderNodeFast fNodeTmp = mCalcGrid[(end.Y << mGridYLog2) + end.X];
                    PathFinderNode fNode;
                    fNode.F = fNodeTmp.F;
                    fNode.G = fNodeTmp.G;
                    fNode.H = 0;
                    fNode.PX = fNodeTmp.PX;
                    fNode.PY = fNodeTmp.PY;
                    fNode.X = end.X;
                    fNode.Y = end.Y;

                    while (fNode.X != fNode.PX || fNode.Y != fNode.PY)      //adding the final path
                    {
                        mClose.Add(fNode);

                        if (mDebugFoundPath && PathFinderDebug != null)
                            PathFinderDebug(fNode.PX, fNode.PY, fNode.X, fNode.Y, PathFinderNodeType.Path, fNode.F, fNode.G);

                        posX = fNode.PX;
                        posY = fNode.PY;
                        fNodeTmp = mCalcGrid[(posY << mGridYLog2) + posX];
                        fNode.F = fNodeTmp.F;
                        fNode.G = fNodeTmp.G;
                        fNode.H = 0;
                        fNode.PX = fNodeTmp.PX;
                        fNode.PY = fNodeTmp.PY;
                        fNode.X = posX;
                        fNode.Y = posY;
                    }

                    mClose.Add(fNode);

                    if (mDebugFoundPath && PathFinderDebug != null)
                        PathFinderDebug(fNode.PX, fNode.PY, fNode.X, fNode.Y, PathFinderNodeType.Path, fNode.F, fNode.G);


                    mStopped = true;
                    return mClose;
                }
                mStopped = true;
                return null;
            }
        }

        public int ReturnNodeCount()
        {
            return mCloseNodeCounter;
        }

        public void CheckAltitude()
        {
            Point p = new Point(mGrid[mNewLocationX, mNewLocationY]);

            

            if (mGrid[mNewLocationX, mNewLocationY] == 0)
            {
                MessageBox.Show("");
            }

        }

    }
}
