namespace ServiceStation.Desktop
{
    partial class FrmCreateVehicle
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            txtLicensePlateNumber = new System.Windows.Forms.TextBox();
            txtBrandModel = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            cmbClient = new System.Windows.Forms.ComboBox();
            btnCreateVehicle = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 18);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Заказчик:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 74);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(73, 15);
            label2.TabIndex = 2;
            label2.Text = "Гос. Номер:";
            // 
            // txtLicensePlateNumber
            // 
            txtLicensePlateNumber.Location = new System.Drawing.Point(12, 92);
            txtLicensePlateNumber.Name = "txtLicensePlateNumber";
            txtLicensePlateNumber.Size = new System.Drawing.Size(281, 23);
            txtLicensePlateNumber.TabIndex = 3;
            // 
            // txtBrandModel
            // 
            txtBrandModel.Location = new System.Drawing.Point(12, 153);
            txtBrandModel.Name = "txtBrandModel";
            txtBrandModel.Size = new System.Drawing.Size(281, 23);
            txtBrandModel.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 135);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(94, 15);
            label3.TabIndex = 4;
            label3.Text = "Марка/Модель:";
            // 
            // cmbClient
            // 
            cmbClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbClient.FormattingEnabled = true;
            cmbClient.Location = new System.Drawing.Point(12, 36);
            cmbClient.Name = "cmbClient";
            cmbClient.Size = new System.Drawing.Size(281, 23);
            cmbClient.TabIndex = 6;
            // 
            // btnCreateVehicle
            // 
            btnCreateVehicle.Location = new System.Drawing.Point(218, 194);
            btnCreateVehicle.Name = "btnCreateVehicle";
            btnCreateVehicle.Size = new System.Drawing.Size(75, 23);
            btnCreateVehicle.TabIndex = 7;
            btnCreateVehicle.Text = "Сохранить";
            btnCreateVehicle.UseVisualStyleBackColor = true;
            btnCreateVehicle.Click += btnCreateVehicle_Click;
            // 
            // FrmCreateVehicle
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(305, 228);
            Controls.Add(btnCreateVehicle);
            Controls.Add(cmbClient);
            Controls.Add(txtBrandModel);
            Controls.Add(label3);
            Controls.Add(txtLicensePlateNumber);
            Controls.Add(label2);
            Controls.Add(label1);
            MinimizeBox = false;
            Name = "FrmCreateVehicle";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Добавить ТС";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLicensePlateNumber;
        private System.Windows.Forms.TextBox txtBrandModel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbClient;
        private System.Windows.Forms.Button btnCreateVehicle;
    }
}