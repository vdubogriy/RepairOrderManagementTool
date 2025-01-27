using System.Collections.Generic;

namespace ServiceStation.DatabaseModels
{
    public class Client : Organization
    {
        public List<Vehicle> Vehicles { get; set; }
        public int CarServiceStationId { get; set; }
        public CarServiceStation CarServiceStation { get; set; }
    }
}
