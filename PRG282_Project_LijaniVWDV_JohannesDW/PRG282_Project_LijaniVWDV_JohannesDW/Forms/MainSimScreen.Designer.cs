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
            this.ucGrid1 = new PRG282_Project_LijaniVWDV_JohannesDW.Forms.ucGrid();
            this.ucObstacles1 = new PRG282_Project_LijaniVWDV_JohannesDW.Forms.User_Control.ucObstacles();
            this.ucPlaneStats1 = new PRG282_Project_LijaniVWDV_JohannesDW.Forms.User_Control.ucPlaneStats();
            this.ucObstaclesDetected1 = new PRG282_Project_LijaniVWDV_JohannesDW.Forms.User_Control.ucObstaclesDetected();
            this.SuspendLayout();
            // 
            // ucGrid1
            // 
            this.ucGrid1.Location = new System.Drawing.Point(286, 3);
            this.ucGrid1.Name = "ucGrid1";
            this.ucGrid1.Size = new System.Drawing.Size(661, 538);
            this.ucGrid1.TabIndex = 0;
            // 
            // ucObstacles1
            // 
            this.ucObstacles1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ucObstacles1.Location = new System.Drawing.Point(4, 3);
            this.ucObstacles1.Name = "ucObstacles1";
            this.ucObstacles1.Size = new System.Drawing.Size(276, 272);
            this.ucObstacles1.TabIndex = 0;
            // 
            // ucPlaneStats1
            // 
            this.ucPlaneStats1.BackColor = System.Drawing.Color.SlateGray;
            this.ucPlaneStats1.Location = new System.Drawing.Point(4, 281);
            this.ucPlaneStats1.Name = "ucPlaneStats1";
            this.ucPlaneStats1.Size = new System.Drawing.Size(276, 260);
            this.ucPlaneStats1.TabIndex = 1;
            // 
            // ucObstaclesDetected1
            // 
            this.ucObstaclesDetected1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ucObstaclesDetected1.Location = new System.Drawing.Point(9, 11);
            this.ucObstaclesDetected1.Name = "ucObstaclesDetected1";
            this.ucObstaclesDetected1.Size = new System.Drawing.Size(268, 264);
            this.ucObstaclesDetected1.TabIndex = 2;
            // 
            // MainSimScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(947, 548);
            this.Controls.Add(this.ucPlaneStats1);
            this.Controls.Add(this.ucObstacles1);
            this.Controls.Add(this.ucGrid1);
            this.Controls.Add(this.ucObstaclesDetected1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainSimScreen";
            this.Text = "SIM Screen";
            this.ResumeLayout(false);

        }

        #endregion

        private ucGrid ucGrid1;
        private User_Control.ucObstacles ucObstacles1;
        private User_Control.ucPlaneStats ucPlaneStats1;
        private User_Control.ucObstaclesDetected ucObstaclesDetected1;
    }
}