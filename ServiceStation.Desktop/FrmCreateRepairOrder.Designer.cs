namespace ServiceStation.Desktop
{
    partial class FrmCreateRepairOrder
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
            cmbClients = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            cmbVehicles = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            txtRepairType = new System.Windows.Forms.TextBox();
            dtpRepairDate = new System.Windows.Forms.DateTimePicker();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            txtMileage = new System.Windows.Forms.TextBox();
            txtCosts = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            dtpHandOverDate = new System.Windows.Forms.DateTimePicker();
            btnCreateUpdateRepairOrder = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // cmbClients
            // 
            cmbClients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbClients.FormattingEnabled = true;
            cmbClients.Location = new System.Drawing.Point(25, 39);
            cmbClients.Name = "cmbClients";
            cmbClients.Size = new System.Drawing.Size(281, 23);
            cmbClients.TabIndex = 8;
            cmbClients.SelectedValueChanged += cmbClients_SelectedValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(25, 21);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(60, 15);
            label2.TabIndex = 7;
            label2.Text = "Заказчик:";
            // 
            // cmbVehicles
            // 
            cmbVehicles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbVehicles.FormattingEnabled = true;
            cmbVehicles.Location = new System.Drawing.Point(25, 92);
            cmbVehicles.Name = "cmbVehicles";
            cmbVehicles.Size = new System.Drawing.Size(281, 23);
            cmbVehicles.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(25, 74);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(24, 15);
            label1.TabIndex = 9;
            label1.Text = "ТС:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(25, 192);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(80, 15);
            label3.TabIndex = 11;
            label3.Text = "Тип ремонта:";
            // 
            // txtRepairType
            // 
            txtRepairType.Location = new System.Drawing.Point(25, 210);
            txtRepairType.Multiline = true;
            txtRepairType.Name = "txtRepairType";
            txtRepairType.Size = new System.Drawing.Size(281, 73);
            txtRepairType.TabIndex = 12;
            // 
            // dtpRepairDate
            // 
            dtpRepairDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpRepairDate.Location = new System.Drawing.Point(334, 39);
            dtpRepairDate.Name = "dtpRepairDate";
            dtpRepairDate.Size = new System.Drawing.Size(281, 23);
            dtpRepairDate.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(334, 21);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(85, 15);
            label4.TabIndex = 14;
            label4.Text = "Дата ремонта:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(25, 131);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(51, 15);
            label5.TabIndex = 15;
            label5.Text = "Пробег:";
            // 
            // txtMileage
            // 
            txtMileage.Location = new System.Drawing.Point(25, 149);
            txtMileage.Name = "txtMileage";
            txtMileage.Size = new System.Drawing.Size(281, 23);
            txtMileage.TabIndex = 16;
            txtMileage.KeyPress += txtNumber_KeyPress;
            // 
            // txtCosts
            // 
            txtCosts.Location = new System.Drawing.Point(334, 96);
            txtCosts.Name = "txtCosts";
            txtCosts.Size = new System.Drawing.Size(281, 23);
            txtCosts.TabIndex = 18;
            txtCosts.KeyPress += txtNumber_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(334, 78);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(70, 15);
            label6.TabIndex = 17;
            label6.Text = "Стоимость:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(334, 131);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(79, 15);
            label7.TabIndex = 20;
            label7.Text = "Дата выдачи:";
            // 
            // dtpHandOverDate
            // 
            dtpHandOverDate.CustomFormat = " ";
            dtpHandOverDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtpHandOverDate.Location = new System.Drawing.Point(334, 149);
            dtpHandOverDate.Name = "dtpHandOverDate";
            dtpHandOverDate.Size = new System.Drawing.Size(281, 23);
            dtpHandOverDate.TabIndex = 19;
            dtpHandOverDate.ValueChanged += dtpHandOverDate_ValueChanged;
            // 
            // btnCreateUpdateRepairOrder
            // 
            btnCreateUpdateRepairOrder.Location = new System.Drawing.Point(25, 310);
            btnCreateUpdateRepairOrder.Name = "btnCreateUpdateRepairOrder";
            btnCreateUpdateRepairOrder.Size = new System.Drawing.Size(590, 39);
            btnCreateUpdateRepairOrder.TabIndex = 21;
            btnCreateUpdateRepairOrder.Text = "Сохранить";
            btnCreateUpdateRepairOrder.UseVisualStyleBackColor = true;
            btnCreateUpdateRepairOrder.Click += btnCreateUpdateRepairOrder_Click;
            // 
            // FrmCreateRepairOrder
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(649, 361);
            Controls.Add(btnCreateUpdateRepairOrder);
            Controls.Add(label7);
            Controls.Add(dtpHandOverDate);
            Controls.Add(txtCosts);
            Controls.Add(label6);
            Controls.Add(txtMileage);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dtpRepairDate);
            Controls.Add(txtRepairType);
            Controls.Add(label3);
            Controls.Add(cmbVehicles);
            Controls.Add(label1);
            Controls.Add(cmbClients);
            Controls.Add(label2);
            MaximizeBox = false;
            Name = "FrmCreateRepairOrder";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Ремонт";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox cmbClients;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbVehicles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRepairType;
        private System.Windows.Forms.DateTimePicker dtpRepairDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMileage;
        private System.Windows.Forms.TextBox txtCosts;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpHandOverDate;
        private System.Windows.Forms.Button btnCreateUpdateRepairOrder;
    }
}