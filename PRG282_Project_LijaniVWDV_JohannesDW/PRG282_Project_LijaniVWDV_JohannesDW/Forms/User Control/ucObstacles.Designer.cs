namespace PRG282_Project_LijaniVWDV_JohannesDW.Forms.User_Control
{
    partial class ucObstacles
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucObstacles));
            this.lblObstaclesHead = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmitObstacles = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolstrpbtnStart = new System.Windows.Forms.ToolStripButton();
            this.toolstrpbtnEnd = new System.Windows.Forms.ToolStripButton();
            this.toolstrpbtnObstacle = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblObstaclesHead
            // 
            this.lblObstaclesHead.AutoSize = true;
            this.lblObstaclesHead.Font = new System.Drawing.Font("Stencil", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObstaclesHead.Location = new System.Drawing.Point(17, 22);
            this.lblObstaclesHead.Name = "lblObstaclesHead";
            this.lblObstaclesHead.Size = new System.Drawing.Size(248, 22);
            this.lblObstaclesHead.TabIndex = 0;
            this.lblObstaclesHead.Text = "Choose your obstacles:";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(43, 137);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(172, 45);
            this.trackBar1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Obstacle Altitude:";
            // 
            // btnSubmitObstacles
            // 
            this.btnSubmitObstacles.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitObstacles.Location = new System.Drawing.Point(88, 188);
            this.btnSubmitObstacles.Name = "btnSubmitObstacles";
            this.btnSubmitObstacles.Size = new System.Drawing.Size(93, 42);
            this.btnSubmitObstacles.TabIndex = 3;
            this.btnSubmitObstacles.Text = "D O N E";
            this.btnSubmitObstacles.UseVisualStyleBackColor = true;
            this.btnSubmitObstacles.Click += new System.EventHandler(this.btnSubmitObstacles_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstrpbtnStart,
            this.toolstrpbtnEnd,
            this.toolstrpbtnObstacle});
            this.toolStrip1.Location = new System.Drawing.Point(58, 63);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(135, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolstrpbtnStart
            // 
            this.toolstrpbtnStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolstrpbtnStart.Image = ((System.Drawing.Image)(resources.GetObject("toolstrpbtnStart.Image")));
            this.toolstrpbtnStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolstrpbtnStart.Name = "toolstrpbtnStart";
            this.toolstrpbtnStart.Size = new System.Drawing.Size(35, 22);
            this.toolstrpbtnStart.Text = "Start";
            // 
            // toolstrpbtnEnd
            // 
            this.toolstrpbtnEnd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolstrpbtnEnd.Image = ((System.Drawing.Image)(resources.GetObject("toolstrpbtnEnd.Image")));
            this.toolstrpbtnEnd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolstrpbtnEnd.Name = "toolstrpbtnEnd";
            this.toolstrpbtnEnd.Size = new System.Drawing.Size(31, 22);
            this.toolstrpbtnEnd.Text = "End";
            // 
            // toolstrpbtnObstacle
            // 
            this.toolstrpbtnObstacle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolstrpbtnObstacle.Image = ((System.Drawing.Image)(resources.GetObject("toolstrpbtnObstacle.Image")));
            this.toolstrpbtnObstacle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolstrpbtnObstacle.Name = "toolstrpbtnObstacle";
            this.toolstrpbtnObstacle.Size = new System.Drawing.Size(57, 22);
            this.toolstrpbtnObstacle.Text = "Obstacle";
            // 
            // ucObstacles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnSubmitObstacles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.lblObstaclesHead);
            this.Name = "ucObstacles";
            this.Size = new System.Drawing.Size(272, 260);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblObstaclesHead;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmitObstacles;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolstrpbtnStart;
        private System.Windows.Forms.ToolStripButton toolstrpbtnEnd;
        private System.Windows.Forms.ToolStripButton toolstrpbtnObstacle;
    }
}
