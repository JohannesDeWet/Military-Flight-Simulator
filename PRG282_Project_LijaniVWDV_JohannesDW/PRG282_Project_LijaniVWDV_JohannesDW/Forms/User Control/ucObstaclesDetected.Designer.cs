namespace PRG282_Project_LijaniVWDV_JohannesDW.Forms.User_Control
{
    partial class ucObstaclesDetected
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
            this.lblObstDetectHead = new System.Windows.Forms.Label();
            this.lvObjectsDetected = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lblObstDetectHead
            // 
            this.lblObstDetectHead.AutoSize = true;
            this.lblObstDetectHead.Font = new System.Drawing.Font("Stencil", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObstDetectHead.Location = new System.Drawing.Point(21, 11);
            this.lblObstDetectHead.Name = "lblObstDetectHead";
            this.lblObstDetectHead.Size = new System.Drawing.Size(220, 24);
            this.lblObstDetectHead.TabIndex = 2;
            this.lblObstDetectHead.Text = "Obstacles Detected";
            // 
            // lvObjectsDetected
            // 
            this.lvObjectsDetected.HideSelection = false;
            this.lvObjectsDetected.Location = new System.Drawing.Point(3, 38);
            this.lvObjectsDetected.Name = "lvObjectsDetected";
            this.lvObjectsDetected.Size = new System.Drawing.Size(260, 256);
            this.lvObjectsDetected.TabIndex = 3;
            this.lvObjectsDetected.UseCompatibleStateImageBehavior = false;
            // 
            // ucObstaclesDetected
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Controls.Add(this.lvObjectsDetected);
            this.Controls.Add(this.lblObstDetectHead);
            this.Name = "ucObstaclesDetected";
            this.Size = new System.Drawing.Size(266, 297);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblObstDetectHead;
        private System.Windows.Forms.ListView lvObjectsDetected;
    }
}
