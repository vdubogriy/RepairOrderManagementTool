namespace ServiceStation.DTO
{
    public class VehicleModel
    {
        public int Id { get; set; }
        public string LicensePlateNumber { get; set; }
        public string BrandModel { get; set; }
        public int ClientId { get; set; }
        public ClientModel Client { get; set; }
        public string Name => $"{LicensePlateNumber}/{BrandModel}";
    }
}
