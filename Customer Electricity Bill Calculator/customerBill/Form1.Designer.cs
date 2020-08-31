namespace customerBill
{
    partial class FrmElectricity
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblElectricity = new System.Windows.Forms.Label();
            this.txtElectricity = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblCharge = new System.Windows.Forms.Label();
            this.txtCustomerBill = new System.Windows.Forms.TextBox();
            this.lblCustomerType = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pnlUsage = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblUsageperiod = new System.Windows.Forms.Label();
            this.pnlUsage.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblElectricity
            // 
            this.lblElectricity.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblElectricity.Location = new System.Drawing.Point(12, 133);
            this.lblElectricity.Name = "lblElectricity";
            this.lblElectricity.Size = new System.Drawing.Size(108, 23);
            this.lblElectricity.TabIndex = 0;
            this.lblElectricity.Text = "Electricity in KWh:";
            this.lblElectricity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtElectricity
            // 
            this.txtElectricity.Location = new System.Drawing.Point(126, 132);
            this.txtElectricity.Name = "txtElectricity";
            this.txtElectricity.Size = new System.Drawing.Size(201, 23);
            this.txtElectricity.TabIndex = 3;
            this.txtElectricity.Tag = "Electricity in KWh";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalculate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCalculate.Location = new System.Drawing.Point(23, 183);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Location = new System.Drawing.Point(144, 183);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(245, 183);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblCharge
            // 
            this.lblCharge.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCharge.Location = new System.Drawing.Point(12, 228);
            this.lblCharge.Name = "lblCharge";
            this.lblCharge.Size = new System.Drawing.Size(114, 23);
            this.lblCharge.TabIndex = 5;
            this.lblCharge.Text = "Customer Bill:";
            this.lblCharge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCustomerBill
            // 
            this.txtCustomerBill.Location = new System.Drawing.Point(125, 227);
            this.txtCustomerBill.Name = "txtCustomerBill";
            this.txtCustomerBill.ReadOnly = true;
            this.txtCustomerBill.Size = new System.Drawing.Size(202, 23);
            this.txtCustomerBill.TabIndex = 7;
            // 
            // lblCustomerType
            // 
            this.lblCustomerType.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCustomerType.Location = new System.Drawing.Point(14, 25);
            this.lblCustomerType.Name = "lblCustomerType";
            this.lblCustomerType.Size = new System.Drawing.Size(100, 23);
            this.lblCustomerType.TabIndex = 7;
            this.lblCustomerType.Text = "Customer Type:";
            this.lblCustomerType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Residential",
            "Commercial",
            "Industrial"});
            this.comboBox1.Location = new System.Drawing.Point(126, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(201, 28);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Tag = "Customer Type";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pnlUsage
            // 
            this.pnlUsage.Controls.Add(this.comboBox2);
            this.pnlUsage.Controls.Add(this.lblUsageperiod);
            this.pnlUsage.Location = new System.Drawing.Point(14, 65);
            this.pnlUsage.Name = "pnlUsage";
            this.pnlUsage.Size = new System.Drawing.Size(357, 43);
            this.pnlUsage.TabIndex = 9;
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Peak hours",
            "Off-peak hours"});
            this.comboBox2.Location = new System.Drawing.Point(111, 5);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(201, 28);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.Tag = "Usage period";
            // 
            // lblUsageperiod
            // 
            this.lblUsageperiod.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsageperiod.Location = new System.Drawing.Point(2, 7);
            this.lblUsageperiod.Name = "lblUsageperiod";
            this.lblUsageperiod.Size = new System.Drawing.Size(82, 23);
            this.lblUsageperiod.TabIndex = 0;
            this.lblUsageperiod.Text = "Usage period:";
            this.lblUsageperiod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmElectricity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(610, 270);
            this.Controls.Add(this.pnlUsage);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblCustomerType);
            this.Controls.Add(this.txtCustomerBill);
            this.Controls.Add(this.lblCharge);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtElectricity);
            this.Controls.Add(this.lblElectricity);
            this.Name = "FrmElectricity";
            this.Text = "Electricity Bill Calculator";
            this.Load += new System.EventHandler(this.FrmElectricity_Load);
            this.pnlUsage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblElectricity;
        private System.Windows.Forms.TextBox txtElectricity;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblCharge;
        private System.Windows.Forms.TextBox txtCustomerBill;
        private System.Windows.Forms.Label lblCustomerType;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel pnlUsage;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblUsageperiod;
    }
}

