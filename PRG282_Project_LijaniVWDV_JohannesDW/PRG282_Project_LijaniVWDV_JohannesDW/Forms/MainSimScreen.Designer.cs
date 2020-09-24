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
            this.PnlSettings = new System.Windows.Forms.Panel();
            this.ChkUseFastPathFinder = new System.Windows.Forms.CheckBox();
            this.ChlShowProgress = new System.Windows.Forms.CheckBox();
            this.cmbDrawMode = new System.Windows.Forms.ComboBox();
            this.btnRefreshGrid = new System.Windows.Forms.Button();
            this.lblSelectObstacle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nrAltirude = new System.Windows.Forms.NumericUpDown();
            this.lblAltitude = new System.Windows.Forms.Label();
            this.ucGrid1 = new PRG282_Project_LijaniVWDV_JohannesDW.Forms.ucGrid();
            this.PnlSettings.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrAltirude)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStartSimulation
            // 
            this.btnStartSimulation.Location = new System.Drawing.Point(34, 62);
            this.btnStartSimulation.Name = "btnStartSimulation";
            this.btnStartSimulation.Size = new System.Drawing.Size(75, 23);
            this.btnStartSimulation.TabIndex = 3;
            this.btnStartSimulation.Text = "Run";
            this.btnStartSimulation.UseVisualStyleBackColor = true;
            this.btnStartSimulation.Click += new System.EventHandler(this.btnStartSimulation_Click);
            // 
            // PnlSettings
            // 
            this.PnlSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlSettings.Controls.Add(this.ChkUseFastPathFinder);
            this.PnlSettings.Controls.Add(this.ChlShowProgress);
            this.PnlSettings.Controls.Add(this.btnStartSimulation);
            this.PnlSettings.Location = new System.Drawing.Point(775, 76);
            this.PnlSettings.Name = "PnlSettings";
            this.PnlSettings.Size = new System.Drawing.Size(151, 99);
            this.PnlSettings.TabIndex = 24;
            // 
            // ChkUseFastPathFinder
            // 
            this.ChkUseFastPathFinder.Checked = true;
            this.ChkUseFastPathFinder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkUseFastPathFinder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ChkUseFastPathFinder.Location = new System.Drawing.Point(12, 16);
            this.ChkUseFastPathFinder.Name = "ChkUseFastPathFinder";
            this.ChkUseFastPathFinder.Size = new System.Drawing.Size(137, 20);
            this.ChkUseFastPathFinder.TabIndex = 30;
            this.ChkUseFastPathFinder.Text = "Fast PathFinder";
            this.ChkUseFastPathFinder.UseVisualStyleBackColor = true;
            // 
            // ChlShowProgress
            // 
            this.ChlShowProgress.AutoSize = true;
            this.ChlShowProgress.Checked = true;
            this.ChlShowProgress.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChlShowProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ChlShowProgress.Location = new System.Drawing.Point(12, 39);
            this.ChlShowProgress.Name = "ChlShowProgress";
            this.ChlShowProgress.Size = new System.Drawing.Size(97, 17);
            this.ChlShowProgress.TabIndex = 29;
            this.ChlShowProgress.Text = "Show Progress";
            this.ChlShowProgress.UseVisualStyleBackColor = true;
            // 
            // cmbDrawMode
            // 
            this.cmbDrawMode.FormattingEnabled = true;
            this.cmbDrawMode.Items.AddRange(new object[] {
            "Start",
            "Stop",
            "Block"});
            this.cmbDrawMode.Location = new System.Drawing.Point(12, 28);
            this.cmbDrawMode.Name = "cmbDrawMode";
            this.cmbDrawMode.Size = new System.Drawing.Size(121, 21);
            this.cmbDrawMode.TabIndex = 27;
            this.cmbDrawMode.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnRefreshGrid
            // 
            this.btnRefreshGrid.Location = new System.Drawing.Point(34, 103);
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
            this.lblSelectObstacle.Location = new System.Drawing.Point(31, 12);
            this.lblSelectObstacle.Name = "lblSelectObstacle";
            this.lblSelectObstacle.Size = new System.Drawing.Size(86, 13);
            this.lblSelectObstacle.TabIndex = 32;
            this.lblSelectObstacle.Text = "Choose obstacle";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.nrAltirude);
            this.panel1.Controls.Add(this.lblAltitude);
            this.panel1.Controls.Add(this.btnRefreshGrid);
            this.panel1.Controls.Add(this.lblSelectObstacle);
            this.panel1.Controls.Add(this.cmbDrawMode);
            this.panel1.Location = new System.Drawing.Point(775, 181);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(151, 143);
            this.panel1.TabIndex = 32;
            // 
            // nrAltirude
            // 
            this.nrAltirude.Location = new System.Drawing.Point(13, 77);
            this.nrAltirude.Name = "nrAltirude";
            this.nrAltirude.Size = new System.Drawing.Size(120, 20);
            this.nrAltirude.TabIndex = 34;
            // 
            // lblAltitude
            // 
            this.lblAltitude.AutoSize = true;
            this.lblAltitude.Location = new System.Drawing.Point(31, 61);
            this.lblAltitude.Name = "lblAltitude";
            this.lblAltitude.Size = new System.Drawing.Size(87, 13);
            this.lblAltitude.TabIndex = 33;
            this.lblAltitude.Text = "Obstacle Altitude";
            // 
            // ucGrid1
            // 
            this.ucGrid1.DrawModeSetup = PRG282_Project_LijaniVWDV_JohannesDW.Forms.DrawModeSetup.None;
            this.ucGrid1.End = new System.Drawing.Point(0, 0);
            this.ucGrid1.Formula = PRG282_Project_LijaniVWDV_JohannesDW.Classes.Path_Finding_Classes.HeuristicFormula.Manhattan;
            this.ucGrid1.GridSize = 20;
            this.ucGrid1.Location = new System.Drawing.Point(243, 32);
            this.ucGrid1.Name = "ucGrid1";
            this.ucGrid1.NodeWeight = ((byte)(1));
            this.ucGrid1.ObstacleAlt = PRG282_Project_LijaniVWDV_JohannesDW.Forms.ObstacleAltitude.Low;
            this.ucGrid1.Size = new System.Drawing.Size(515, 458);
            this.ucGrid1.Start = new System.Drawing.Point(0, 0);
            this.ucGrid1.TabIndex = 26;
            this.ucGrid1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ucGrid1_MouseDown);
            // 
            // MainSimScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(959, 502);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucGrid1);
            this.Controls.Add(this.PnlSettings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainSimScreen";
            this.Text = "SIM Screen";
            this.PnlSettings.ResumeLayout(false);
            this.PnlSettings.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrAltirude)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnStartSimulation;
        private System.Windows.Forms.Panel PnlSettings;
        private System.Windows.Forms.CheckBox ChkUseFastPathFinder;
        private System.Windows.Forms.CheckBox ChlShowProgress;
        private ucGrid ucGrid1;
        private System.Windows.Forms.ComboBox cmbDrawMode;
        private System.Windows.Forms.Button btnRefreshGrid;
        private System.Windows.Forms.Label lblSelectObstacle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown nrAltirude;
        private System.Windows.Forms.Label lblAltitude;
    }
}