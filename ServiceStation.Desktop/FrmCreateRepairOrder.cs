using ServiceStation.Desktop.Handler;
using ServiceStation.Desktop.Properties;
using ServiceStation.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ServiceStation.Desktop
{
    public partial class FrmCreateRepairOrder : Form
    {
        public CarServiceStationModel ServiceStation { get; set; }
        public RepairOrderModel RepairOrder { get; set; }
        public ServiceStationApiHandler ServiceStationApiHandler { get; set; }
        public UserModel CurrentUser { get; set; }

        public FrmCreateRepairOrder()
        {
            InitializeComponent();
        }

        public FrmCreateRepairOrder(CarServiceStationModel serviceStation, UserModel currentUser, RepairOrderModel repairOrder = null) : this()
        {
            ServiceStation = serviceStation;
            CurrentUser = currentUser;
            RepairOrder = repairOrder;

            ServiceStationApiHandler = new ServiceStationApiHandler(Resources.ApiUrl, CurrentUser.Token);
            ServiceStationApiHandler.OnErrorMessage += ServiceStationApiHandler_OnErrorMessage;

            var clients = ServiceStationApiHandler.GetClients(ServiceStation.Id);
            FillClients(clients);

            if (repairOrder == null)
                dtpHandOverDate.Enabled = false;
            else
            {
                FillRepairOrder();
            }
        }

        private void FillRepairOrder()
        {
            cmbClients.SelectedValue = RepairOrder.Client.Id;
            cmbVehicles.SelectedValue = RepairOrder.Vehicle.Id;

            txtMileage.Text = RepairOrder.Mileage.ToString();
            txtCosts.Text = RepairOrder.Costs.ToString();
            txtRepairType.Text = RepairOrder.RepairType;
            dtpRepairDate.Value = RepairOrder.RepairDate;

            if (RepairOrder.HandoverDate.HasValue)
            {
                dtpHandOverDate.CustomFormat = "dd.MM.yyyy";
                dtpHandOverDate.Value = RepairOrder.HandoverDate.Value;
            }

            cmbClients.Enabled = false;
            cmbVehicles.Enabled = false;
        }

        private void FillClients(List<ClientModel> clients)
        {
            cmbClients.DataSource = clients;
            cmbClients.ValueMember = "Id";
            cmbClients.DisplayMember = "Name";
        }

        private void FillVehicles(List<VehicleModel> vehicles)
        {
            cmbVehicles.DataSource = vehicles;
            cmbVehicles.ValueMember = "Id";
            cmbVehicles.DisplayMember = "Name";
        }

        private void ServiceStationApiHandler_OnErrorMessage(string error)
        {
            MessageBox.Show(error, "Error");
        }

        private void btnCreateUpdateRepairOrder_Click(object sender, EventArgs e)
        {
            if (RepairOrder == null)
            {
                if (!ValidateRepairOrder())
                {
                    MessageBox.Show("Vehicle, Mileage and Costs required", "Error");
                    return;
                }

                var selectVehicle = (VehicleModel)cmbVehicles.SelectedItem;
                var selectedClient = (ClientModel)cmbClients.SelectedItem;

                RepairOrder = new RepairOrderModel
                {
                    CarServiceStationId = ServiceStation.Id,
                    VehicleId = selectVehicle.Id,
                    ClientId = selectedClient.Id,
                    Mileage = Convert.ToInt32(txtMileage.Text),
                    Costs = Convert.ToDouble(txtCosts.Text),
                    RepairDate = dtpRepairDate.Value,
                    RepairType = txtRepairType.Text
                };

                ServiceStationApiHandler.CreateRepairOrder(RepairOrder);
            }
            else
            {
                RepairOrder.Mileage = Convert.ToInt32(txtMileage.Text);
                RepairOrder.Costs = Convert.ToDouble(txtCosts.Text);
                RepairOrder.RepairDate = dtpRepairDate.Value;
                RepairOrder.RepairType = txtRepairType.Text;

                if (!string.IsNullOrWhiteSpace(dtpHandOverDate.Text))
                    RepairOrder.HandoverDate = dtpHandOverDate.Value.Date;

                ServiceStationApiHandler.UpdateRepairOrder(RepairOrder);
            }

            DialogResult = DialogResult.OK;
        }

        private bool ValidateRepairOrder()
        {
            var selectVehicle = (VehicleModel)cmbVehicles.SelectedItem;

            return selectVehicle != null && !string.IsNullOrEmpty(txtMileage.Text)
                && !string.IsNullOrEmpty(txtCosts.Text);
        }

        private void cmbClients_SelectedValueChanged(object sender, EventArgs e)
        {
            var selectedClient = (ClientModel)cmbClients.SelectedItem;

            if (selectedClient != null)
            {
                var vehicles = ServiceStationApiHandler.GetVehiclesByClientId(selectedClient.Id);

                FillVehicles(vehicles);
            }
        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                return;

            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void dtpHandOverDate_ValueChanged(object sender, EventArgs e)
        {
            dtpHandOverDate.CustomFormat = "dd.MM.yyyy";
        }
    }
}
