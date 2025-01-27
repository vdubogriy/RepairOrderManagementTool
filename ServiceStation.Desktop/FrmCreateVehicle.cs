using ServiceStation.Desktop.Handler;
using ServiceStation.Desktop.Properties;
using ServiceStation.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ServiceStation.Desktop
{
    public partial class FrmCreateVehicle : Form
    {
        public ServiceStationApiHandler ServiceStationApiHandler { get; set; }
        public UserModel CurrentUser { get; set; }

        public FrmCreateVehicle()
        {
            InitializeComponent();
        }

        public FrmCreateVehicle(List<ClientModel> clients, UserModel currentUser) : this()
        {
            CurrentUser = currentUser;

            ServiceStationApiHandler = new ServiceStationApiHandler(Resources.ApiUrl, CurrentUser.Token);
            ServiceStationApiHandler.OnErrorMessage += ServiceStationApiHandler_OnErrorMessage;

            FillClients(clients);

        }

        private void ServiceStationApiHandler_OnErrorMessage(string error)
        {
            MessageBox.Show(error, "Error");
        }

        private void FillClients(List<ClientModel> clients)
        {
            cmbClient.DataSource = clients;
            cmbClient.ValueMember = "Id";
            cmbClient.DisplayMember = "Name";
        }

        private void btnCreateVehicle_Click(object sender, EventArgs e)
        {
            if(cmbClient.SelectedItem == null || string.IsNullOrWhiteSpace(txtLicensePlateNumber.Text)
                || string.IsNullOrWhiteSpace(txtBrandModel.Text))
            {
                MessageBox.Show("Client, Licence Plate Number and Brand/Model required.", "Error");
                return;
            }

            var vehicle = new VehicleModel
            {
                ClientId = ((ClientModel)cmbClient.SelectedItem).Id,
                LicensePlateNumber = txtLicensePlateNumber.Text,
                BrandModel = txtBrandModel.Text
            };

            ServiceStationApiHandler.CreateVehicle(vehicle);

            DialogResult = DialogResult.OK;
        }
    }
}
