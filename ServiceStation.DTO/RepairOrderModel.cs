using System;

namespace ServiceStation.DTO
{
    public class RepairOrderModel
    {
        public int Id { get; set; }
        public int CarServiceStationId { get; set; }
        public int ClientId { get; set; }
        public ClientModel Client { get; set; }
        public int VehicleId { get; set; }
        public VehicleModel Vehicle { get; set; }
        public string RepairType { get; set; }
        public DateTime RepairDate { get; set; }
        public int Mileage { get; set; }
        public double Costs { get; set; }
        public DateTime? HandoverDate { get; set; }
    }
}
