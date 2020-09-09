using System;
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

    // here are useful links I found
    // https://foxlearn.com/article/how-to-create-and-use-user-control-in-csharp-276.html
    // https://dotnetcoretutorials.com/2020/07/25/a-search-pathfinding-algorithm-in-c/



    public partial class ucGrid : UserControl
    {
        public ucGrid()
        {
            InitializeComponent();
        }

        private byte[,] mMatrix = new byte[1024, 1024];
        private int mGridSize = 30;
        private byte mNodeWeight = 1;

        public byte[,] Matrix
        {
            get { return mMatrix; }
        }

        //Used to draw the grid on the user control
        //https://stackoverflow.com/questions/1962348/draw-a-line-grid-on-a-windows-form

        private Point mStart = Point.Empty;
        private Point mEnd = Point.Empty;

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            for (int y = (e.ClipRectangle.Y / mGridSize) * mGridSize; y <= e.ClipRectangle.Bottom; y += mGridSize)
                for (int x = (e.ClipRectangle.X / mGridSize) * mGridSize; x <= e.ClipRectangle.Right; x += mGridSize)
                {
                    int sx = x / mGridSize;
                    int sy = y / mGridSize;

                    // Lets render the obstacles
                    Color color = Color.Empty;

                    if (mMatrix[sx, sy] != 0)
                    {
                        color = Color.DarkGray;

                        //The below code is from the other project, but I am not quite sure what it does as of yet, maybe when implementing the actual pathfinding ??? For the coordinates that is.
                        //int colorIndex = 240 - ((int)(Math.Log10(mMatrix[sx, sy]) * 127));
                        //colorIndex = colorIndex < 0 ? 0 : colorIndex > 255 ? 255 : colorIndex;
                        //color = Color.FromArgb(255, colorIndex, colorIndex, colorIndex);

                    }
                    else
                    {
                        // I have no idea how we would put the map behind here, I have tried like 70 things and nothing wants to work!
                        color = Color.White;
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

            //Drawing the grid
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



        #region attempt to draw grid (easy)
        //Pen linePen = new Pen(Color.Black);
        //Graphics grphx = this.CreateGraphics();
        //grphx.Clear(this.BackColor);

        //for (int i = 1; i < mGridSize; i++)
        //{
        //    //Draw verticle line
        //    grphx.DrawLine(linePen,
        //        (this.ClientSize.Width / mGridSize) * i,
        //        0,
        //        (this.ClientSize.Width / mGridSize) * i,
        //        this.ClientSize.Height);

        //    //Draw horizontal line
        //    grphx.DrawLine(linePen,
        //        0,
        //        (this.ClientSize.Height / mGridSize) * i,
        //        this.ClientSize.Width,
        //        (this.ClientSize.Height / mGridSize) * i);

        //}
        //linePen.Dispose();

        ////Continues the paint of other elements and controls
        //base.OnPaint(e);
        #endregion


        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.None)
            {
                return;
            }

            int x = e.X / mGridSize;
            int y = e.Y / mGridSize;

            try
            {
                if (e.Button == (MouseButtons.Left | MouseButtons.Right))
                    mMatrix[x, y] = (byte)(mMatrix[x, y] - mNodeWeight > 1 ? mMatrix[x, y] - mNodeWeight : 1);
                else if (e.Button == MouseButtons.Left)
                    mMatrix[x, y] = mNodeWeight;
                //else if (e.Button == MouseButtons.Right)
                //    mMatrix[x, y] = (byte)(mMatrix[x, y] + mNodeWeight < 256 ? mMatrix[x, y] + mNodeWeight : 255);

                this.Invalidate(new Rectangle(x * mGridSize, y * mGridSize, mGridSize, mGridSize));
                base.OnMouseMove(e);
            }
            catch (Exception ex)
            {
                //We should make this a custom exception
                MessageBox.Show(ex.Message);               
            }       
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            this.OnMouseMove(e);
            base.OnMouseDown(e);
        }
    }
}
