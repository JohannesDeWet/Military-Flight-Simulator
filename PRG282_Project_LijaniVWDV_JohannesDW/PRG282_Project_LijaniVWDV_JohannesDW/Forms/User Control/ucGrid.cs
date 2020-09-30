using System;
using System.Data;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;

using PRG282_Project_LijaniVWDV_JohannesDW.Classes.Path_Finding_Classes;
using PRG282_Project_LijaniVWDV_JohannesDW.Forms;

namespace PRG282_Project_LijaniVWDV_JohannesDW.Forms
{

    // here are useful links I found
    // https://foxlearn.com/article/how-to-create-and-use-user-control-in-csharp-276.html
    // https://dotnetcoretutorials.com/2020/07/25/a-search-pathfinding-algorithm-in-c/

    #region enums
    public enum DrawModeSetup
    {
        None = 0,
        Start = 1,
        End = 2,
        Block = 3,
        PassOver = 4
    }

    public enum ObstacleAltitude
    {
        Low = 30,
        Medium = 50,
        High = 100
    }
    #endregion

    public partial class ucGrid : UserControl
    {

        #region Variables
        public int planeAlt = 54; // this will be the max altitude of the chosen plane

        private byte mNodeWeight = 1;
        private int mGridSize = 20;
        private byte[,] mMatrix = new byte[1024, 1024];
        private Point mStart = Point.Empty;
        private Point mEnd = Point.Empty;
        private DrawModeSetup mDrawMode = DrawModeSetup.None;
        private HeuristicFormula mFormula = HeuristicFormula.Manhattan;
        private ObstacleAltitude mAlt = ObstacleAltitude.Low;
        #endregion

        #region Properties
        public ObstacleAltitude ObstacleAlt 
        {
            get { return mAlt; }
            set { mAlt = value; } 
        }

        public byte[,] Matrix
        {
            get { return mMatrix; }
        }

        public int GridSize
        {
            get { return mGridSize; }
            set
            {
                mGridSize = value;
                Invalidate();
            }
        }

        public DrawModeSetup DrawModeSetup
        {
            get { return mDrawMode; }
            set { mDrawMode = value; }
        }

        public byte NodeWeight
        {
            get { return mNodeWeight; }
            set { mNodeWeight = value; }
        }

        public Point Start
        {
            get { return mStart; }
            set { mStart = value; }
        }

        public Point End
        {
            get { return mEnd; }
            set { mEnd = value; }
        }

        public HeuristicFormula Formula
        {
            get { return mFormula; }
            set { mFormula = value; }
        }

        #endregion

        #region Constructors
        public ucGrid()
        {
            InitializeComponent();

            ResetMatrix();

        }
        #endregion

        #region Methods
        public void ResetMatrix()
        {
            for (int y = 0; y < mMatrix.GetUpperBound(1); y++)
                for (int x = 0; x < mMatrix.GetUpperBound(0); x++)
                    mMatrix[x, y] = 1;

            mStart = Point.Empty;
            mEnd = Point.Empty;

        }

