namespace PRG282_Project_LijaniVWDV_JohannesDW.Forms
{
    partial class frmLoginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoginScreen));
            this.btnAdmin = new System.Windows.Forms.Button();
            this.pnlPlaneNameAnePicture = new System.Windows.Forms.Panel();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEditPlane = new System.Windows.Forms.Button();
            this.btnEditAdmins = new System.Windows.Forms.Button();
            this.pnlPlaneNameAnePicture.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.Black;
            this.btnAdmin.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAdmin.Location = new System.Drawing.Point(250, 237);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(271, 36);
            this.btnAdmin.TabIndex = 4;
            this.btnAdmin.Text = "L O G I N  A D M I N";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // pnlPlaneNameAnePicture
            // 
            this.pnlPlaneNameAnePicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.pnlPlaneNameAnePicture.Controls.Add(this.txtPassWord);
            this.pnlPlaneNameAnePicture.Controls.Add(this.label1);
            this.pnlPlaneNameAnePicture.Controls.Add(this.txtUsername);
            this.pnlPlaneNameAnePicture.Controls.Add(this.lblUserName);
            this.pnlPlaneNameAnePicture.Location = new System.Drawing.Point(274, 59);
            this.pnlPlaneNameAnePicture.Name = "pnlPlaneNameAnePicture";
            this.pnlPlaneNameAnePicture.Size = new System.Drawing.Size(235, 172);
            this.pnlPlaneNameAnePicture.TabIndex = 5;
            // 
            // txtPassWord
            // 
            this.txtPassWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.txtPassWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassWord.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassWord.Location = new System.Drawing.Point(4, 135);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(228, 23);
            this.txtPassWord.TabIndex = 3;
            this.txtPassWord.Text = "1234";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.label1.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 84);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(229, 47);
            this.label1.TabIndex = 2;
            this.label1.Text = "PassWord";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(4, 51);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(228, 23);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.Text = "matin";
            // 
            // lblUserName
            // 
            this.lblUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.lblUserName.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(3, 1);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblUserName.Size = new System.Drawing.Size(229, 47);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "User Name";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.label2.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(231, 9);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(310, 47);
            this.label2.TabIndex = 4;
            this.label2.Text = "A D M I N  L O G I N";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEditPlane
            // 
            this.btnEditPlane.BackColor = System.Drawing.Color.Black;
            this.btnEditPlane.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditPlane.ForeColor = System.Drawing.Color.White;
            this.btnEditPlane.Location = new System.Drawing.Point(250, 319);
            this.btnEditPlane.Name = "btnEditPlane";
            this.btnEditPlane.Size = new System.Drawing.Size(271, 36);
            this.btnEditPlane.TabIndex = 6;
            this.btnEditPlane.Text = "E D I T  P L A N E S";
            this.btnEditPlane.UseVisualStyleBackColor = false;
            this.btnEditPlane.Click += new System.EventHandler(this.btnEditPlane_Click);
            // 
            // btnEditAdmins
            // 
            this.btnEditAdmins.BackColor = System.Drawing.Color.Black;
            this.btnEditAdmins.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditAdmins.ForeColor = System.Drawing.Color.White;
            this.btnEditAdmins.Location = new System.Drawing.Point(250, 277);
            this.btnEditAdmins.Name = "btnEditAdmins";
            this.btnEditAdmins.Size = new System.Drawing.Size(271, 36);
            this.btnEditAdmins.TabIndex = 7;
            this.btnEditAdmins.Text = "E D I T  A D M I N";
            this.btnEditAdmins.UseVisualStyleBackColor = false;
            this.btnEditAdmins.Click += new System.EventHandler(this.btnEditAdmins_Click);
            // 
            // frmLoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(765, 372);
            this.Controls.Add(this.btnEditAdmins);
            this.Controls.Add(this.btnEditPlane);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlPlaneNameAnePicture);
            this.Controls.Add(this.btnAdmin);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLoginScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Login";
            this.pnlPlaneNameAnePicture.ResumeLayout(false);
            this.pnlPlaneNameAnePicture.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Panel pnlPlaneNameAnePicture;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEditPlane;
        private System.Windows.Forms.Button btnEditAdmins;
    }
}