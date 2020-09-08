﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG282_Project_LijaniVWDV_JohannesDW.Forms
{

    // here is a useful link
    // https://foxlearn.com/article/how-to-create-and-use-user-control-in-csharp-276.html

    //Declarations
    public enum DrawModeSetup
    {
        None = 0,
        Start = 1,
        End = 2,
        Block = 3
    }

    public enum PathFinderNodeType
    {
        Start = 1,
        End = 2,
        Open = 4,
        Close = 8,
        Current = 16,
        Path = 32
    }

    public partial class ucGrid : UserControl
    {

        private byte mNodeWeight = 1;
        private int mGridSize = 30;
        private byte[,] mMatrix = new byte[1024, 1024];
        private Point mStart = Point.Empty;
        private Point mEnd = Point.Empty;
        private DrawModeSetup mDrawMode = DrawModeSetup.None;
        //private HeuristicFormula mFormula = HeuristicFormula.Manhattan;

        //==================================================================================
        //Constructor

        public ucGrid()
        {
            InitializeComponent();
            ResetMatrix();
        }

        //==================================================================================
        //Properties

        public byte MNodeWeight { get => mNodeWeight; set => mNodeWeight = value; }
        public int MGridSize { get => mGridSize; set => mGridSize = value; }
        public byte[,] MMatrix { get => mMatrix; set => mMatrix = value; }
        public Point MStart { get => mStart; set => mStart = value; }
        public Point MEnd { get => mEnd; set => mEnd = value; }
        public DrawModeSetup MDrawMode { get => mDrawMode; set => mDrawMode = value; }


        //==================================================================================
        //Methods

        public void ResetMatrix()
        {
            for (int y = 0; y < mMatrix.GetUpperBound(1); y++)
                for (int x = 0; x < mMatrix.GetUpperBound(0); x++)
                {
                    mMatrix[x, y] = 1;
                }
                    
            mStart = Point.Empty;
            mEnd = Point.Empty;
        }

        public void DrawDebug(int parentX, int parentY, int x, int y, PathFinderNodeType type, int totalCost, int cost)
        {
            Color c = Color.Empty;
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
                case PathFinderNodeType.Path:
                    c = Color.Blue;
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
            catch (Exception) { }
        }


        //======================================================================================\
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

                        // Lets render the obstacules
                        Color color = Color.Empty;
                        if (mMatrix[sx, sy] != 0)
                        {
                            int colorIndex = 240 - ((int)(Math.Log10(mMatrix[sx, sy]) * 127));
                            colorIndex = colorIndex < 0 ? 0 : colorIndex > 255 ? 255 : colorIndex;
                            color = Color.FromArgb(255, colorIndex, colorIndex, colorIndex);
                        }
                        else
                            color = Color.Olive;

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

        //protected override void OnMouseMove(MouseEventArgs e)
        //{
        //    if (e.Button == MouseButtons.None || mDrawMode == DrawModeSetup.None)
        //        return;

        //    int x = e.X / mGridSize;
        //    int y = e.Y / mGridSize;

        //    switch (mDrawMode)
        //    {
        //        case DrawModeSetup.Start:
        //            this.Invalidate(new Rectangle(mStart.X * mGridSize, mStart.Y * mGridSize, mGridSize, mGridSize));
        //            mStart = new Point(x, y);
        //            mMatrix[x, y] = 1;
        //            break;
        //        case DrawModeSetup.End:
        //            this.Invalidate(new Rectangle(mEnd.X * mGridSize, mEnd.Y * mGridSize, mGridSize, mGridSize));
        //            mEnd = new Point(x, y);
        //            mMatrix[x, y] = 1;
        //            break;
        //        case DrawModeSetup.Block:
        //            if (e.Button == (MouseButtons.Left | MouseButtons.Right))
        //                mMatrix[x, y] = (byte)(mMatrix[x, y] - mNodeWeight > 1 ? mMatrix[x, y] - mNodeWeight : 1);
        //            else if (e.Button == MouseButtons.Left)
        //                mMatrix[x, y] = mNodeWeight;
        //            else if (e.Button == MouseButtons.Right)
        //                mMatrix[x, y] = (byte)(mMatrix[x, y] + mNodeWeight < 256 ? mMatrix[x, y] + mNodeWeight : 255);
        //            break;
        //    }

        //    this.Invalidate(new Rectangle(x * mGridSize, y * mGridSize, mGridSize, mGridSize));
        //    base.OnMouseMove(e);
        //}

        //protected override void OnMouseDown(MouseEventArgs e)
        //{
        //    this.OnMouseMove(e);
        //    base.OnMouseDown(e);
        //}
    }
}
