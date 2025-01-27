namespace ServiceStation.Desktop
{
    partial class FrmMain
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
            lblServiceStation = new System.Windows.Forms.Label();
            tabManagementTool = new System.Windows.Forms.TabControl();
            tabClients = new System.Windows.Forms.TabPage();
            dgvClients = new System.Windows.Forms.DataGridView();
            btnCreateClient = new System.Windows.Forms.Button();
            tabVehicles = new System.Windows.Forms.TabPage();
            dgvVehicles = new System.Windows.Forms.DataGridView();
            bntCreateVehicle = new System.Windows.Forms.Button();
            tabRepairOrders = new System.Windows.Forms.TabPage();
            dgvRepairOrders = new System.Windows.Forms.DataGridView();
            btnCreateRepairOrder = new System.Windows.Forms.Button();
            tabManagementTool.SuspendLayout();
            tabClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClients).BeginInit();
            tabVehicles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVehicles).BeginInit();
            tabRepairOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRepairOrders).BeginInit();
            SuspendLayout();
            // 
            // lblServiceStation
            // 
            lblServiceStation.AutoSize = true;
            lblServiceStation.Location = new System.Drawing.Point(12, 9);
            lblServiceStation.Name = "lblServiceStation";
            lblServiceStation.Size = new System.Drawing.Size(15, 15);
            lblServiceStation.TabIndex = 0;
            lblServiceStation.Text = "[]";
            // 
            // tabManagementTool
            // 
            tabManagementTool.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tabManagementTool.Controls.Add(tabClients);
            tabManagementTool.Controls.Add(tabVehicles);
            tabManagementTool.Controls.Add(tabRepairOrders);
            tabManagementTool.Location = new System.Drawing.Point(12, 36);
            tabManagementTool.Name = "tabManagementTool";
            tabManagementTool.SelectedIndex = 0;
            tabManagementTool.Size = new System.Drawing.Size(1039, 543);
            tabManagementTool.TabIndex = 1;
            // 
            // tabClients
            // 
            tabClients.Controls.Add(dgvClients);
            tabClients.Controls.Add(btnCreateClient);
            tabClients.Location = new System.Drawing.Point(4, 24);
            tabClients.Name = "tabClients";
            tabClients.Padding = new System.Windows.Forms.Padding(3);
            tabClients.Size = new System.Drawing.Size(1031, 515);
            tabClients.TabIndex = 0;
            tabClients.Text = "Заказчики";
            tabClients.UseVisualStyleBackColor = true;
            // 
            // dgvClients
            // 
            dgvClients.AllowUserToAddRows = false;
            dgvClients.AllowUserToDeleteRows = false;
            dgvClients.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClients.Location = new System.Drawing.Point(6, 35);
            dgvClients.MultiSelect = false;
            dgvClients.Name = "dgvClients";
            dgvClients.ReadOnly = true;
            dgvClients.RowTemplate.Height = 25;
            dgvClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvClients.Size = new System.Drawing.Size(1019, 474);
            dgvClients.TabIndex = 1;
            // 
            // btnCreateClient
            // 
            btnCreateClient.Location = new System.Drawing.Point(6, 6);
            btnCreateClient.Name = "btnCreateClient";
            btnCreateClient.Size = new System.Drawing.Size(133, 23);
            btnCreateClient.TabIndex = 0;
            btnCreateClient.Text = "Добавить заказчика";
            btnCreateClient.UseVisualStyleBackColor = true;
            btnCreateClient.Click += btnCreateClient_Click;
            // 
            // tabVehicles
            // 
            tabVehicles.Controls.Add(dgvVehicles);
            tabVehicles.Controls.Add(bntCreateVehicle);
            tabVehicles.Location = new System.Drawing.Point(4, 24);
            tabVehicles.Name = "tabVehicles";
            tabVehicles.Padding = new System.Windows.Forms.Padding(3);
            tabVehicles.Size = new System.Drawing.Size(1031, 515);
            tabVehicles.TabIndex = 1;
            tabVehicles.Text = "ТС";
            tabVehicles.UseVisualStyleBackColor = true;
            // 
            // dgvVehicles
            // 
            dgvVehicles.AllowUserToAddRows = false;
            dgvVehicles.AllowUserToDeleteRows = false;
            dgvVehicles.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dgvVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVehicles.Location = new System.Drawing.Point(6, 35);
            dgvVehicles.MultiSelect = false;
            dgvVehicles.Name = "dgvVehicles";
            dgvVehicles.ReadOnly = true;
            dgvVehicles.RowTemplate.Height = 25;
            dgvVehicles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvVehicles.Size = new System.Drawing.Size(1019, 474);
            dgvVehicles.TabIndex = 3;
            // 
            // bntCreateVehicle
            // 
            bntCreateVehicle.Location = new System.Drawing.Point(6, 6);
            bntCreateVehicle.Name = "bntCreateVehicle";
            bntCreateVehicle.Size = new System.Drawing.Size(99, 23);
            bntCreateVehicle.TabIndex = 2;
            bntCreateVehicle.Text = "Добавить ТС";
            bntCreateVehicle.UseVisualStyleBackColor = true;
            bntCreateVehicle.Click += bntCreateVehicle_Click;
            // 
            // tabRepairOrders
            // 
            tabRepairOrders.Controls.Add(dgvRepairOrders);
            tabRepairOrders.Controls.Add(btnCreateRepairOrder);
            tabRepairOrders.Location = new System.Drawing.Point(4, 24);
            tabRepairOrders.Name = "tabRepairOrders";
            tabRepairOrders.Padding = new System.Windows.Forms.Padding(3);
            tabRepairOrders.Size = new System.Drawing.Size(1031, 515);
            tabRepairOrders.TabIndex = 2;
            tabRepairOrders.Text = "Ремонт";
            tabRepairOrders.UseVisualStyleBackColor = true;
            // 
            // dgvRepairOrders
            // 
            dgvRepairOrders.AllowUserToAddRows = false;
            dgvRepairOrders.AllowUserToDeleteRows = false;
            dgvRepairOrders.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dgvRepairOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRepairOrders.Location = new System.Drawing.Point(6, 35);
            dgvRepairOrders.MultiSelect = false;
            dgvRepairOrders.Name = "dgvRepairOrders";
            dgvRepairOrders.ReadOnly = true;
            dgvRepairOrders.RowTemplate.Height = 25;
            dgvRepairOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvRepairOrders.Size = new System.Drawing.Size(1019, 474);
            dgvRepairOrders.TabIndex = 5;
            dgvRepairOrders.CellDoubleClick += dgvRepairOrders_CellDoubleClick;
            // 
            // btnCreateRepairOrder
            // 
            btnCreateRepairOrder.Location = new System.Drawing.Point(6, 6);
            btnCreateRepairOrder.Name = "btnCreateRepairOrder";
            btnCreateRepairOrder.Size = new System.Drawing.Size(140, 23);
            btnCreateRepairOrder.TabIndex = 4;
            btnCreateRepairOrder.Text = "Добавить ремонт";
            btnCreateRepairOrder.UseVisualStyleBackColor = true;
            btnCreateRepairOrder.Click += btnCreateRepairOrder_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1063, 591);
            Controls.Add(tabManagementTool);
            Controls.Add(lblServiceStation);
            Name = "FrmMain";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Repair Management Tool";
            FormClosed += FrmMain_FormClosed;
            tabManagementTool.ResumeLayout(false);
            tabClients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClients).EndInit();
            tabVehicles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVehicles).EndInit();
            tabRepairOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRepairOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblServiceStation;
        private System.Windows.Forms.TabControl tabManagementTool;
        private System.Windows.Forms.TabPage tabClients;
        private System.Windows.Forms.TabPage tabVehicles;
        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.Button btnCreateClient;
        private System.Windows.Forms.DataGridView dgvVehicles;
        private System.Windows.Forms.Button bntCreateVehicle;
        private System.Windows.Forms.TabPage tabRepairOrders;
        private System.Windows.Forms.DataGridView dgvRepairOrders;
        private System.Windows.Forms.Button btnCreateRepairOrder;
    }
}