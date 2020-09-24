namespace PRG282_Project_LijaniVWDV_JohannesDW.Forms
{
    partial class InventoryScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryScreen));
            this.pnlOption1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnFinished = new System.Windows.Forms.Button();
            this.btnAddBomb = new System.Windows.Forms.Button();
            this.btnRemoveBomb = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvAllBombs = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.lblMaxWeight = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCunnectWeight = new System.Windows.Forms.Label();
            this.lblPlaneName = new System.Windows.Forms.Label();
            this.dgvCurrentInventory = new System.Windows.Forms.DataGridView();
            this.pnlOption1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllBombs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlOption1
            // 
            this.pnlOption1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(106)))), ((int)(((byte)(125)))), ((int)(((byte)(138)))));
            this.pnlOption1.Controls.Add(this.dgvCurrentInventory);
            this.pnlOption1.Controls.Add(this.btnCancel);
            this.pnlOption1.Controls.Add(this.btnFinished);
            this.pnlOption1.Controls.Add(this.btnAddBomb);
            this.pnlOption1.Controls.Add(this.btnRemoveBomb);
            this.pnlOption1.Controls.Add(this.label7);
            this.pnlOption1.Controls.Add(this.label6);
            this.pnlOption1.Controls.Add(this.dgvAllBombs);
            this.pnlOption1.Controls.Add(this.label9);
            this.pnlOption1.Controls.Add(this.lblMaxWeight);
            this.pnlOption1.Controls.Add(this.label1);
            this.pnlOption1.Controls.Add(this.lblCunnectWeight);
            this.pnlOption1.Controls.Add(this.lblPlaneName);
            this.pnlOption1.Location = new System.Drawing.Point(12, 12);
            this.pnlOption1.Name = "pnlOption1";
            this.pnlOption1.Size = new System.Drawing.Size(1130, 491);
            this.pnlOption1.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Stencil", 14F);
            this.btnCancel.Location = new System.Drawing.Point(413, 415);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(315, 40);
            this.btnCancel.TabIndex = 62;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnFinished
            // 
            this.btnFinished.Font = new System.Drawing.Font("Stencil", 14F);
            this.btnFinished.Location = new System.Drawing.Point(413, 369);
            this.btnFinished.Name = "btnFinished";
            this.btnFinished.Size = new System.Drawing.Size(315, 40);
            this.btnFinished.TabIndex = 61;
            this.btnFinished.Text = "Add All To Inventory";
            this.btnFinished.UseVisualStyleBackColor = true;
            this.btnFinished.Click += new System.EventHandler(this.btnFinished_Click);
            // 
            // btnAddBomb
            // 
            this.btnAddBomb.Font = new System.Drawing.Font("Stencil", 14F);
            this.btnAddBomb.Location = new System.Drawing.Point(413, 277);
            this.btnAddBomb.Name = "btnAddBomb";
            this.btnAddBomb.Size = new System.Drawing.Size(150, 40);
            this.btnAddBomb.TabIndex = 60;
            this.btnAddBomb.Text = "Add Bomb";
            this.btnAddBomb.UseVisualStyleBackColor = true;
            this.btnAddBomb.Click += new System.EventHandler(this.btnAddBomb_Click);
            // 
            // btnRemoveBomb
            // 
            this.btnRemoveBomb.Font = new System.Drawing.Font("Stencil", 14F);
            this.btnRemoveBomb.Location = new System.Drawing.Point(569, 277);
            this.btnRemoveBomb.Name = "btnRemoveBomb";
            this.btnRemoveBomb.Size = new System.Drawing.Size(159, 40);
            this.btnRemoveBomb.TabIndex = 59;
            this.btnRemoveBomb.Text = "Remove Bomb";
            this.btnRemoveBomb.UseVisualStyleBackColor = true;
            this.btnRemoveBomb.Click += new System.EventHandler(this.btnRemoveBomb_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(569, 49);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(547, 47);
            this.label7.TabIndex = 58;
            this.label7.Text = "Bombs In Inventory";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 49);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(547, 47);
            this.label6.TabIndex = 57;
            this.label6.Text = "Available Bombs";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvAllBombs
            // 
            this.dgvAllBombs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllBombs.Location = new System.Drawing.Point(16, 99);
            this.dgvAllBombs.Name = "dgvAllBombs";
            this.dgvAllBombs.RowHeadersWidth = 45;
            this.dgvAllBombs.Size = new System.Drawing.Size(547, 172);
            this.dgvAllBombs.TabIndex = 55;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(410, 320);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 23);
            this.label9.TabIndex = 51;
            this.label9.Text = "Max Weight:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMaxWeight
            // 
            this.lblMaxWeight.Location = new System.Drawing.Point(410, 343);
            this.lblMaxWeight.Name = "lblMaxWeight";
            this.lblMaxWeight.Size = new System.Drawing.Size(153, 23);
            this.lblMaxWeight.TabIndex = 52;
            this.lblMaxWeight.Text = "Max Weight";
            this.lblMaxWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(572, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 23);
            this.label1.TabIndex = 47;
            this.label1.Text = "Current Weight:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCunnectWeight
            // 
            this.lblCunnectWeight.Location = new System.Drawing.Point(572, 343);
            this.lblCunnectWeight.Name = "lblCunnectWeight";
            this.lblCunnectWeight.Size = new System.Drawing.Size(153, 23);
            this.lblCunnectWeight.TabIndex = 48;
            this.lblCunnectWeight.Text = "Current Weight";
            this.lblCunnectWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlaneName
            // 
            this.lblPlaneName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPlaneName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaneName.Location = new System.Drawing.Point(445, 2);
            this.lblPlaneName.Name = "lblPlaneName";
            this.lblPlaneName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPlaneName.Size = new System.Drawing.Size(231, 47);
            this.lblPlaneName.TabIndex = 0;
            this.lblPlaneName.Text = "planeName";
            this.lblPlaneName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvCurrentInventory
            // 
            this.dgvCurrentInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurrentInventory.Location = new System.Drawing.Point(569, 99);
            this.dgvCurrentInventory.Name = "dgvCurrentInventory";
            this.dgvCurrentInventory.RowHeadersWidth = 45;
            this.dgvCurrentInventory.Size = new System.Drawing.Size(547, 172);
            this.dgvCurrentInventory.TabIndex = 63;
            // 
            // InventoryScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1153, 518);
            this.Controls.Add(this.pnlOption1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InventoryScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Selection";
            this.Load += new System.EventHandler(this.InventoryScreen_Load);
            this.pnlOption1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllBombs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentInventory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOption1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCunnectWeight;
        private System.Windows.Forms.Label lblPlaneName;
        private System.Windows.Forms.Button btnRemoveBomb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvAllBombs;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblMaxWeight;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnFinished;
        private System.Windows.Forms.Button btnAddBomb;
        private System.Windows.Forms.DataGridView dgvCurrentInventory;
    }
}