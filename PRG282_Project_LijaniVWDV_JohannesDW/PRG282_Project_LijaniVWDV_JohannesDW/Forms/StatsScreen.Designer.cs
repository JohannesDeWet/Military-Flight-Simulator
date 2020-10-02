using System.Drawing;

namespace PRG282_Project_LijaniVWDV_JohannesDW.Forms
{
    partial class frmReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReport));
            this.pnlPlaneNameAnePicture = new System.Windows.Forms.Panel();
            this.lstBombs = new System.Windows.Forms.ListView();
            this.CHBomb = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pbPlaneUsed = new System.Windows.Forms.PictureBox();
            this.txtPlaneName = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.CBTarget = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.lblReportHeading = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblDamagePercentage = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblMaxDamage = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDamageDone = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.listView2 = new System.Windows.Forms.ListView();
            this.CHTarget = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lstPostRun = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.PlaneName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Range = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Speed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Altitude = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RangeTravelled = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlPlaneNameAnePicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlaneUsed)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPlaneNameAnePicture
            // 
            this.pnlPlaneNameAnePicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.pnlPlaneNameAnePicture.Controls.Add(this.lstBombs);
            this.pnlPlaneNameAnePicture.Controls.Add(this.pbPlaneUsed);
            this.pnlPlaneNameAnePicture.Controls.Add(this.txtPlaneName);
            this.pnlPlaneNameAnePicture.Location = new System.Drawing.Point(12, 106);
            this.pnlPlaneNameAnePicture.Name = "pnlPlaneNameAnePicture";
            this.pnlPlaneNameAnePicture.Size = new System.Drawing.Size(235, 401);
            this.pnlPlaneNameAnePicture.TabIndex = 0;
            // 
            // lstBombs
            // 
            this.lstBombs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CHBomb});
            this.lstBombs.HideSelection = false;
            this.lstBombs.Location = new System.Drawing.Point(18, 242);
            this.lstBombs.Name = "lstBombs";
            this.lstBombs.Size = new System.Drawing.Size(195, 130);
            this.lstBombs.TabIndex = 2;
            this.lstBombs.UseCompatibleStateImageBehavior = false;
            this.lstBombs.View = System.Windows.Forms.View.Details;
            // 
            // CHBomb
            // 
            this.CHBomb.Text = "Bombs";
            this.CHBomb.Width = 200;
            // 
            // pbPlaneUsed
            // 
            this.pbPlaneUsed.Location = new System.Drawing.Point(0, 50);
            this.pbPlaneUsed.Name = "pbPlaneUsed";
            this.pbPlaneUsed.Size = new System.Drawing.Size(235, 172);
            this.pbPlaneUsed.TabIndex = 1;
            this.pbPlaneUsed.TabStop = false;
            // 
            // txtPlaneName
            // 
            this.txtPlaneName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtPlaneName.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaneName.ForeColor = System.Drawing.Color.White;
            this.txtPlaneName.Location = new System.Drawing.Point(3, 0);
            this.txtPlaneName.Name = "txtPlaneName";
            this.txtPlaneName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPlaneName.Size = new System.Drawing.Size(229, 47);
            this.txtPlaneName.TabIndex = 0;
            this.txtPlaneName.Text = "planeName";
            this.txtPlaneName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.panel6.Controls.Add(this.listView1);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(879, 106);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(235, 187);
            this.panel6.TabIndex = 5;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CBTarget});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(23, 41);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(195, 130);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // CBTarget
            // 
            this.CBTarget.Text = "Target";
            this.CBTarget.Width = 200;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Font = new System.Drawing.Font("Stencil", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(229, 28);
            this.label6.TabIndex = 0;
            this.label6.Text = "Targets Identified";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblReportHeading
            // 
            this.lblReportHeading.AutoSize = true;
            this.lblReportHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblReportHeading.Font = new System.Drawing.Font("Stencil", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportHeading.ForeColor = System.Drawing.Color.White;
            this.lblReportHeading.Location = new System.Drawing.Point(149, 9);
            this.lblReportHeading.Name = "lblReportHeading";
            this.lblReportHeading.Size = new System.Drawing.Size(551, 80);
            this.lblReportHeading.TabIndex = 7;
            this.lblReportHeading.Text = "Status Report";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.panel3.Controls.Add(this.lblDamagePercentage);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.lblMaxDamage);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.lblDamageDone);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(12, 528);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(551, 263);
            this.panel3.TabIndex = 4;
            // 
            // lblDamagePercentage
            // 
            this.lblDamagePercentage.Location = new System.Drawing.Point(292, 103);
            this.lblDamagePercentage.Name = "lblDamagePercentage";
            this.lblDamagePercentage.Size = new System.Drawing.Size(100, 23);
            this.lblDamagePercentage.TabIndex = 9;
            this.lblDamagePercentage.Text = "Damage Done";
            this.lblDamagePercentage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(292, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 8;
            this.label9.Text = "DamagePercentage";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMaxDamage
            // 
            this.lblMaxDamage.Location = new System.Drawing.Point(53, 103);
            this.lblMaxDamage.Name = "lblMaxDamage";
            this.lblMaxDamage.Size = new System.Drawing.Size(100, 23);
            this.lblMaxDamage.TabIndex = 7;
            this.lblMaxDamage.Text = "Damage Done";
            this.lblMaxDamage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(174, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Damage Done";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDamageDone
            // 
            this.lblDamageDone.Location = new System.Drawing.Point(174, 103);
            this.lblDamageDone.Name = "lblDamageDone";
            this.lblDamageDone.Size = new System.Drawing.Size(100, 23);
            this.lblDamageDone.TabIndex = 5;
            this.lblDamageDone.Text = "Damage Done";
            this.lblDamageDone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(50, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Max Damage";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Stencil", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(121, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(229, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Damage Analysis";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.panel4.Controls.Add(this.listView2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(879, 320);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(235, 187);
            this.panel4.TabIndex = 6;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CHTarget});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(23, 41);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(195, 130);
            this.listView2.TabIndex = 2;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // CHTarget
            // 
            this.CHTarget.Text = "Target";
            this.CHTarget.Width = 200;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Stencil", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(229, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Targets Chosen";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.panel5.Controls.Add(this.lstPostRun);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(267, 106);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(563, 401);
            this.panel5.TabIndex = 6;
            // 
            // lstPostRun
            // 
            this.lstPostRun.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PlaneName,
            this.Speed,
            this.Range,
            this.Altitude,
            this.RangeTravelled});
            this.lstPostRun.HideSelection = false;
            this.lstPostRun.Location = new System.Drawing.Point(23, 41);
            this.lstPostRun.Name = "lstPostRun";
            this.lstPostRun.Size = new System.Drawing.Size(510, 344);
            this.lstPostRun.TabIndex = 1;
            this.lstPostRun.UseCompatibleStateImageBehavior = false;
            this.lstPostRun.View = System.Windows.Forms.View.Details;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Stencil", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(229, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Post Run Stats";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLaunch
            // 
            this.btnLaunch.BackColor = System.Drawing.Color.Black;
            this.btnLaunch.Font = new System.Drawing.Font("Stencil", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaunch.ForeColor = System.Drawing.Color.White;
            this.btnLaunch.Location = new System.Drawing.Point(969, 667);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(128, 77);
            this.btnLaunch.TabIndex = 3;
            this.btnLaunch.Text = "E X I T";
            this.btnLaunch.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Stencil", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(969, 565);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 77);
            this.button1.TabIndex = 8;
            this.button1.Text = "H O M E";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // PlaneName
            // 
            this.PlaneName.Text = "Plane Name";
            this.PlaneName.Width = 95;
            // 
            // Range
            // 
            this.Range.DisplayIndex = 1;
            this.Range.Text = "Range";
            this.Range.Width = 73;
            // 
            // Speed
            // 
            this.Speed.DisplayIndex = 2;
            this.Speed.Text = "Speed";
            this.Speed.Width = 70;
            // 
            // Altitude
            // 
            this.Altitude.Text = "Altitude";
            this.Altitude.Width = 80;
            // 
            // RangeTravelled
            // 
            this.RangeTravelled.Text = "Range Travelled";
            this.RangeTravelled.Width = 121;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1185, 808);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLaunch);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblReportHeading);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.pnlPlaneNameAnePicture);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.Load += new System.EventHandler(this.frmReport_Load);
            this.pnlPlaneNameAnePicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlaneUsed)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlPlaneNameAnePicture;
        private System.Windows.Forms.Label txtPlaneName;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pbPlaneUsed;
        private System.Windows.Forms.Label lblReportHeading;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lstBombs;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ListView lstPostRun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblDamagePercentage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblMaxDamage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDamageDone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader CHBomb;
        private System.Windows.Forms.ColumnHeader CBTarget;
        private System.Windows.Forms.ColumnHeader CHTarget;
        private System.Windows.Forms.ColumnHeader PlaneName;
        private System.Windows.Forms.ColumnHeader Speed;
        private System.Windows.Forms.ColumnHeader Range;
        private System.Windows.Forms.ColumnHeader Altitude;
        private System.Windows.Forms.ColumnHeader RangeTravelled;
    }
}