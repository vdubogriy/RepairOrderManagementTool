using ServiceStation.Desktop.Handler;
using ServiceStation.Desktop.Properties;
using ServiceStation.DTO;
using System;
using System.Windows.Forms;

namespace ServiceStation.Desktop
{
    public partial class FrmStart : Form
    {
        public FrmStart()
        {
            InitializeComponent();            
        }

        private void ServiceStationApiHandler_OnErrorMessage(string error)
        {
            MessageBox.Show(error, "Error");
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            var loginModel = new LoginRequestModel
            {
                Email = txtUsername.Text,
                Password = txtPassword.Text,
            };

            var apiHandler = new ServiceStationApiHandler(Resources.ApiUrl);

            apiHandler.OnErrorMessage += ServiceStationApiHandler_OnErrorMessage;

            var user = apiHandler.Login(loginModel);

            if(user != null && user.IsAuthenticated && user.ServiceStationId.HasValue)
            {
                var serviceStation = new ServiceStationApiHandler(Resources.ApiUrl, user.Token).GetServiceStation(user.ServiceStationId.Value);
                
                new FrmMain(serviceStation, user).Show();

                Cursor.Current = Cursors.WaitCursor;

                Hide();
            }
            else
            {
                MessageBox.Show("Пользователь не найден", "Error");
            }
        }
    }
}
