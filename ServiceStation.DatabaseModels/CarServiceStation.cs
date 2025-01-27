using System.Collections.Generic;

namespace ServiceStation.DatabaseModels
{
    public class CarServiceStation : Organization
    {
        public List<Client> Clients { get; set; }
        public List<RepairOrder> RepairOrders { get; set; }
    }
}
