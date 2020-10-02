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
            this.ChlShowProgress = new System.Windows.Forms.CheckBox();
            this.cmbDrawMode = new System.Windows.Forms.ComboBox();
            this.btnRefreshGrid = new System.Windows.Forms.Button();
            this.lblSelectObstacle = new System.Windows.Forms.Label();
            this.nrAltirude = new System.Windows.Forms.NumericUpDown();
            this.lblAltitude = new System.Windows.Forms.Label();
            this.TBarSpeed = new System.Windows.Forms.TrackBar();
            this.NumSearchLimit = new System.Windows.Forms.NumericUpDown();
            this.lblMainSimHeading = new System.Windows.Forms.Label();
            this.pnlPlaceObstacles = new System.Windows.Forms.Panel();
            this.lblHint = new System.Windows.Forms.Label();
            this.btnSubmitObstacles = new System.Windows.Forms.Button();
            this.lblPlaceObjects = new System.Windows.Forms.Label();
            this.grpbxRunSim = new System.Windows.Forms.GroupBox();
            this.ChkUseFastPathFinder = new System.Windows.Forms.CheckBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.ucGrid1 = new PRG282_Project_LijaniVWDV_JohannesDW.Forms.ucGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPlaneAlt = new System.Windows.Forms.Label();
            this.lblPlaneSpeed = new System.Windows.Forms.Label();
            this.lblPlaneHP = new System.Windows.Forms.Label();
            this.lblPlanePayload = new System.Windows.Forms.Label();
            this.lblPlaneRange = new System.Windows.Forms.Label();
            this.lblPlaneName = new System.Windows.Forms.Label();
            this.lblPlaneStats = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nrAltirude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBarSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumSearchLimit)).BeginInit();
            this.pnlPlaceObstacles.SuspendLayout();
            this.grpbxRunSim.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStartSimulation
            // 
            this.btnStartSimulation.BackColor = System.Drawing.Color.Black;
            this.btnStartSimulation.Font = new System.Drawing.Font("Stencil", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartSimulation.Location = new System.Drawing.Point(19, 70);
            this.btnStartSimulation.Name = "btnStartSimulation";
            this.btnStartSimulation.Size = new System.Drawing.Size(213, 87);
            this.btnStartSimulation.TabIndex = 3;
            this.btnStartSimulation.Text = "R U N";
            this.btnStartSimulation.UseVisualStyleBackColor = false;
            this.btnStartSimulation.Click += new System.EventHandler(this.btnStartSimulation_Click);
            // 
            // ChlShowProgress
            // 
            this.ChlShowProgress.AutoSize = true;
            this.ChlShowProgress.Checked = true;
            this.ChlShowProgress.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChlShowProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ChlShowProgress.Location = new System.Drawing.Point(75, 34);
            this.ChlShowProgress.Name = "ChlShowProgress";
            this.ChlShowProgress.Size = new System.Drawing.Size(97, 17);
            this.ChlShowProgress.TabIndex = 29;
            this.ChlShowProgress.Text = "Show Progress";
            this.ChlShowProgress.UseVisualStyleBackColor = true;
            // 
            // cmbDrawMode
            // 
            this.cmbDrawMode.DisplayMember = "(none)";
            this.cmbDrawMode.FormattingEnabled = true;
            this.cmbDrawMode.Items.AddRange(new object[] {
            "Block",
            "Home Base",
            "Enemy Base"});
            this.cmbDrawMode.Location = new System.Drawing.Point(51, 68);
            this.cmbDrawMode.Name = "cmbDrawMode";
            this.cmbDrawMode.Size = new System.Drawing.Size(121, 21);
            this.cmbDrawMode.TabIndex = 27;
            this.cmbDrawMode.Text = "-- Select -- ";
            this.cmbDrawMode.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnRefreshGrid
            // 
            this.btnRefreshGrid.Location = new System.Drawing.Point(72, 172);
            this.btnRefreshGrid.Name = "btnRefreshGrid";
            this.btnRefreshGrid.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshGrid.TabIndex = 31;
            this.btnRefreshGrid.Text = "New Grid";
            this.btnRefreshGrid.UseVisualStyleBackColor = true;
            this.btnRefreshGrid.Click += new System.EventHandler(this.btnRefreshGrid_Click);
            // 
            // lblSelectObstacle
            // 
            this.lblSelectObstacle.AutoSize = true;
            this.lblSelectObstacle.Location = new System.Drawing.Point(72, 52);
            this.lblSelectObstacle.Name = "lblSelectObstacle";
            this.lblSelectObstacle.Size = new System.Drawing.Size(86, 13);
            this.lblSelectObstacle.TabIndex = 32;
            this.lblSelectObstacle.Text = "Choose obstacle";
            // 
            // nrAltirude
            // 
            this.nrAltirude.Location = new System.Drawing.Point(51, 135);
            this.nrAltirude.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nrAltirude.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nrAltirude.Name = "nrAltirude";
            this.nrAltirude.Size = new System.Drawing.Size(120, 20);
            this.nrAltirude.TabIndex = 34;
            this.nrAltirude.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblAltitude
            // 
            this.lblAltitude.AutoSize = true;
            this.lblAltitude.Location = new System.Drawing.Point(69, 119);
            this.lblAltitude.Name = "lblAltitude";
            this.lblAltitude.Size = new System.Drawing.Size(87, 13);
            this.lblAltitude.TabIndex = 33;
            this.lblAltitude.Text = "Obstacle Altitude";
            // 
            // TBarSpeed
            // 
            this.TBarSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TBarSpeed.AutoSize = false;
            this.TBarSpeed.LargeChange = 10;
            this.TBarSpeed.Location = new System.Drawing.Point(849, 40);
            this.TBarSpeed.Maximum = 60;
            this.TBarSpeed.Name = "TBarSpeed";
            this.TBarSpeed.Size = new System.Drawing.Size(121, 33);
            this.TBarSpeed.TabIndex = 33;
            this.TBarSpeed.TickFrequency = 10;
            this.TBarSpeed.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.TBarSpeed.Value = 3;
            // 
            // NumSearchLimit
            // 
            this.NumSearchLimit.Location = new System.Drawing.Point(976, 53);
            this.NumSearchLimit.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.NumSearchLimit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumSearchLimit.Name = "NumSearchLimit";
            this.NumSearchLimit.Size = new System.Drawing.Size(62, 20);
            this.NumSearchLimit.TabIndex = 35;
            this.NumSearchLimit.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // lblMainSimHeading
            // 
            this.lblMainSimHeading.AutoSize = true;
            this.lblMainSimHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblMainSimHeading.Font = new System.Drawing.Font("Stencil", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainSimHeading.ForeColor = System.Drawing.Color.White;
            this.lblMainSimHeading.Location = new System.Drawing.Point(331, 9);
            this.lblMainSimHeading.Name = "lblMainSimHeading";
            this.lblMainSimHeading.Size = new System.Drawing.Size(427, 80);
            this.lblMainSimHeading.TabIndex = 36;
            this.lblMainSimHeading.Text = "Simulation";
            // 
            // pnlPlaceObstacles
            // 
            this.pnlPlaceObstacles.BackColor = System.Drawing.Color.LightSlateGray;
            this.pnlPlaceObstacles.Controls.Add(this.lblHint);
            this.pnlPlaceObstacles.Controls.Add(this.btnSubmitObstacles);
            this.pnlPlaceObstacles.Controls.Add(this.nrAltirude);
            this.pnlPlaceObstacles.Controls.Add(this.lblAltitude);
            this.pnlPlaceObstacles.Controls.Add(this.lblPlaceObjects);
            this.pnlPlaceObstacles.Controls.Add(this.btnRefreshGrid);
            this.pnlPlaceObstacles.Controls.Add(this.cmbDrawMode);
            this.pnlPlaceObstacles.Controls.Add(this.lblSelectObstacle);
            this.pnlPlaceObstacles.Location = new System.Drawing.Point(17, 107);
            this.pnlPlaceObstacles.Name = "pnlPlaceObstacles";
            this.pnlPlaceObstacles.Size = new System.Drawing.Size(247, 259);
            this.pnlPlaceObstacles.TabIndex = 37;
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.Location = new System.Drawing.Point(34, 92);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(169, 13);
            this.lblHint.TabIndex = 36;
            this.lblHint.Text = "* hold left and right button to erase";
            // 
            // btnSubmitObstacles
            // 
            this.btnSubmitObstacles.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitObstacles.Location = new System.Drawing.Point(51, 201);
            this.btnSubmitObstacles.Name = "btnSubmitObstacles";
            this.btnSubmitObstacles.Size = new System.Drawing.Size(121, 43);
            this.btnSubmitObstacles.TabIndex = 35;
            this.btnSubmitObstacles.Text = "S U B M I T";
            this.btnSubmitObstacles.UseVisualStyleBackColor = true;
            this.btnSubmitObstacles.Click += new System.EventHandler(this.btnSubmitObstacles_Click);
            // 
            // lblPlaceObjects
            // 
            this.lblPlaceObjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPlaceObjects.Font = new System.Drawing.Font("Stencil", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaceObjects.Location = new System.Drawing.Point(3, 0);
            this.lblPlaceObjects.Name = "lblPlaceObjects";
            this.lblPlaceObjects.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPlaceObjects.Size = new System.Drawing.Size(229, 47);
            this.lblPlaceObjects.TabIndex = 1;
            this.lblPlaceObjects.Text = "Place obstacles:";
            this.lblPlaceObjects.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpbxRunSim
            // 
            this.grpbxRunSim.BackColor = System.Drawing.Color.Crimson;
            this.grpbxRunSim.Controls.Add(this.btnStartSimulation);
            this.grpbxRunSim.Controls.Add(this.ChlShowProgress);
            this.grpbxRunSim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grpbxRunSim.Font = new System.Drawing.Font("Stencil", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxRunSim.ForeColor = System.Drawing.Color.White;
            this.grpbxRunSim.Location = new System.Drawing.Point(17, 390);
            this.grpbxRunSim.Name = "grpbxRunSim";
            this.grpbxRunSim.Size = new System.Drawing.Size(247, 175);
            this.grpbxRunSim.TabIndex = 38;
            this.grpbxRunSim.TabStop = false;
            this.grpbxRunSim.Text = "Play Simulation";
            // 
            // ChkUseFastPathFinder
            // 
            this.ChkUseFastPathFinder.Checked = true;
            this.ChkUseFastPathFinder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkUseFastPathFinder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ChkUseFastPathFinder.Location = new System.Drawing.Point(663, 537);
            this.ChkUseFastPathFinder.Name = "ChkUseFastPathFinder";
            this.ChkUseFastPathFinder.Size = new System.Drawing.Size(137, 20);
            this.ChkUseFastPathFinder.TabIndex = 30;
            this.ChkUseFastPathFinder.Text = "Fast PathFinder";
            this.ChkUseFastPathFinder.UseVisualStyleBackColor = true;
            this.ChkUseFastPathFinder.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(939, 537);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(69, 28);
            this.btnExit.TabIndex = 40;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.Location = new System.Drawing.Point(875, 460);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(189, 59);
            this.btnContinue.TabIndex = 41;
            this.btnContinue.Text = "C O N T I N U E";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // ucGrid1
            // 
            this.ucGrid1.BackColor = System.Drawing.Color.Transparent;
            this.ucGrid1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucGrid1.BackgroundImage")));
            this.ucGrid1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucGrid1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ucGrid1.DrawModeSetup = PRG282_Project_LijaniVWDV_JohannesDW.Forms.DrawModeSetup.None;
            this.ucGrid1.End = new System.Drawing.Point(0, 0);
            this.ucGrid1.Formula = PRG282_Project_LijaniVWDV_JohannesDW.Classes.Path_Finding_Classes.HeuristicFormula.Manhattan;
            this.ucGrid1.GridSize = 20;
            this.ucGrid1.Location = new System.Drawing.Point(289, 107);
            this.ucGrid1.Name = "ucGrid1";
            this.ucGrid1.NodeWeight = ((byte)(1));
            this.ucGrid1.ObstacleAlt = PRG282_Project_LijaniVWDV_JohannesDW.Forms.ObstacleAltitude.Low;
            this.ucGrid1.Size = new System.Drawing.Size(523, 458);
            this.ucGrid1.Start = new System.Drawing.Point(0, 0);
            this.ucGrid1.TabIndex = 26;
            this.ucGrid1.Enter += new System.EventHandler(this.ucGrid1_Enter);
            this.ucGrid1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ucGrid1_MouseDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.lblPlaneAlt);
            this.panel1.Controls.Add(this.lblPlaneSpeed);
            this.panel1.Controls.Add(this.lblPlaneHP);
            this.panel1.Controls.Add(this.lblPlanePayload);
            this.panel1.Controls.Add(this.lblPlaneRange);
            this.panel1.Controls.Add(this.lblPlaneName);
            this.panel1.Controls.Add(this.lblPlaneStats);
            this.panel1.Location = new System.Drawing.Point(842, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 330);
            this.panel1.TabIndex = 42;
            // 
            // lblPlaneAlt
            // 
            this.lblPlaneAlt.AutoSize = true;
            this.lblPlaneAlt.Location = new System.Drawing.Point(39, 228);
            this.lblPlaneAlt.Name = "lblPlaneAlt";
            this.lblPlaneAlt.Size = new System.Drawing.Size(45, 13);
            this.lblPlaneAlt.TabIndex = 6;
            this.lblPlaneAlt.Text = "Altitude:";
            // 
            // lblPlaneSpeed
            // 
            this.lblPlaneSpeed.AutoSize = true;
            this.lblPlaneSpeed.Location = new System.Drawing.Point(39, 280);
            this.lblPlaneSpeed.Name = "lblPlaneSpeed";
            this.lblPlaneSpeed.Size = new System.Drawing.Size(44, 13);
            this.lblPlaneSpeed.TabIndex = 5;
            this.lblPlaneSpeed.Text = "Speed: ";
            // 
            // lblPlaneHP
            // 
            this.lblPlaneHP.AutoSize = true;
            this.lblPlaneHP.Location = new System.Drawing.Point(39, 132);
            this.lblPlaneHP.Name = "lblPlaneHP";
            this.lblPlaneHP.Size = new System.Drawing.Size(25, 13);
            this.lblPlaneHP.TabIndex = 4;
            this.lblPlaneHP.Text = "HP:";
            // 
            // lblPlanePayload
            // 
            this.lblPlanePayload.AutoSize = true;
            this.lblPlanePayload.Location = new System.Drawing.Point(39, 179);
            this.lblPlanePayload.Name = "lblPlanePayload";
            this.lblPlanePayload.Size = new System.Drawing.Size(48, 13);
            this.lblPlanePayload.TabIndex = 3;
            this.lblPlanePayload.Text = "Payload:";
            // 
            // lblPlaneRange
            // 
            this.lblPlaneRange.AutoSize = true;
            this.lblPlaneRange.Location = new System.Drawing.Point(39, 73);
            this.lblPlaneRange.Name = "lblPlaneRange";
            this.lblPlaneRange.Size = new System.Drawing.Size(42, 13);
            this.lblPlaneRange.TabIndex = 2;
            this.lblPlaneRange.Text = "Range:";
            // 
            // lblPlaneName
            // 
            this.lblPlaneName.AutoSize = true;
            this.lblPlaneName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaneName.Location = new System.Drawing.Point(48, 32);
            this.lblPlaneName.Name = "lblPlaneName";
            this.lblPlaneName.Size = new System.Drawing.Size(52, 17);
            this.lblPlaneName.TabIndex = 1;
            this.lblPlaneName.Text = "label1";
            // 
            // lblPlaneStats
            // 
            this.lblPlaneStats.AutoSize = true;
            this.lblPlaneStats.Font = new System.Drawing.Font("Stencil", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaneStats.Location = new System.Drawing.Point(47, 8);
            this.lblPlaneStats.Name = "lblPlaneStats";
            this.lblPlaneStats.Size = new System.Drawing.Size(140, 24);
            this.lblPlaneStats.TabIndex = 0;
            this.lblPlaneStats.Text = "Plane Stats:";
            // 
            // MainSimScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1103, 590);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpbxRunSim);
            this.Controls.Add(this.pnlPlaceObstacles);
            this.Controls.Add(this.lblMainSimHeading);
            this.Controls.Add(this.NumSearchLimit);
            this.Controls.Add(this.TBarSpeed);
            this.Controls.Add(this.ucGrid1);
            this.Controls.Add(this.ChkUseFastPathFinder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainSimScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIM Screen";
            this.Load += new System.EventHandler(this.MainSimScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nrAltirude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBarSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumSearchLimit)).EndInit();
            this.pnlPlaceObstacles.ResumeLayout(false);
            this.pnlPlaceObstacles.PerformLayout();
            this.grpbxRunSim.ResumeLayout(false);
            this.grpbxRunSim.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStartSimulation;
        private ucGrid ucGrid1;
        private System.Windows.Forms.ComboBox cmbDrawMode;
        private System.Windows.Forms.Button btnRefreshGrid;
        private System.Windows.Forms.Label lblSelectObstacle;
        private System.Windows.Forms.NumericUpDown nrAltirude;
        private System.Windows.Forms.Label lblAltitude;
        private System.Windows.Forms.CheckBox ChlShowProgress;
        private System.Windows.Forms.TrackBar TBarSpeed;
        private System.Windows.Forms.NumericUpDown NumSearchLimit;
        private System.Windows.Forms.Label lblMainSimHeading;
        private System.Windows.Forms.Panel pnlPlaceObstacles;
        private System.Windows.Forms.Label lblPlaceObjects;
        private System.Windows.Forms.Button btnSubmitObstacles;
        private System.Windows.Forms.GroupBox grpbxRunSim;
        private System.Windows.Forms.CheckBox ChkUseFastPathFinder;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPlaneName;
        private System.Windows.Forms.Label lblPlaneStats;
        private System.Windows.Forms.Label lblPlaneRange;
        private System.Windows.Forms.Label lblPlaneHP;
        private System.Windows.Forms.Label lblPlanePayload;
        private System.Windows.Forms.Label lblPlaneAlt;
        private System.Windows.Forms.Label lblPlaneSpeed;
    }
}