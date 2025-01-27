using System.ComponentModel.DataAnnotations;

namespace ServiceStation.DatabaseModels
{
    public class Organization
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string TaxNumber { get; set; }
    }
}
