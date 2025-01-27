using System.ComponentModel.DataAnnotations;

namespace ServiceStation.DatabaseModels
{
    public class Vehicle
    {
        [Key]
        public int Id { get; set; }
        public string LicensePlateNumber { get; set; }
        public string BrandModel { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}