        public void DrawDebug(int parentX, int parentY, int x, int y, PathFinderNodeType type, int totalCost, int cost)
        {
            Color c = new Color();//.Empty;
            switch (type)
            {
                case PathFinderNodeType.Close:
                    c = Color.DarkSlateBlue;
                    break;
                case PathFinderNodeType.Current:
                    c = Color.Red;
                    break;
                case PathFinderNodeType.End:
                    c = Color.Red;
                    break;
                case PathFinderNodeType.Open:
                    c = Color.Green;
                    break;
                case PathFinderNodeType.Path:       //the final path identified
                    c = Color.Yellow;
                    break;
                case PathFinderNodeType.Start:
                    c = Color.Green;
                    break;
            }
            try
            {
                Graphics g = Graphics.FromHwnd(this.Handle);

                Rectangle internalRec = new Rectangle((x * mGridSize) + 2, (y * mGridSize) + 2, mGridSize - 4, mGridSize - 4);

                if (type == PathFinderNodeType.Open)
                    using (Brush brush = new SolidBrush(Color.FromArgb(255, 240, 240, 240)))
                        g.FillRectangle(brush, internalRec);

                using (Pen pen = new Pen(c))
                    g.DrawRectangle(pen, internalRec);

                if (type == PathFinderNodeType.Open)
                    g.DrawLine(Pens.Brown, (parentX * mGridSize) + mGridSize / 2, (parentY * mGridSize) + mGridSize / 2, (x * mGridSize) + mGridSize / 2, (y * mGridSize) + mGridSize / 2);

                if (type == PathFinderNodeType.Path)
                    using (Brush brush = new SolidBrush(c))
                        g.FillRectangle(brush, internalRec);

                if (totalCost != -1)
                {
                    internalRec.Inflate(new Size(1, 1));
                    internalRec.Height /= 2;
                    g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
                    using (Font f = new System.Drawing.Font("Verdana", 0.29F * mGridSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))))
                        g.DrawString(totalCost.ToString(), f, Brushes.Black, (RectangleF)internalRec);
                    internalRec.Y += internalRec.Height;
                    using (Font f = new System.Drawing.Font("Verdana", 0.29F * mGridSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))))
                        g.DrawString(cost.ToString(), f, Brushes.Black, (RectangleF)internalRec);
                }

                g.Dispose();
            }
            catch (Exception e) 
            {
                MessageBox.Show("Unable to process. " + e.Message);
            }
        }

       public Color GetColor()
        {
            Color c = new Color();

            switch (ObstacleAlt)
            {
                case ObstacleAltitude.Low:
                    c = Color.Orange;
                    break;

                case ObstacleAltitude.Medium:
                    c = Color.Blue;
                    break;

                case ObstacleAltitude.High:
                    c = Color.Black;
                    break;

                default:
                    c = Color.DarkGray;
                    break;
            }

            if (mDrawMode == DrawModeSetup.PassOver)
            {
                c = Color.Aqua;
            }

            return c;
        }

        #endregion  

        #region Overrides
        // These overrides are for drawing on the grid, and for rendering it for the pathfinding
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (mMatrix != null)
            {
                for (int y = (e.ClipRectangle.Y / mGridSize) * mGridSize; y <= e.ClipRectangle.Bottom; y += mGridSize)
                    for (int x = (e.ClipRectangle.X / mGridSize) * mGridSize; x <= e.ClipRectangle.Right; x += mGridSize)
                    {
                        int sx = x / mGridSize;
                        int sy = y / mGridSize;

                        // Lets render the obstacles
                        Color color = Color.Empty;

                        if (mDrawMode == DrawModeSetup.PassOver)
                        {
                            color = GetColor();
                        }

                         if (mMatrix[sx, sy] != 0 )
                        {
                            //We placed a map as the background of ucGrid and no longer need the below code.
                            //if an image is not used as the background, the below code is necessary

                            //int colorIndex = 240 - ((int)(Math.Log10(mMatrix[sx, sy]) * 127));
                            //colorIndex = colorIndex < 0 ? 0 : colorIndex > 255 ? 255 : colorIndex;
                            //color = Color.FromArgb(255, colorIndex, colorIndex, colorIndex);                  
                            
                        }
                        else
                        {
                            color = GetColor();      //the colour of the blocks being drawn
                        }


                        using (SolidBrush brush = new SolidBrush(color))
                            g.FillRectangle(brush, x, y, mGridSize, mGridSize);

                        //Lets render start and end
                        if (sx == mStart.X && sy == mStart.Y)
                            using (SolidBrush brush = new SolidBrush(Color.Green))
                                g.FillRectangle(brush, x, y, mGridSize, mGridSize);

                        if (sx == mEnd.X && sy == mEnd.Y)
                            using (SolidBrush brush = new SolidBrush(Color.Red))
                                g.FillRectangle(brush, x, y, mGridSize, mGridSize);
                    }
            }
            

            Color c = Color.Black;
            using (Pen pen = new Pen(c))
            {
                for (int y = (e.ClipRectangle.Y / mGridSize) * mGridSize; y <= e.ClipRectangle.Bottom; y += mGridSize)
                    g.DrawLine(pen, e.ClipRectangle.X, y, e.ClipRectangle.Right, y);

                for (int x = (e.ClipRectangle.X / mGridSize) * mGridSize; x <= e.ClipRectangle.Right; x += mGridSize)
                    g.DrawLine(pen, x, e.ClipRectangle.Y, x, e.ClipRectangle.Bottom);
            }

            base.OnPaint(e);
        }


        protected override void OnMouseMove(MouseEventArgs e)
        {
            //If no mode is chosen or if no mouse button is being clicked
            if (e.Button == MouseButtons.None || mDrawMode == DrawModeSetup.None)
                return;

            int x = e.X / mGridSize;
            int y = e.Y / mGridSize;

            switch (mDrawMode)      //to determine which block type is being used/drawn
            {
                case DrawModeSetup.Start:
                    this.Invalidate(new Rectangle(mStart.X * mGridSize, mStart.Y * mGridSize, mGridSize, mGridSize));
                    mStart = new Point(x, y);
                    mMatrix[x, y] = 1;
                    break;
                case DrawModeSetup.End:
                    this.Invalidate(new Rectangle(mEnd.X * mGridSize, mEnd.Y * mGridSize, mGridSize, mGridSize));
                    mEnd = new Point(x, y);
                    mMatrix[x, y] = 1;
                    break;
                case DrawModeSetup.Block:
                    //MessageBox.Show(MainSimScreen.planealtitude.ToString(), planeAlt.ToString()) ;
                    try
                    {
                        if (e.Button == (MouseButtons.Left | MouseButtons.Right)) //erases the obstacles drawn 
                            mMatrix[x, y] = (byte)(mMatrix[x, y] - mNodeWeight > 1 ? mMatrix[x, y] - mNodeWeight : 1);
                        else if (e.Button == MouseButtons.Left)
                            DeterminePass(mMatrix,x,y, MainSimScreen.planealtitude);
                            //mMatrix[x, y] = mNodeWeight;
                        else if (e.Button == MouseButtons.Right)
                            mMatrix[x, y] = (byte)(mMatrix[x, y] + mNodeWeight < 256 ? mMatrix[x, y] + mNodeWeight : 255);
                        
                    }
                    catch (Exception mess)
                    {
                        MessageBox.Show("Out of bounds!" + mess.Message);
                    }
                    break;

                case DrawModeSetup.PassOver:
                    if (e.Button == MouseButtons.Left)
                        DeterminePass(mMatrix, x, y, MainSimScreen.planealtitude);
                    break;

            }

            this.Invalidate(new Rectangle(x * mGridSize, y * mGridSize, mGridSize, mGridSize));
            base.OnMouseMove(e);
        }


        protected override void OnMouseDown(MouseEventArgs e)
        {
            this.OnMouseMove(e);
            base.OnMouseDown(e);
        }

        

        public void DeterminePass(byte[,] matrix, int x, int y, int altitude)
        {

            if (planeAlt > altitude)
            {
                mDrawMode = DrawModeSetup.PassOver;
                mMatrix[x, y] = (byte)(mMatrix[x, y] - mNodeWeight > 1 ? mMatrix[x, y] - mNodeWeight : 1); //causes nodeweight to be 1
            }
            else
            {
                matrix[x, y] = mNodeWeight; // nodeweight is equal to 0
            }

        }
        #endregion
    }
}
