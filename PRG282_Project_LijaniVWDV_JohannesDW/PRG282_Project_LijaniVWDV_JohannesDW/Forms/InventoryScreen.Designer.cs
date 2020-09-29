namespace PRG282_Project_LijaniVWDV_JohannesDW.Forms
{
    partial class frmInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventory));
            this.pnlOption1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCurrentPoints = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMaxMountPoints = new System.Windows.Forms.Label();
            this.dgvCurrentInventory = new System.Windows.Forms.DataGridView();
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
            this.lblCurrentWeight = new System.Windows.Forms.Label();
            this.lblPlaneName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFlyRange = new System.Windows.Forms.Label();
            this.lblRangeremoved = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblRangeLeft = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pnlOption1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllBombs)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOption1
            // 
            this.pnlOption1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(106)))), ((int)(((byte)(125)))), ((int)(((byte)(138)))));
            this.pnlOption1.Controls.Add(this.panel1);
            this.pnlOption1.Controls.Add(this.label4);
            this.pnlOption1.Controls.Add(this.lblCurrentPoints);
            this.pnlOption1.Controls.Add(this.label2);
            this.pnlOption1.Controls.Add(this.lblMaxMountPoints);
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
            this.pnlOption1.Controls.Add(this.lblCurrentWeight);
            this.pnlOption1.Controls.Add(this.lblPlaneName);
            this.pnlOption1.Location = new System.Drawing.Point(12, 12);
            this.pnlOption1.Name = "pnlOption1";
            this.pnlOption1.Size = new System.Drawing.Size(1130, 543);
            this.pnlOption1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(572, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 23);
            this.label4.TabIndex = 66;
            this.label4.Text = "Current Mount Points:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCurrentPoints
            // 
            this.lblCurrentPoints.Location = new System.Drawing.Point(572, 400);
            this.lblCurrentPoints.Name = "lblCurrentPoints";
            this.lblCurrentPoints.Size = new System.Drawing.Size(153, 23);
            this.lblCurrentPoints.TabIndex = 67;
            this.lblCurrentPoints.Text = "Current Mount Points";
            this.lblCurrentPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(410, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 23);
            this.label2.TabIndex = 64;
            this.label2.Text = "Max Mount Points:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMaxMountPoints
            // 
            this.lblMaxMountPoints.Location = new System.Drawing.Point(410, 400);
            this.lblMaxMountPoints.Name = "lblMaxMountPoints";
            this.lblMaxMountPoints.Size = new System.Drawing.Size(153, 23);
            this.lblMaxMountPoints.TabIndex = 65;
            this.lblMaxMountPoints.Text = "Max Mount Points";
            this.lblMaxMountPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Stencil", 14F);
            this.btnCancel.Location = new System.Drawing.Point(410, 481);
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
            this.btnFinished.Location = new System.Drawing.Point(410, 435);
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
            // lblCurrentWeight
            // 
            this.lblCurrentWeight.Location = new System.Drawing.Point(572, 343);
            this.lblCurrentWeight.Name = "lblCurrentWeight";
            this.lblCurrentWeight.Size = new System.Drawing.Size(153, 23);
            this.lblCurrentWeight.TabIndex = 48;
            this.lblCurrentWeight.Text = "Current Weight";
            this.lblCurrentWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.lblRangeLeft);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.lblRangeremoved);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.lblFlyRange);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(735, 278);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 161);
            this.panel1.TabIndex = 68;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label3.Location = new System.Drawing.Point(4, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(385, 35);
            this.label3.TabIndex = 0;
            this.label3.Text = "Plane Possible Range";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Max Fly Range:";
            // 
            // lblFlyRange
            // 
            this.lblFlyRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlyRange.Location = new System.Drawing.Point(244, 43);
            this.lblFlyRange.Name = "lblFlyRange";
            this.lblFlyRange.Size = new System.Drawing.Size(128, 23);
            this.lblFlyRange.TabIndex = 2;
            this.lblFlyRange.Text = "Range";
            // 
            // lblRangeremoved
            // 
            this.lblRangeremoved.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRangeremoved.Location = new System.Drawing.Point(247, 77);
            this.lblRangeremoved.Name = "lblRangeremoved";
            this.lblRangeremoved.Size = new System.Drawing.Size(125, 23);
            this.lblRangeremoved.TabIndex = 4;
            this.lblRangeremoved.Text = "Range";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(21, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(217, 23);
            this.label11.TabIndex = 3;
            this.label11.Text = "Range Removed by Weight:";
            // 
            // lblRangeLeft
            // 
            this.lblRangeLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRangeLeft.Location = new System.Drawing.Point(250, 113);
            this.lblRangeLeft.Name = "lblRangeLeft";
            this.lblRangeLeft.Size = new System.Drawing.Size(122, 23);
            this.lblRangeLeft.TabIndex = 6;
            this.lblRangeLeft.Text = "Range";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(21, 113);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(217, 23);
            this.label13.TabIndex = 5;
            this.label13.Text = "Total Range Left:";
            // 
            // InventoryScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1153, 570);
            this.Controls.Add(this.pnlOption1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InventoryScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Selection";
            this.Load += new System.EventHandler(this.InventoryScreen_Load);
            this.pnlOption1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllBombs)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOption1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCurrentWeight;
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCurrentPoints;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMaxMountPoints;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRangeLeft;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblRangeremoved;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblFlyRange;
    }
}