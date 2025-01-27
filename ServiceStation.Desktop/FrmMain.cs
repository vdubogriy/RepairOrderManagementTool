using ServiceStation.Desktop.Handler;
using ServiceStation.Desktop.Properties;
using ServiceStation.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ServiceStation.Desktop
{
    public partial class FrmMain : Form
    {
        public CarServiceStationModel ServiceStation { get; set; }
        public ServiceStationApiHandler ServiceStationApiHandler { get; set; }
        public UserModel CurrentUser { get; set; }

        public FrmMain()
        {
            InitializeComponent();
        }

        public FrmMain(CarServiceStationModel serviceStation, UserModel currentUser) : this()
        {
            ServiceStation = serviceStation;
            CurrentUser = currentUser;

            ServiceStationApiHandler = new ServiceStationApiHandler(Resources.ApiUrl, CurrentUser.Token);
            ServiceStationApiHandler.OnErrorMessage += ServiceStationApiHandler_OnErrorMessage;

            if (serviceStation != null)
            {
                lblServiceStation.Text = $"СТО: {ServiceStation.Name}";

                Cursor.Current = Cursors.WaitCursor;

                LoadClients();
                LoadVehicles();
                LoadRepairOrders();

                Cursor.Current = Cursors.Default;
            }
        }

        private void LoadRepairOrders()
        {
            var repairOrders = ServiceStationApiHandler.GetRepairOrders(ServiceStation.Id);

            if (repairOrders.Any())
            {
                repairOrders = repairOrders.OrderByDescending(item => item.Id).ToList();

                FillRepairOrdersDataGrid(repairOrders);
            }
        }

        private void FillRepairOrdersDataGrid(List<RepairOrderModel> repairOrders)
        {
            dgvRepairOrders.Rows.Clear();
            dgvRepairOrders.ColumnCount = 8;


            dgvRepairOrders.Columns[0].Name = "Name";
            dgvRepairOrders.Columns[0].HeaderText = "Заказчик";
            dgvRepairOrders.Columns[0].ReadOnly = true;

            dgvRepairOrders.Columns[1].Name = "BrandModel";
            dgvRepairOrders.Columns[1].HeaderText = "Марка/Модель";
            dgvRepairOrders.Columns[1].ReadOnly = true;

            dgvRepairOrders.Columns[2].Name = "LicencePlateNumber";
            dgvRepairOrders.Columns[2].HeaderText = "Гос. Номер";
            dgvRepairOrders.Columns[2].ReadOnly = true;

            dgvRepairOrders.Columns[3].Name = "RepairType";
            dgvRepairOrders.Columns[3].HeaderText = "Тип ремонта";
            dgvRepairOrders.Columns[3].ReadOnly = true;

            dgvRepairOrders.Columns[4].Name = "RepairDate";
            dgvRepairOrders.Columns[4].HeaderText = "Дата ремонта";
            dgvRepairOrders.Columns[4].ReadOnly = true;

            dgvRepairOrders.Columns[5].Name = "Mileage";
            dgvRepairOrders.Columns[5].HeaderText = "Пробег";
            dgvRepairOrders.Columns[5].ReadOnly = true;

            dgvRepairOrders.Columns[6].Name = "Costs";
            dgvRepairOrders.Columns[6].HeaderText = "Стоимость";
            dgvRepairOrders.Columns[6].ReadOnly = true;

            dgvRepairOrders.Columns[7].Name = "HandOverDate";
            dgvRepairOrders.Columns[7].HeaderText = "Дата выдачи";
            dgvRepairOrders.Columns[7].ReadOnly = true;

            for (var i = 0; i < repairOrders.Count; i++)
            {
                dgvRepairOrders.Rows.Add(new DataGridViewRow());
                dgvRepairOrders.Rows[i].Cells[0].Tag = repairOrders[i];

                dgvRepairOrders.Rows[i].Cells[0].Value = repairOrders[i].Client.Name;
                dgvRepairOrders.Rows[i].Cells[1].Value = repairOrders[i].Vehicle.BrandModel;
                dgvRepairOrders.Rows[i].Cells[2].Value = repairOrders[i].Vehicle.LicensePlateNumber;
                dgvRepairOrders.Rows[i].Cells[3].Value = repairOrders[i].RepairType;
                dgvRepairOrders.Rows[i].Cells[4].Value = repairOrders[i].RepairDate.Date;
                dgvRepairOrders.Rows[i].Cells[5].Value = repairOrders[i].Mileage;
                dgvRepairOrders.Rows[i].Cells[6].Value = repairOrders[i].Costs;
                dgvRepairOrders.Rows[i].Cells[7].Value = repairOrders[i].HandoverDate.HasValue ? repairOrders[i].HandoverDate.Value.Date : null;
            }
        }

        private void ServiceStationApiHandler_OnErrorMessage(string error)
        {
            MessageBox.Show(error, "Error");
        }

        private void LoadVehicles()
        {
            var vehicles = ServiceStationApiHandler.GetVehicles(ServiceStation.Id);

            if (vehicles.Any())
            {
                vehicles = vehicles.OrderByDescending(item => item.Id).ToList();

                FillVehiclesDataGrid(vehicles);
            }
        }

        private void FillVehiclesDataGrid(List<VehicleModel> vehicles)
        {
            dgvVehicles.Rows.Clear();
            dgvVehicles.ColumnCount = 3;

            dgvVehicles.Columns[0].Name = "LicencePlateNumber";
            dgvVehicles.Columns[0].HeaderText = "Гос. Номер";
            dgvVehicles.Columns[0].ReadOnly = true;

            dgvVehicles.Columns[1].Name = "BrandModel";
            dgvVehicles.Columns[1].HeaderText = "Марка/Модель";
            dgvVehicles.Columns[1].ReadOnly = true;

            dgvVehicles.Columns[2].Name = "Name";
            dgvVehicles.Columns[2].HeaderText = "Заказчик";
            dgvVehicles.Columns[2].ReadOnly = true;

            for (var i = 0; i < vehicles.Count; i++)
            {
                dgvVehicles.Rows.Add(new DataGridViewRow());
                dgvVehicles.Rows[i].Cells[0].Tag = vehicles[i];

                dgvVehicles.Rows[i].Cells[0].Value = vehicles[i].LicensePlateNumber;
                dgvVehicles.Rows[i].Cells[1].Value = vehicles[i].BrandModel;
                dgvVehicles.Rows[i].Cells[2].Value = vehicles[i].Client.Name;
            }

            dgvVehicles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void LoadClients()
        {
            var clients = ServiceStationApiHandler.GetClients(ServiceStation.Id);

            if (clients.Any())
            {
                clients = clients.OrderByDescending(item => item.Id).ToList();

                FillClientsDataGrid(clients);
            }
        }

        private void FillClientsDataGrid(List<ClientModel> clients)
        {
            dgvClients.Rows.Clear();
            dgvClients.ColumnCount = 2;

            dgvClients.Columns[0].Name = "Name";
            dgvClients.Columns[0].HeaderText = "Наименование";
            dgvClients.Columns[0].ReadOnly = true;

            dgvClients.Columns[1].Name = "TaxNumber";
            dgvClients.Columns[1].HeaderText = "ИНН";
            dgvClients.Columns[1].ReadOnly = true;

            for (var i = 0; i < clients.Count; i++)
            {
                dgvClients.Rows.Add(new DataGridViewRow());
                dgvClients.Rows[i].Cells[0].Tag = clients[i];

                dgvClients.Rows[i].Cells[0].Value = clients[i].Name;
                dgvClients.Rows[i].Cells[1].Value = clients[i].TaxNumber;
            }

            dgvClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btnCreateClient_Click(object sender, EventArgs e)
        {
            if (new FrmCreateClient(ServiceStation, CurrentUser).ShowDialog() == DialogResult.OK)
            {
                LoadClients();
            }
        }

        private void bntCreateVehicle_Click(object sender, EventArgs e)
        {
            var clients = ServiceStationApiHandler.GetClients(ServiceStation.Id);

            if (new FrmCreateVehicle(clients, CurrentUser).ShowDialog() == DialogResult.OK)
            {
                LoadVehicles();
            }
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnCreateRepairOrder_Click(object sender, EventArgs e)
        {
            if (new FrmCreateRepairOrder(ServiceStation, CurrentUser).ShowDialog() == DialogResult.OK)
            {
                LoadRepairOrders();
            }
        }

        private void dgvRepairOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var repairOrder = (RepairOrderModel)dgvRepairOrders.SelectedRows[0].Cells[0].Tag;

            if (new FrmCreateRepairOrder(ServiceStation, CurrentUser, repairOrder).ShowDialog() == DialogResult.OK)
            {
                LoadRepairOrders();
            }
        }
    }
}
