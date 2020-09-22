namespace ProductInventory
{
    partial class frmProducts
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
            this.label1 = new System.Windows.Forms.Label();
            this.lstCustomers = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlUsage = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblUsagePeriod = new System.Windows.Forms.Label();
            this.txtElectricityKWh = new System.Windows.Forms.TextBox();
            this.lblElectricityKWh = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.lblCustomerCount = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.lblTotalRKWh = new System.Windows.Forms.Label();
            this.lblTotalCKWh = new System.Windows.Forms.Label();
            this.lblTotaIKWh = new System.Windows.Forms.Label();
            this.txtTotalRKWh = new System.Windows.Forms.TextBox();
            this.txtTotalCKWh = new System.Windows.Forms.TextBox();
            this.txtTotalIKWh = new System.Windows.Forms.TextBox();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.txtCustomerBill = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.pnlUsage.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(620, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customers:";
            // 
            // lstCustomers
            // 
            this.lstCustomers.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCustomers.FormattingEnabled = true;
            this.lstCustomers.ItemHeight = 26;
            this.lstCustomers.Location = new System.Drawing.Point(617, 46);
            this.lstCustomers.Name = "lstCustomers";
            this.lstCustomers.Size = new System.Drawing.Size(242, 342);
            this.lstCustomers.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnlUsage);
            this.groupBox1.Controls.Add(this.txtElectricityKWh);
            this.groupBox1.Controls.Add(this.lblElectricityKWh);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.txtAccountNumber);
            this.groupBox1.Controls.Add(this.lblAccountNumber);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCustomerName);
            this.groupBox1.Controls.Add(this.lblCustomerName);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(599, 215);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Customer";
            // 
            // pnlUsage
            // 
            this.pnlUsage.Controls.Add(this.comboBox2);
            this.pnlUsage.Controls.Add(this.lblUsagePeriod);
            this.pnlUsage.Location = new System.Drawing.Point(322, 69);
            this.pnlUsage.Name = "pnlUsage";
            this.pnlUsage.Size = new System.Drawing.Size(272, 56);
            this.pnlUsage.TabIndex = 19;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Peak hours",
            "Off-peak hours"});
            this.comboBox2.Location = new System.Drawing.Point(136, 9);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(133, 34);
            this.comboBox2.TabIndex = 9;
            this.comboBox2.Tag = "Usage Period";
            // 
            // lblUsagePeriod
            // 
            this.lblUsagePeriod.Location = new System.Drawing.Point(5, 13);
            this.lblUsagePeriod.Name = "lblUsagePeriod";
            this.lblUsagePeriod.Size = new System.Drawing.Size(135, 24);
            this.lblUsagePeriod.TabIndex = 10;
            this.lblUsagePeriod.Text = "Usage Period:";
            // 
            // txtElectricityKWh
            // 
            this.txtElectricityKWh.Location = new System.Drawing.Point(189, 172);
            this.txtElectricityKWh.Name = "txtElectricityKWh";
            this.txtElectricityKWh.Size = new System.Drawing.Size(312, 33);
            this.txtElectricityKWh.TabIndex = 10;
            this.txtElectricityKWh.Tag = "Electricity in KWh";
            // 
            // lblElectricityKWh
            // 
            this.lblElectricityKWh.AutoSize = true;
            this.lblElectricityKWh.Location = new System.Drawing.Point(2, 175);
            this.lblElectricityKWh.Name = "lblElectricityKWh";
            this.lblElectricityKWh.Size = new System.Drawing.Size(180, 26);
            this.lblElectricityKWh.TabIndex = 9;
            this.lblElectricityKWh.Text = "Electricity in KWh:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "R",
            "C",
            "I"});
            this.comboBox1.Location = new System.Drawing.Point(189, 79);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(130, 34);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.Tag = "Customer Type";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(189, 131);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(312, 33);
            this.txtAccountNumber.TabIndex = 5;
            this.txtAccountNumber.Tag = "Account Number";
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Location = new System.Drawing.Point(2, 134);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(171, 26);
            this.lblAccountNumber.TabIndex = 3;
            this.lblAccountNumber.Text = "Account Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customer Type:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(189, 31);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(400, 33);
            this.txtCustomerName.TabIndex = 1;
            this.txtCustomerName.Tag = "Customer Name";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(3, 34);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(164, 26);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "Customer Name:";
            // 
            // BtnClear
            // 
            this.BtnClear.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.Location = new System.Drawing.Point(526, 189);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(75, 34);
            this.BtnClear.TabIndex = 7;
            this.BtnClear.Text = "&Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Location = new System.Drawing.Point(525, 146);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(76, 37);
            this.BtnAdd.TabIndex = 6;
            this.BtnAdd.Text = "&Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblCustomerCount
            // 
            this.lblCustomerCount.AutoSize = true;
            this.lblCustomerCount.Location = new System.Drawing.Point(128, 286);
            this.lblCustomerCount.Name = "lblCustomerCount";
            this.lblCustomerCount.Size = new System.Drawing.Size(120, 24);
            this.lblCustomerCount.TabIndex = 3;
            this.lblCustomerCount.Text = "# Customers:";
            // 
            // lblCount
            // 
            this.lblCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCount.Location = new System.Drawing.Point(273, 282);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(94, 32);
            this.lblCount.TabIndex = 4;
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Location = new System.Drawing.Point(496, 374);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(100, 32);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(299, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 26);
            this.label6.TabIndex = 6;
            this.label6.Text = "Sum of All Charges:";
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(105, 373);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(99, 40);
            this.BtnDelete.TabIndex = 8;
            this.BtnDelete.Text = "&Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblTotalRKWh
            // 
            this.lblTotalRKWh.AutoSize = true;
            this.lblTotalRKWh.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRKWh.Location = new System.Drawing.Point(369, 246);
            this.lblTotalRKWh.Name = "lblTotalRKWh";
            this.lblTotalRKWh.Size = new System.Drawing.Size(131, 26);
            this.lblTotalRKWh.TabIndex = 11;
            this.lblTotalRKWh.Text = "TotalR(KWh)";
            // 
            // lblTotalCKWh
            // 
            this.lblTotalCKWh.AutoSize = true;
            this.lblTotalCKWh.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCKWh.Location = new System.Drawing.Point(369, 286);
            this.lblTotalCKWh.Name = "lblTotalCKWh";
            this.lblTotalCKWh.Size = new System.Drawing.Size(131, 26);
            this.lblTotalCKWh.TabIndex = 12;
            this.lblTotalCKWh.Text = "TotalC(KWh)";
            // 
            // lblTotaIKWh
            // 
            this.lblTotaIKWh.AutoSize = true;
            this.lblTotaIKWh.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotaIKWh.Location = new System.Drawing.Point(370, 329);
            this.lblTotaIKWh.Name = "lblTotaIKWh";
            this.lblTotaIKWh.Size = new System.Drawing.Size(124, 26);
            this.lblTotaIKWh.TabIndex = 13;
            this.lblTotaIKWh.Text = "TotalI(KWh)";
            // 
            // txtTotalRKWh
            // 
            this.txtTotalRKWh.Location = new System.Drawing.Point(496, 244);
            this.txtTotalRKWh.Name = "txtTotalRKWh";
            this.txtTotalRKWh.Size = new System.Drawing.Size(100, 29);
            this.txtTotalRKWh.TabIndex = 14;
            this.txtTotalRKWh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotalCKWh
            // 
            this.txtTotalCKWh.Location = new System.Drawing.Point(496, 284);
            this.txtTotalCKWh.Name = "txtTotalCKWh";
            this.txtTotalCKWh.Size = new System.Drawing.Size(100, 29);
            this.txtTotalCKWh.TabIndex = 15;
            this.txtTotalCKWh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotalIKWh
            // 
            this.txtTotalIKWh.Location = new System.Drawing.Point(496, 327);
            this.txtTotalIKWh.Name = "txtTotalIKWh";
            this.txtTotalIKWh.Size = new System.Drawing.Size(100, 29);
            this.txtTotalIKWh.TabIndex = 16;
            this.txtTotalIKWh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalculate.Location = new System.Drawing.Point(13, 242);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(108, 39);
            this.BtnCalculate.TabIndex = 17;
            this.BtnCalculate.Text = "Calculate";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtCustomerBill
            // 
            this.txtCustomerBill.Location = new System.Drawing.Point(267, 245);
            this.txtCustomerBill.Name = "txtCustomerBill";
            this.txtCustomerBill.Size = new System.Drawing.Size(100, 29);
            this.txtCustomerBill.TabIndex = 18;
            this.txtCustomerBill.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(127, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 35);
            this.label2.TabIndex = 19;
            this.label2.Text = "Calc. Charge:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(9, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(339, 39);
            this.label4.TabIndex = 20;
            this.label4.Text = "Please select Customer to be deleted:";
            // 
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(871, 425);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCustomerBill);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.txtTotalIKWh);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.txtTotalCKWh);
            this.Controls.Add(this.txtTotalRKWh);
            this.Controls.Add(this.lblTotaIKWh);
            this.Controls.Add(this.lblTotalCKWh);
            this.Controls.Add(this.lblTotalRKWh);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblCustomerCount);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstCustomers);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmProducts";
            this.Text = "Electricity Bill Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmProducts_FormClosing);
            this.Load += new System.EventHandler(this.frmProducts_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlUsage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstCustomers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCustomerCount;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtElectricityKWh;
        private System.Windows.Forms.Label lblElectricityKWh;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblUsagePeriod;
        private System.Windows.Forms.Label lblTotalRKWh;
        private System.Windows.Forms.Label lblTotalCKWh;
        private System.Windows.Forms.Label lblTotaIKWh;
        private System.Windows.Forms.TextBox txtTotalRKWh;
        private System.Windows.Forms.TextBox txtTotalCKWh;
        private System.Windows.Forms.TextBox txtTotalIKWh;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.TextBox txtCustomerBill;
        private System.Windows.Forms.Panel pnlUsage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}

