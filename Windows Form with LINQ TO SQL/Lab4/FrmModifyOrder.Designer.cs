namespace Lab4
{
    partial class FrmModifyOrder
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
            this.orderIDLabel = new System.Windows.Forms.Label();
            this.customerIDLabel = new System.Windows.Forms.Label();
            this.orderDateLabel = new System.Windows.Forms.Label();
            this.requiredDateLabel = new System.Windows.Forms.Label();
            this.shippedDateLabel = new System.Windows.Forms.Label();
            this.orderIDTextBox = new System.Windows.Forms.TextBox();
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            this.shippedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.requiredDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.orderDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // orderIDLabel
            // 
            this.orderIDLabel.AutoSize = true;
            this.orderIDLabel.Location = new System.Drawing.Point(23, 30);
            this.orderIDLabel.Name = "orderIDLabel";
            this.orderIDLabel.Size = new System.Drawing.Size(50, 13);
            this.orderIDLabel.TabIndex = 0;
            this.orderIDLabel.Text = "Order ID:";
            // 
            // customerIDLabel
            // 
            this.customerIDLabel.AutoSize = true;
            this.customerIDLabel.Location = new System.Drawing.Point(23, 68);
            this.customerIDLabel.Name = "customerIDLabel";
            this.customerIDLabel.Size = new System.Drawing.Size(68, 13);
            this.customerIDLabel.TabIndex = 1;
            this.customerIDLabel.Text = "Customer ID:";
            // 
            // orderDateLabel
            // 
            this.orderDateLabel.AutoSize = true;
            this.orderDateLabel.Location = new System.Drawing.Point(23, 108);
            this.orderDateLabel.Name = "orderDateLabel";
            this.orderDateLabel.Size = new System.Drawing.Size(62, 13);
            this.orderDateLabel.TabIndex = 2;
            this.orderDateLabel.Text = "Order Date:";
            // 
            // requiredDateLabel
            // 
            this.requiredDateLabel.AutoSize = true;
            this.requiredDateLabel.Location = new System.Drawing.Point(21, 144);
            this.requiredDateLabel.Name = "requiredDateLabel";
            this.requiredDateLabel.Size = new System.Drawing.Size(79, 13);
            this.requiredDateLabel.TabIndex = 3;
            this.requiredDateLabel.Text = "Required Date:";
            // 
            // shippedDateLabel
            // 
            this.shippedDateLabel.AutoSize = true;
            this.shippedDateLabel.Location = new System.Drawing.Point(22, 185);
            this.shippedDateLabel.Name = "shippedDateLabel";
            this.shippedDateLabel.Size = new System.Drawing.Size(75, 13);
            this.shippedDateLabel.TabIndex = 4;
            this.shippedDateLabel.Text = "Shipped Date:";
            // 
            // orderIDTextBox
            // 
            this.orderIDTextBox.Location = new System.Drawing.Point(110, 27);
            this.orderIDTextBox.Name = "orderIDTextBox";
            this.orderIDTextBox.Size = new System.Drawing.Size(196, 20);
            this.orderIDTextBox.TabIndex = 5;
            this.orderIDTextBox.Tag = "Order ID";
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.Location = new System.Drawing.Point(109, 64);
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.Size = new System.Drawing.Size(197, 20);
            this.customerIDTextBox.TabIndex = 6;
            // 
            // shippedDateTimePicker
            // 
            this.shippedDateTimePicker.Location = new System.Drawing.Point(107, 182);
            this.shippedDateTimePicker.Name = "shippedDateTimePicker";
            this.shippedDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.shippedDateTimePicker.TabIndex = 9;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(26, 223);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 10;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(230, 223);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 11;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // requiredDateTimePicker
            // 
            this.requiredDateTimePicker.Location = new System.Drawing.Point(107, 141);
            this.requiredDateTimePicker.Name = "requiredDateTimePicker";
            this.requiredDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.requiredDateTimePicker.TabIndex = 8;
            // 
            // orderDateTimePicker
            // 
            this.orderDateTimePicker.Location = new System.Drawing.Point(109, 104);
            this.orderDateTimePicker.Name = "orderDateTimePicker";
            this.orderDateTimePicker.Size = new System.Drawing.Size(198, 20);
            this.orderDateTimePicker.TabIndex = 7;
            // 
            // FrmModifyOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 268);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.shippedDateTimePicker);
            this.Controls.Add(this.requiredDateTimePicker);
            this.Controls.Add(this.orderDateTimePicker);
            this.Controls.Add(this.customerIDTextBox);
            this.Controls.Add(this.orderIDTextBox);
            this.Controls.Add(this.shippedDateLabel);
            this.Controls.Add(this.requiredDateLabel);
            this.Controls.Add(this.orderDateLabel);
            this.Controls.Add(this.customerIDLabel);
            this.Controls.Add(this.orderIDLabel);
            this.Name = "FrmModifyOrder";
            this.Text = "FrmModifyOrder";
            this.Load += new System.EventHandler(this.FrmModifyOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label orderIDLabel;
        private System.Windows.Forms.Label customerIDLabel;
        private System.Windows.Forms.Label orderDateLabel;
        private System.Windows.Forms.Label requiredDateLabel;
        private System.Windows.Forms.Label shippedDateLabel;
        private System.Windows.Forms.TextBox orderIDTextBox;
        private System.Windows.Forms.TextBox customerIDTextBox;
        private System.Windows.Forms.DateTimePicker shippedDateTimePicker;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.DateTimePicker requiredDateTimePicker;
        private System.Windows.Forms.DateTimePicker orderDateTimePicker;
    }
}