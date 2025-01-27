using ServiceStation.Desktop.Handler;
using ServiceStation.Desktop.Properties;
using ServiceStation.DTO;
using System;

using System.Windows.Forms;

namespace ServiceStation.Desktop
{
    public partial class FrmCreateClient : Form
    {
        public ServiceStationApiHandler ServiceStationApiHandler { get; set; }
        public CarServiceStationModel ServiceStation { get; set; }
        public UserModel CurrentUser { get; set; }

        public FrmCreateClient()
        {
            InitializeComponent();
        }

        public FrmCreateClient(CarServiceStationModel serviceStation, UserModel currentUser): this()
        {
            CurrentUser = currentUser;

            ServiceStationApiHandler = new ServiceStationApiHandler(Resources.ApiUrl, CurrentUser.Token);
            ServiceStationApiHandler.OnErrorMessage += ServiceStationApiHandler_OnErrorMessage;

            ServiceStation = serviceStation;
        }

        private void ServiceStationApiHandler_OnErrorMessage(string error)
        {
            MessageBox.Show(error, "Error");
        }

        private void btnCreateClient_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtClientName.Text) || string.IsNullOrWhiteSpace(txtClientTaxNumber.Text))
            {
                MessageBox.Show("Please fill in name and tax number", "Error");
                return;
            }

            var client = new ClientModel
            {
                Name = txtClientName.Text,
                TaxNumber = txtClientTaxNumber.Text,
                CarServiceStationId = ServiceStation.Id
            };

            ServiceStationApiHandler.CreateClient(client);

            DialogResult = DialogResult.OK;
        }
    }
}
