using System;
using System.ComponentModel.DataAnnotations;

namespace ServiceStation.DatabaseModels
{
    public class RepairOrder
    {
        [Key]
        public int Id { get; set; }
        public int CarServiceStationId { get; set; }
        public CarServiceStation CarServiceStation { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }
        public string RepairType { get; set; }
        public DateTime RepairDate { get; set; }
        public int Mileage { get; set; }
        public double Costs { get; set; }
        public DateTime? HandoverDate { get; set; }
    }
}
