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
            this.pbPlaneUsed = new System.Windows.Forms.PictureBox();
            this.txtPlaneName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblObstacles = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lblReportHeading = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lvDamageAnalysis = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lvStrikesAnalysis = new System.Windows.Forms.ListView();
            this.lblStrikes = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.listView3 = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.listView4 = new System.Windows.Forms.ListView();
            this.listView5 = new System.Windows.Forms.ListView();
            this.listView6 = new System.Windows.Forms.ListView();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlPlaneNameAnePicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlaneUsed)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPlaneNameAnePicture
            // 
            this.pnlPlaneNameAnePicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.pnlPlaneNameAnePicture.Controls.Add(this.listView4);
            this.pnlPlaneNameAnePicture.Controls.Add(this.pbPlaneUsed);
            this.pnlPlaneNameAnePicture.Controls.Add(this.txtPlaneName);
            this.pnlPlaneNameAnePicture.Location = new System.Drawing.Point(12, 106);
            this.pnlPlaneNameAnePicture.Name = "pnlPlaneNameAnePicture";
            this.pnlPlaneNameAnePicture.Size = new System.Drawing.Size(235, 401);
            this.pnlPlaneNameAnePicture.TabIndex = 0;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.listView6);
            this.panel1.Controls.Add(this.lblObstacles);
            this.panel1.Location = new System.Drawing.Point(524, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 401);
            this.panel1.TabIndex = 1;
            // 
            // lblObstacles
            // 
            this.lblObstacles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblObstacles.Font = new System.Drawing.Font("Stencil", 13F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObstacles.ForeColor = System.Drawing.Color.White;
            this.lblObstacles.Location = new System.Drawing.Point(3, 0);
            this.lblObstacles.Name = "lblObstacles";
            this.lblObstacles.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblObstacles.Size = new System.Drawing.Size(229, 28);
            this.lblObstacles.TabIndex = 0;
            this.lblObstacles.Text = "Obstacles Identified";
            this.lblObstacles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.panel6.Controls.Add(this.listView1);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(1032, 106);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(235, 187);
            this.panel6.TabIndex = 5;
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
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.panel7.Controls.Add(this.listView5);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Location = new System.Drawing.Point(765, 106);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(235, 401);
            this.panel7.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Font = new System.Drawing.Font("Stencil", 13F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(229, 28);
            this.label7.TabIndex = 0;
            this.label7.Text = "Obstacles Avoided";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblReportHeading
            // 
            this.lblReportHeading.AutoSize = true;
            this.lblReportHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblReportHeading.Font = new System.Drawing.Font("Stencil", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportHeading.ForeColor = System.Drawing.Color.White;
            this.lblReportHeading.Location = new System.Drawing.Point(384, 9);
            this.lblReportHeading.Name = "lblReportHeading";
            this.lblReportHeading.Size = new System.Drawing.Size(551, 80);
            this.lblReportHeading.TabIndex = 7;
            this.lblReportHeading.Text = "Status Report";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.panel3.Controls.Add(this.lvDamageAnalysis);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(604, 528);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(551, 263);
            this.panel3.TabIndex = 4;
            // 
            // lvDamageAnalysis
            // 
            this.lvDamageAnalysis.HideSelection = false;
            this.lvDamageAnalysis.Location = new System.Drawing.Point(26, 43);
            this.lvDamageAnalysis.Name = "lvDamageAnalysis";
            this.lvDamageAnalysis.Size = new System.Drawing.Size(489, 192);
            this.lvDamageAnalysis.TabIndex = 4;
            this.lvDamageAnalysis.UseCompatibleStateImageBehavior = false;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.panel2.Controls.Add(this.lvStrikesAnalysis);
            this.panel2.Controls.Add(this.lblStrikes);
            this.panel2.Location = new System.Drawing.Point(30, 528);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(551, 263);
            this.panel2.TabIndex = 5;
            // 
            // lvStrikesAnalysis
            // 
            this.lvStrikesAnalysis.HideSelection = false;
            this.lvStrikesAnalysis.Location = new System.Drawing.Point(26, 43);
            this.lvStrikesAnalysis.Name = "lvStrikesAnalysis";
            this.lvStrikesAnalysis.Size = new System.Drawing.Size(501, 192);
            this.lvStrikesAnalysis.TabIndex = 4;
            this.lvStrikesAnalysis.UseCompatibleStateImageBehavior = false;
            // 
            // lblStrikes
            // 
            this.lblStrikes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblStrikes.Font = new System.Drawing.Font("Stencil", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStrikes.ForeColor = System.Drawing.Color.White;
            this.lblStrikes.Location = new System.Drawing.Point(131, 0);
            this.lblStrikes.Name = "lblStrikes";
            this.lblStrikes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblStrikes.Size = new System.Drawing.Size(229, 28);
            this.lblStrikes.TabIndex = 3;
            this.lblStrikes.Text = "Strike Analysis";
            this.lblStrikes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.panel4.Controls.Add(this.listView2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(1032, 320);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(235, 187);
            this.panel4.TabIndex = 6;
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
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(23, 41);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(195, 130);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(23, 41);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(195, 130);
            this.listView2.TabIndex = 2;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.panel5.Controls.Add(this.listView3);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(267, 106);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(235, 401);
            this.panel5.TabIndex = 6;
            // 
            // listView3
            // 
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(23, 41);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(195, 344);
            this.listView3.TabIndex = 1;
            this.listView3.UseCompatibleStateImageBehavior = false;
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
            // listView4
            // 
            this.listView4.HideSelection = false;
            this.listView4.Location = new System.Drawing.Point(18, 242);
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(195, 130);
            this.listView4.TabIndex = 2;
            this.listView4.UseCompatibleStateImageBehavior = false;
            // 
            // listView5
            // 
            this.listView5.HideSelection = false;
            this.listView5.Location = new System.Drawing.Point(16, 41);
            this.listView5.Name = "listView5";
            this.listView5.Size = new System.Drawing.Size(195, 344);
            this.listView5.TabIndex = 2;
            this.listView5.UseCompatibleStateImageBehavior = false;
            // 
            // listView6
            // 
            this.listView6.HideSelection = false;
            this.listView6.Location = new System.Drawing.Point(20, 41);
            this.listView6.Name = "listView6";
            this.listView6.Size = new System.Drawing.Size(195, 344);
            this.listView6.TabIndex = 3;
            this.listView6.UseCompatibleStateImageBehavior = false;
            // 
            // btnLaunch
            // 
            this.btnLaunch.BackColor = System.Drawing.Color.Black;
            this.btnLaunch.Font = new System.Drawing.Font("Stencil", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaunch.ForeColor = System.Drawing.Color.White;
            this.btnLaunch.Location = new System.Drawing.Point(1161, 714);
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
            this.button1.Location = new System.Drawing.Point(1161, 631);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 77);
            this.button1.TabIndex = 8;
            this.button1.Text = "H O M E";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1298, 816);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLaunch);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblReportHeading);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.pnlPlaneNameAnePicture);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.pnlPlaneNameAnePicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlaneUsed)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlPlaneNameAnePicture;
        private System.Windows.Forms.Label txtPlaneName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblObstacles;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pbPlaneUsed;
        private System.Windows.Forms.Label lblReportHeading;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView lvDamageAnalysis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lvStrikesAnalysis;
        private System.Windows.Forms.Label lblStrikes;
        private System.Windows.Forms.ListView listView4;
        private System.Windows.Forms.ListView listView6;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.Button button1;
    }
}