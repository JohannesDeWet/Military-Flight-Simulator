namespace PRG282_Project_LijaniVWDV_JohannesDW.Forms.User_Control
{
    partial class ucPlaneStats
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
            this.lblPlaneStatsHead = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.prgbarFuelStatus = new System.Windows.Forms.ProgressBar();
            this.lblAltitudeDisplay = new System.Windows.Forms.Label();
            this.lbPayloadDisplay = new System.Windows.Forms.Label();
            this.lblHPDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPlaneStatsHead
            // 
            this.lblPlaneStatsHead.AutoSize = true;
            this.lblPlaneStatsHead.Font = new System.Drawing.Font("Stencil", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaneStatsHead.Location = new System.Drawing.Point(55, 13);
            this.lblPlaneStatsHead.Name = "lblPlaneStatsHead";
            this.lblPlaneStatsHead.Size = new System.Drawing.Size(140, 24);
            this.lblPlaneStatsHead.TabIndex = 0;
            this.lblPlaneStatsHead.Text = "Plane Stats:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "plane name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fuel Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Current Altitude";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Current Payload";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Current HP";
            // 
            // prgbarFuelStatus
            // 
            this.prgbarFuelStatus.Location = new System.Drawing.Point(103, 80);
            this.prgbarFuelStatus.Name = "prgbarFuelStatus";
            this.prgbarFuelStatus.Size = new System.Drawing.Size(119, 26);
            this.prgbarFuelStatus.TabIndex = 6;
            // 
            // lblAltitudeDisplay
            // 
            this.lblAltitudeDisplay.AutoSize = true;
            this.lblAltitudeDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltitudeDisplay.Location = new System.Drawing.Point(137, 128);
            this.lblAltitudeDisplay.Name = "lblAltitudeDisplay";
            this.lblAltitudeDisplay.Size = new System.Drawing.Size(59, 16);
            this.lblAltitudeDisplay.TabIndex = 7;
            this.lblAltitudeDisplay.Text = "altitude";
            // 
            // lbPayloadDisplay
            // 
            this.lbPayloadDisplay.AutoSize = true;
            this.lbPayloadDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPayloadDisplay.Location = new System.Drawing.Point(137, 170);
            this.lbPayloadDisplay.Name = "lbPayloadDisplay";
            this.lbPayloadDisplay.Size = new System.Drawing.Size(65, 16);
            this.lbPayloadDisplay.TabIndex = 8;
            this.lbPayloadDisplay.Text = "payload";
            // 
            // lblHPDisplay
            // 
            this.lblHPDisplay.AutoSize = true;
            this.lblHPDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHPDisplay.Location = new System.Drawing.Point(137, 215);
            this.lblHPDisplay.Name = "lblHPDisplay";
            this.lblHPDisplay.Size = new System.Drawing.Size(29, 16);
            this.lblHPDisplay.TabIndex = 9;
            this.lblHPDisplay.Text = "HP";
            // 
            // ucPlaneStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.Controls.Add(this.lblHPDisplay);
            this.Controls.Add(this.lbPayloadDisplay);
            this.Controls.Add(this.lblAltitudeDisplay);
            this.Controls.Add(this.prgbarFuelStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPlaneStatsHead);
            this.Name = "ucPlaneStats";
            this.Size = new System.Drawing.Size(261, 260);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlaneStatsHead;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar prgbarFuelStatus;
        private System.Windows.Forms.Label lblAltitudeDisplay;
        private System.Windows.Forms.Label lbPayloadDisplay;
        private System.Windows.Forms.Label lblHPDisplay;
    }
}
