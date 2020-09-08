namespace PRG282_Project_LijaniVWDV_JohannesDW
{
    partial class frmIntro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIntro));
            this.lblMainHeading = new System.Windows.Forms.Label();
            this.lblSubHeading = new System.Windows.Forms.Label();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMainHeading
            // 
            this.lblMainHeading.AutoSize = true;
            this.lblMainHeading.BackColor = System.Drawing.Color.Black;
            this.lblMainHeading.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblMainHeading.Font = new System.Drawing.Font("Stencil", 55F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainHeading.ForeColor = System.Drawing.Color.White;
            this.lblMainHeading.Location = new System.Drawing.Point(-109, 9);
            this.lblMainHeading.Font = new System.Drawing.Font("Gadugi", 55F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainHeading.ForeColor = System.Drawing.Color.Gray;
            this.lblMainHeading.Location = new System.Drawing.Point(-29, 9);
            this.lblMainHeading.Name = "lblMainHeading";
            this.lblMainHeading.Size = new System.Drawing.Size(1201, 87);
            this.lblMainHeading.TabIndex = 0;
            this.lblMainHeading.Text = "        Military Simulator           ";
            this.lblMainHeading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblSubHeading
            // 
            this.lblSubHeading.AutoSize = true;
            this.lblSubHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblSubHeading.Font = new System.Drawing.Font("Gadugi", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubHeading.ForeColor = System.Drawing.Color.White;
            this.lblSubHeading.Location = new System.Drawing.Point(193, 492);
            this.lblSubHeading.Name = "lblSubHeading";
            this.lblSubHeading.Size = new System.Drawing.Size(520, 31);
            this.lblSubHeading.TabIndex = 1;
            this.lblSubHeading.Text = "Lijani van Wyk de Vries + Johannes de Wet";
            this.lblSubHeading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnLaunch
            // 
            this.btnLaunch.BackColor = System.Drawing.Color.Black;
            this.btnLaunch.Font = new System.Drawing.Font("Stencil", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaunch.ForeColor = System.Drawing.Color.White;
            this.btnLaunch.Location = new System.Drawing.Point(293, 220);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(271, 111);
            this.btnLaunch.TabIndex = 2;
            this.btnLaunch.Text = "L A U N C H";
            this.btnLaunch.UseVisualStyleBackColor = false;
            // 
            // frmIntro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(889, 532);
            this.Controls.Add(this.btnLaunch);
            this.Controls.Add(this.lblSubHeading);
            this.Controls.Add(this.lblMainHeading);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmIntro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Military Simulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMainHeading;
        private System.Windows.Forms.Label lblSubHeading;
        private System.Windows.Forms.Button btnLaunch;
    }
}

