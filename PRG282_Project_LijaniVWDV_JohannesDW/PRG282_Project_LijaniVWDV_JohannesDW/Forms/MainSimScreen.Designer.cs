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
            this.SuspendLayout();
            // 
            // ucGrid1
            // 
            this.ucGrid1.Location = new System.Drawing.Point(221, 13);
            this.ucGrid1.Name = "ucGrid1";
            this.ucGrid1.Size = new System.Drawing.Size(442, 377);
            this.ucGrid1.TabIndex = 0;
            // 
            // MainSimScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(932, 512);
            this.Controls.Add(this.ucGrid1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainSimScreen";
            this.Text = "SIM Screen";
            this.ResumeLayout(false);

        }

        #endregion

        private ucGrid ucGrid1;
    }
}