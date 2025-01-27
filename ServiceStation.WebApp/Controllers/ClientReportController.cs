using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ServiceStation.Desktop.Handler;
using ServiceStation.WebApp.Extensions;
using ServiceStation.WebApp.Models;
using System;

namespace ServiceStation.WebApp.Controllers
{
    public class ClientReportController : Controller
    {
        public readonly string ApiUrl;

        public ClientReportController(IConfiguration config)
        {
            ApiUrl = config["AppSettings:ApiUrl"];
        }

        public IActionResult Index()
        {
            var dateRangeModel = new DateRangeModel
            {
                DateFrom = DateTime.Now,
                DateTo = DateTime.Now,
            };

            return View(dateRangeModel);
        }

        [HttpPost]
        public IActionResult ReportResult([FromBody] ClientReportRequestModel clientReportRequestModel)
        {
            clientReportRequestModel.DateFrom = clientReportRequestModel.DateFrom.ToLocalTime();
            clientReportRequestModel.DateTo = clientReportRequestModel.DateTo.ToLocalTime();

            var apiHandler = new ServiceStationApiHandler(ApiUrl);

            var vehicle = apiHandler.GetVehicle(clientReportRequestModel.TaxNumber, clientReportRequestModel.LicensePlateNumber);

            if(vehicle == null)
            {
                return Json(null);
            }

            var repairOrders = apiHandler.GetClientRepairOrdersByVehicleId(vehicle.Id, clientReportRequestModel.DateFrom, clientReportRequestModel.DateTo);

            var clientReportResultModel = new ClientReportResultModel();
            var reportResultModel = repairOrders.GenerateReport(true);

            clientReportResultModel.Sum = reportResultModel.Sum;
            clientReportResultModel.Total = reportResultModel.Total;
            clientReportResultModel.Mileage = reportResultModel.Mileage ?? 0;
            clientReportResultModel.Client = vehicle.Client;
            clientReportResultModel.Vehicle = vehicle;

            return Json(clientReportResultModel);
        }
    }
}
