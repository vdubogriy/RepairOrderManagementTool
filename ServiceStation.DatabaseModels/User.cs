using System.ComponentModel.DataAnnotations;

namespace ServiceStation.DatabaseModels
{
    public class User
    {
        [Key]
        public int Id { get; set; }        
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Token { get; set; }
        public int? CarServiceStationId { get; set; }
        public CarServiceStation CarServiceStation { get; set; }
    }
}
