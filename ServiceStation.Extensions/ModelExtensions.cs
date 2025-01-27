using ServiceStation.DatabaseModels;
using ServiceStation.DTO;

namespace ServiceStation.Extensions
{
    public static class ModelExtensions
    {
        public static ClientModel ToClientModel(this Client client)
        {
            if(client == null) return null;

            var clientModel = new ClientModel
            {
                Id = client.Id,
                Name = client.Name,
                TaxNumber = client.TaxNumber,
                CarServiceStationId = client.CarServiceStationId
            };

            return clientModel;
        }

        public static Client ToClient(this ClientModel clientModel)
        {
            if(clientModel == null) return null;

            var client = new Client
            {
                Id = clientModel.Id,
                Name = clientModel.Name,
                TaxNumber = clientModel.TaxNumber,
                CarServiceStationId = clientModel.CarServiceStationId
            };

            return client;
        }

        public static CarServiceStationModel ToCarServiceStationModel(this CarServiceStation carServiceStation)
        {
            if (carServiceStation == null) return null;

            var carServiceStationModel = new CarServiceStationModel
            {
                Id = carServiceStation.Id,
                Name = carServiceStation.Name,
                TaxNumber = carServiceStation.TaxNumber
            };

            return carServiceStationModel;
        }

        public static CarServiceStation ToCarServiceStation(this CarServiceStationModel carServiceStationModel)
        {
            if (carServiceStationModel == null) return null;

            var carServiceStation = new CarServiceStation
            {
                Id = carServiceStationModel.Id,
                Name = carServiceStationModel.Name,
                TaxNumber = carServiceStationModel.TaxNumber
            };

            return carServiceStation;
        }

        public static VehicleModel ToVehicleModel(this Vehicle vehicle)
        {
            if (vehicle == null) return null;

            var vehicleModel = new VehicleModel
            {
                Id = vehicle.Id,
                BrandModel = vehicle.BrandModel,
                LicensePlateNumber  = vehicle.LicensePlateNumber,
                ClientId = vehicle.ClientId,
                Client = vehicle.Client != null ? new ClientModel
                {
                    Id = vehicle.Client.Id,
                    Name = vehicle.Client.Name,
                    TaxNumber = vehicle.Client.TaxNumber
                } : null
            };

            return vehicleModel;
        }

        public static Vehicle ToVehicle(this VehicleModel vehicleModel)
        {
            if (vehicleModel == null) return null;

            var vehicle = new Vehicle
            {
                Id = vehicleModel.Id,
                BrandModel = vehicleModel.BrandModel,
                LicensePlateNumber = vehicleModel.LicensePlateNumber,
                ClientId = vehicleModel.ClientId
            };

            return vehicle;
        }

        public static RepairOrderModel ToRepairOrderModel(this RepairOrder repairOrder)
        {
            if (repairOrder == null) return null;

            var repairOrderModel = new RepairOrderModel
            {
                Id = repairOrder.Id,
                CarServiceStationId = repairOrder.CarServiceStationId,
                VehicleId = repairOrder.VehicleId,
                Vehicle = repairOrder.Vehicle != null ? new VehicleModel
                {
                    Id = repairOrder.Vehicle.Id,
                    LicensePlateNumber = repairOrder.Vehicle.LicensePlateNumber,
                    BrandModel = repairOrder.Vehicle.BrandModel
                } : null,
                ClientId = repairOrder.ClientId,
                Client = repairOrder.Client != null ? new ClientModel
                {
                    Id = repairOrder.Client.Id,
                    Name = repairOrder.Client.Name,
                    TaxNumber = repairOrder.Client.TaxNumber
                } : null,
                Costs = repairOrder.Costs,
                RepairType = repairOrder.RepairType,
                Mileage = repairOrder.Mileage,
                HandoverDate = repairOrder.HandoverDate,
                RepairDate = repairOrder.RepairDate
            };

            return repairOrderModel;
        }

        public static RepairOrder ToRepairOrder(this RepairOrderModel repairOrderModel)
        {
            if (repairOrderModel == null) return null;

            var repairOrder = new RepairOrder
            {
                Id = repairOrderModel.Id,
                CarServiceStationId = repairOrderModel.CarServiceStationId,
                VehicleId = repairOrderModel.VehicleId,
                ClientId = repairOrderModel.ClientId,
                Costs = repairOrderModel.Costs,
                HandoverDate = repairOrderModel.HandoverDate,
                Mileage = repairOrderModel.Mileage,
                RepairDate = repairOrderModel.RepairDate,
                RepairType = repairOrderModel.RepairType
            };

            return repairOrder;
        }
    }
}
