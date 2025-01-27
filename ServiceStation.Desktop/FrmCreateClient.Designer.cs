namespace ServiceStation.Desktop
{
    partial class FrmCreateClient
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
            btnCreateClient = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            txtClientName = new System.Windows.Forms.TextBox();
            txtClientTaxNumber = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // btnCreateClient
            // 
            btnCreateClient.Location = new System.Drawing.Point(228, 134);
            btnCreateClient.Name = "btnCreateClient";
            btnCreateClient.Size = new System.Drawing.Size(99, 23);
            btnCreateClient.TabIndex = 0;
            btnCreateClient.Text = "Сохранить";
            btnCreateClient.UseVisualStyleBackColor = true;
            btnCreateClient.Click += btnCreateClient_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 23);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(93, 15);
            label1.TabIndex = 1;
            label1.Text = "Наименование:";
            // 
            // txtClientName
            // 
            txtClientName.Location = new System.Drawing.Point(12, 41);
            txtClientName.Name = "txtClientName";
            txtClientName.Size = new System.Drawing.Size(315, 23);
            txtClientName.TabIndex = 2;
            // 
            // txtClientTaxNumber
            // 
            txtClientTaxNumber.Location = new System.Drawing.Point(12, 91);
            txtClientTaxNumber.Name = "txtClientTaxNumber";
            txtClientTaxNumber.Size = new System.Drawing.Size(315, 23);
            txtClientTaxNumber.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 73);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(37, 15);
            label2.TabIndex = 3;
            label2.Text = "ИНН:";
            // 
            // FrmCreateClient
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(339, 169);
            Controls.Add(txtClientTaxNumber);
            Controls.Add(label2);
            Controls.Add(txtClientName);
            Controls.Add(label1);
            Controls.Add(btnCreateClient);
            MaximizeBox = false;
            Name = "FrmCreateClient";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Добавить заказчика";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnCreateClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.TextBox txtClientTaxNumber;
        private System.Windows.Forms.Label label2;
    }
}