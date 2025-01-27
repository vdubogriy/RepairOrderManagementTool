using Newtonsoft.Json;
using RestSharp;
using ServiceStation.DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ServiceStation.Desktop.Handler
{    
    public class ServiceStationApiHandler
    {
        public delegate void ErrorMessageEvent(string error);
        public event ErrorMessageEvent OnErrorMessage;

        public string Token { get; set; }
        public RestClient RestClient { get; set; }

        public ServiceStationApiHandler(string apiUrl, string token = null)
        {
            RestClient = new RestClient(apiUrl);
            Token = token;
        }

        private RestRequest GetRequest(string resource, Method method)
        {
            var request = new RestRequest(resource, method);

            if(!string.IsNullOrWhiteSpace(Token))
                request.AddHeader("Authorization", Token);

            return request;
        }

        private IRestResponse Execute(RestRequest restRequest)
        {
            var response = RestClient.Execute(restRequest);

            if (!response.IsSuccessful)
            {
                var message = response.ErrorMessage ?? response.Content;

                if (OnErrorMessage != null)
                    OnErrorMessage(message);
                else
                    throw new Exception(message);
            }

            return response;
        }

        public List<CarServiceStationModel> GetServiceStations()
        {
            var restRequest = GetRequest("carservicestation", Method.GET);

            var response = Execute(restRequest);             

            var serviceStations = JsonConvert.DeserializeObject<List<CarServiceStationModel>>(response.Content) ?? new List<CarServiceStationModel>();            

            return serviceStations;
        }

        public CarServiceStationModel GetServiceStation(int serviceStationId)
        {
            var restRequest = GetRequest($"carservicestation/{serviceStationId}", Method.GET);

            var response = Execute(restRequest);

            var serviceStation = JsonConvert.DeserializeObject<List<CarServiceStationModel>>(response.Content);

            return serviceStation.FirstOrDefault();
        }

        public List<ClientModel> GetClients(int serviceStationId)
        {
            var restRequest = GetRequest($"client/carservicestation/{serviceStationId}", Method.GET);

            var response = Execute(restRequest);

            var clients = JsonConvert.DeserializeObject<List<ClientModel>>(response.Content) ?? new List<ClientModel>();

            return clients;
        }

        public void CreateClient(ClientModel client)
        {
            var restRequest = GetRequest("client", Method.POST);

            restRequest.AddJsonBody(JsonConvert.SerializeObject(client));

            Execute(restRequest);
        }

        public List<VehicleModel> GetVehicles(int serviceStationId)
        {
            var restRequest = GetRequest($"vehicle/carservicestation/{serviceStationId}", Method.GET);

            var response = Execute(restRequest);

            var vehicles = JsonConvert.DeserializeObject<List<VehicleModel>>(response.Content) ?? new List<VehicleModel>();

            return vehicles;
        }

        public void CreateVehicle(VehicleModel vehicle)
        {
            var restRequest = GetRequest("vehicle", Method.POST);

            restRequest.AddJsonBody(JsonConvert.SerializeObject(vehicle));

            Execute(restRequest);
        }

        public List<RepairOrderModel> GetRepairOrders(int serviceStationId)
        {
            var restRequest = GetRequest($"repairorder/carservicestation/{serviceStationId}", Method.GET);

            var response = Execute(restRequest);

            var repairOrders = JsonConvert.DeserializeObject<List<RepairOrderModel>>(response.Content) ?? new List<RepairOrderModel>();

            return repairOrders;
        }

        public List<VehicleModel> GetVehiclesByClientId(int clientId)
        {
            var restRequest = GetRequest($"vehicle/client/{clientId}", Method.GET);

            var response = Execute(restRequest);

            var vehicles = JsonConvert.DeserializeObject<List<VehicleModel>>(response.Content) ?? new List<VehicleModel>();

            return vehicles;
        }

        public void CreateRepairOrder(RepairOrderModel repairOrder)
        {
            var restRequest = GetRequest("repairorder", Method.POST);

            restRequest.AddJsonBody(JsonConvert.SerializeObject(repairOrder));

            Execute(restRequest);
        }

        public void UpdateRepairOrder(RepairOrderModel repairOrder)
        {
            var restRequest = GetRequest($"repairorder/{repairOrder.Id}", Method.PUT);

            restRequest.AddJsonBody(JsonConvert.SerializeObject(repairOrder));

            Execute(restRequest);
        }

        public List<RepairOrderModel> GetReportRepairOrders(DateTime dateFrom, DateTime dateTo)
        {
            var restRequest = GetRequest($"report?dateFrom={dateFrom:yyy-MM-dd}&dateTo={dateTo:yyyy-MM-dd}", Method.GET);

            var response = Execute(restRequest);

            var repairOrders = JsonConvert.DeserializeObject<List<RepairOrderModel>>(response.Content) ?? new List<RepairOrderModel>();

            return repairOrders;
        }

        public List<RepairOrderModel> GetReportRepairOrdersByServiceStationId(int serviceStationId, DateTime dateFrom, DateTime dateTo)
        {
            var restRequest = GetRequest($"report/carservicestation/{serviceStationId}?dateFrom={dateFrom:yyy-MM-dd}&dateTo={dateTo:yyyy-MM-dd}", Method.GET);

            var response = Execute(restRequest);

            var repairOrders = JsonConvert.DeserializeObject<List<RepairOrderModel>>(response.Content) ?? new List<RepairOrderModel>();

            return repairOrders;
        }

        public List<RepairOrderModel> GetReportRepairOrdersByClientd(int clientId, DateTime dateFrom, DateTime dateTo)
        {
            var restRequest = GetRequest($"report/client/{clientId}?dateFrom={dateFrom:yyy-MM-dd}&dateTo={dateTo:yyyy-MM-dd}", Method.GET);

            var response = Execute(restRequest);

            var repairOrders = JsonConvert.DeserializeObject<List<RepairOrderModel>>(response.Content) ?? new List<RepairOrderModel>();

            return repairOrders;
        }

        public List<RepairOrderModel> GetReportRepairOrdersByVehicleId(int vehicleId, DateTime dateFrom, DateTime dateTo)
        {
            var restRequest = GetRequest($"report/vehicle/{vehicleId}?dateFrom={dateFrom:yyy-MM-dd}&dateTo={dateTo:yyyy-MM-dd}", Method.GET);

            var response = Execute(restRequest);

            var repairOrders = JsonConvert.DeserializeObject<List<RepairOrderModel>>(response.Content) ?? new List<RepairOrderModel>();

            return repairOrders;
        }

        public UserModel Login(LoginRequestModel loginRequestModel)
        {
            var restRequest = GetRequest("user/login", Method.POST);

            restRequest.AddJsonBody(JsonConvert.SerializeObject(loginRequestModel));

            var response = Execute(restRequest);

            var userModel = JsonConvert.DeserializeObject<UserModel>(response.Content);

            return userModel;
        }

        public UserModel ValidateUser()
        {
            var restRequest = GetRequest($"user/validate", Method.GET);

            var response = Execute(restRequest);

            var userModel = JsonConvert.DeserializeObject<UserModel>(response.Content);

            return userModel;
        }

        public void Logout()
        {
            var restRequest = GetRequest($"user/logout", Method.POST);

            Execute(restRequest);
        }

        public VehicleModel GetVehicle(string taxNumber, string licensePlateNumber)
        {
            var restRequest = GetRequest($"clientreport/vehicle?taxNumber={taxNumber}&licensePlateNumber={licensePlateNumber}", Method.GET);

            var response = Execute(restRequest);

            var vehicleModel = JsonConvert.DeserializeObject<List<VehicleModel>>(response.Content);

            return vehicleModel.FirstOrDefault();
        }

        public List<RepairOrderModel> GetClientRepairOrdersByVehicleId(int vehicleId, DateTime dateFrom, DateTime dateTo)
        {
            var restRequest = GetRequest($"clientreport/repairorder/vehicle/{vehicleId}?dateFrom={dateFrom:yyy-MM-dd}&dateTo={dateTo:yyyy-MM-dd}", Method.GET);

            var response = Execute(restRequest);

            var repairOrders = JsonConvert.DeserializeObject<List<RepairOrderModel>>(response.Content) ?? new List<RepairOrderModel>();

            return repairOrders;
        }
    }
}
