namespace ServiceStation.Desktop
{
    partial class FrmStart
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
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            txtUsername = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            btnLogin = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(159, 30);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(87, 15);
            label2.TabIndex = 3;
            label2.Text = "Пользователь:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(159, 84);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(52, 15);
            label3.TabIndex = 4;
            label3.Text = "Пароль:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new System.Drawing.Point(159, 48);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new System.Drawing.Size(328, 23);
            txtUsername.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(159, 102);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new System.Drawing.Size(328, 23);
            txtPassword.TabIndex = 6;
            // 
            // btnLogin
            // 
            btnLogin.Location = new System.Drawing.Point(159, 142);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(328, 27);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Войти";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // FrmStart
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(654, 200);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            MaximizeBox = false;
            Name = "FrmStart";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Repair Management Tool";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
    }
}
