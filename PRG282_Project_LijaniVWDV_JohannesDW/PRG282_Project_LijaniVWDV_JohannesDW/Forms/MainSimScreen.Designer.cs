namespace PRG282_Project_LijaniVWDV_JohannesDW.Forms
{
    partial class MainSimScreen
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainSimScreen));
            this.btnStartSimulation = new System.Windows.Forms.Button();
            this.ucPlaneStats1 = new PRG282_Project_LijaniVWDV_JohannesDW.Forms.User_Control.ucPlaneStats();
            this.ucObstacles1 = new PRG282_Project_LijaniVWDV_JohannesDW.Forms.User_Control.ucObstacles();
            this.ucGrid1 = new PRG282_Project_LijaniVWDV_JohannesDW.Forms.ucGrid();
            this.ucObstaclesDetected1 = new PRG282_Project_LijaniVWDV_JohannesDW.Forms.User_Control.ucObstaclesDetected();
            this.ToolStrp = new System.Windows.Forms.ToolStrip();
            this.BtnNew = new System.Windows.Forms.ToolStripButton();
            this.BtnLoad = new System.Windows.Forms.ToolStripButton();
            this.BtnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.Btn1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Btn2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Btn5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Btn10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.Btn13 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.Btn20 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.Btn40 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.Btn80 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnX = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnStart = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnEnd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStartSimulation
            // 
            this.btnStartSimulation.Location = new System.Drawing.Point(839, 577);
            this.btnStartSimulation.Name = "btnStartSimulation";
            this.btnStartSimulation.Size = new System.Drawing.Size(75, 23);
            this.btnStartSimulation.TabIndex = 3;
            this.btnStartSimulation.Text = "Run";
            this.btnStartSimulation.UseVisualStyleBackColor = true;
            this.btnStartSimulation.Click += new System.EventHandler(this.btnStartSimulation_Click);
            // 
            // ucPlaneStats1
            // 
            this.ucPlaneStats1.BackColor = System.Drawing.Color.SlateGray;
            this.ucPlaneStats1.Location = new System.Drawing.Point(4, 281);
            this.ucPlaneStats1.Name = "ucPlaneStats1";
            this.ucPlaneStats1.Size = new System.Drawing.Size(276, 260);
            this.ucPlaneStats1.TabIndex = 1;
            // 
            // ucObstacles1
            // 
            this.ucObstacles1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ucObstacles1.Location = new System.Drawing.Point(4, 3);
            this.ucObstacles1.Name = "ucObstacles1";
            this.ucObstacles1.Size = new System.Drawing.Size(276, 272);
            this.ucObstacles1.TabIndex = 0;
            // 
            // ucGrid1
            // 
            this.ucGrid1.Location = new System.Drawing.Point(286, 3);
            this.ucGrid1.End = new System.Drawing.Point(0, 0);
            this.ucGrid1.Start = new System.Drawing.Point(0, 0);
            this.ucGrid1.Name = "ucGrid1";
            this.ucGrid1.Size = new System.Drawing.Size(661, 538);
            this.ucGrid1.TabIndex = 0;
            // 
            // ucObstaclesDetected1
            // 
            this.ucObstaclesDetected1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ucObstaclesDetected1.Location = new System.Drawing.Point(9, 11);
            this.ucObstaclesDetected1.Name = "ucObstaclesDetected1";
            this.ucObstaclesDetected1.Size = new System.Drawing.Size(268, 264);
            this.ucObstaclesDetected1.TabIndex = 2;
            // 
            // ToolStrp
            // 
            this.ToolStrp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ToolStrp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnNew,
            this.BtnLoad,
            this.BtnSave,
            this.toolStripSeparator10,
            this.Btn1,
            this.toolStripSeparator1,
            this.Btn2,
            this.toolStripSeparator2,
            this.Btn5,
            this.toolStripSeparator3,
            this.Btn10,
            this.toolStripSeparator11,
            this.Btn13,
            this.toolStripSeparator4,
            this.Btn20,
            this.toolStripSeparator5,
            this.Btn40,
            this.toolStripSeparator6,
            this.Btn80,
            this.toolStripSeparator12,
            this.BtnX,
            this.toolStripSeparator7,
            this.BtnStart,
            this.toolStripSeparator8,
            this.BtnEnd,
            this.toolStripSeparator9});
            this.ToolStrp.Location = new System.Drawing.Point(0, 609);
            this.ToolStrp.Name = "ToolStrp";
            this.ToolStrp.Size = new System.Drawing.Size(947, 25);
            this.ToolStrp.TabIndex = 11;
            this.ToolStrp.Text = "toolStrip1";
            // 
            // BtnNew
            // 
            this.BtnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnNew.Image = ((System.Drawing.Image)(resources.GetObject("BtnNew.Image")));
            this.BtnNew.ImageTransparentColor = System.Drawing.Color.Black;
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(23, 22);
            this.BtnNew.ToolTipText = "New";
            // 
            // BtnLoad
            // 
            this.BtnLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnLoad.Image = ((System.Drawing.Image)(resources.GetObject("BtnLoad.Image")));
            this.BtnLoad.ImageTransparentColor = System.Drawing.Color.Black;
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(23, 22);
            this.BtnLoad.ToolTipText = "Load";
            // 
            // BtnSave
            // 
            this.BtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnSave.Image = ((System.Drawing.Image)(resources.GetObject("BtnSave.Image")));
            this.BtnSave.ImageTransparentColor = System.Drawing.Color.Black;
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(23, 22);
            this.BtnSave.ToolTipText = "Save";
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 25);
            // 
            // Btn1
            // 
            this.Btn1.CheckOnClick = true;
            this.Btn1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Btn1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(23, 22);
            this.Btn1.Tag = "1";
            this.Btn1.Text = "1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // Btn2
            // 
            this.Btn2.CheckOnClick = true;
            this.Btn2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Btn2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(23, 22);
            this.Btn2.Tag = "2";
            this.Btn2.Text = "2";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // Btn5
            // 
            this.Btn5.CheckOnClick = true;
            this.Btn5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Btn5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(23, 22);
            this.Btn5.Tag = "5";
            this.Btn5.Text = "5";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // Btn10
            // 
            this.Btn10.CheckOnClick = true;
            this.Btn10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Btn10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn10.Name = "Btn10";
            this.Btn10.Size = new System.Drawing.Size(23, 22);
            this.Btn10.Tag = "10";
            this.Btn10.Text = "10";
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 25);
            // 
            // Btn13
            // 
            this.Btn13.CheckOnClick = true;
            this.Btn13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Btn13.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn13.Name = "Btn13";
            this.Btn13.Size = new System.Drawing.Size(23, 22);
            this.Btn13.Tag = "13";
            this.Btn13.Text = "13";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // Btn20
            // 
            this.Btn20.CheckOnClick = true;
            this.Btn20.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Btn20.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn20.Name = "Btn20";
            this.Btn20.Size = new System.Drawing.Size(23, 22);
            this.Btn20.Tag = "20";
            this.Btn20.Text = "20";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // Btn40
            // 
            this.Btn40.CheckOnClick = true;
            this.Btn40.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Btn40.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn40.Name = "Btn40";
            this.Btn40.Size = new System.Drawing.Size(23, 22);
            this.Btn40.Tag = "40";
            this.Btn40.Text = "40";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // Btn80
            // 
            this.Btn80.CheckOnClick = true;
            this.Btn80.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Btn80.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn80.Name = "Btn80";
            this.Btn80.Size = new System.Drawing.Size(23, 22);
            this.Btn80.Tag = "80";
            this.Btn80.Text = "80";
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(6, 25);
            // 
            // BtnX
            // 
            this.BtnX.CheckOnClick = true;
            this.BtnX.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BtnX.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnX.Name = "BtnX";
            this.BtnX.Size = new System.Drawing.Size(23, 22);
            this.BtnX.Tag = "0";
            this.BtnX.Text = "X";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // BtnStart
            // 
            this.BtnStart.CheckOnClick = true;
            this.BtnStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BtnStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(35, 22);
            this.BtnStart.Tag = "Start";
            this.BtnStart.Text = "Start";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // BtnEnd
            // 
            this.BtnEnd.CheckOnClick = true;
            this.BtnEnd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BtnEnd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnEnd.Name = "BtnEnd";
            this.BtnEnd.Size = new System.Drawing.Size(31, 22);
            this.BtnEnd.Tag = "End";
            this.BtnEnd.Text = "End";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // MainSimScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(947, 634);
            this.Controls.Add(this.ToolStrp);
            this.Controls.Add(this.btnStartSimulation);
            this.Controls.Add(this.ucPlaneStats1);
            this.Controls.Add(this.ucObstacles1);
            this.Controls.Add(this.ucGrid1);
            this.Controls.Add(this.ucObstaclesDetected1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainSimScreen";
            this.Text = "SIM Screen";
            this.ToolStrp.ResumeLayout(false);
            this.ToolStrp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ucGrid ucGrid1;
        private User_Control.ucObstacles ucObstacles1;
        private User_Control.ucPlaneStats ucPlaneStats1;
        private User_Control.ucObstaclesDetected ucObstaclesDetected1;
        private System.Windows.Forms.Button btnStartSimulation;
        private System.Windows.Forms.ToolStrip ToolStrp;
        private System.Windows.Forms.ToolStripButton BtnNew;
        private System.Windows.Forms.ToolStripButton BtnLoad;
        private System.Windows.Forms.ToolStripButton BtnSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripButton Btn1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton Btn2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton Btn5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton Btn10;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripButton Btn13;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton Btn20;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton Btn40;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton Btn80;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripButton BtnX;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton BtnStart;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton BtnEnd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
    }
}