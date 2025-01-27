
using ServiceStation.DTO;
using System;

namespace ServiceStation.WebApp.Models
{
    public class DateRangeModel
    {
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
    }

    public class ReportRequestModel
    {
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public int? ServiceStationId { get; set; }
        public int? ClientId { get; set; }
        public int? VehicleId { get; set; }
    }

    public class ClientReportRequestModel
    {
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public string TaxNumber { get; set; }
        public string LicensePlateNumber { get; set; }
    }

    public class ReportResultModel
    {
        public int Total { get; set; }
        public double Sum { get; set; }
        public int? Mileage { get; set; }
    }

    public class ClientReportResultModel : ReportResultModel
    {
        public ClientModel Client { get; set; }
        public VehicleModel Vehicle { get; set; }
    }
}
