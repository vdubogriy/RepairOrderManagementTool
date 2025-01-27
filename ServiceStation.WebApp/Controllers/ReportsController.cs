using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using ServiceStation.Desktop.Handler;
using ServiceStation.DTO;
using ServiceStation.WebApp.Extensions;
using ServiceStation.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ServiceStation.WebApp.Controllers
{
    public class ReportsController : Controller
    {
        public readonly string ApiUrl;

        public ReportsController(IConfiguration config)
        {
            ApiUrl = config["AppSettings:ApiUrl"];
        }

        public ActionResult Index()
        {
            var dateRangeModel = new DateRangeModel
            {
                DateFrom = DateTime.Now,
                DateTo = DateTime.Now,
            };

            return View(dateRangeModel);
        }

        public IActionResult GetServiceStations(int? serviceStationId)
        {
            try
            {
                var token = HttpContext.Request.Headers["Authorization"].ToString();
                var apiHandler = new ServiceStationApiHandler(ApiUrl, token);

                var serviceStations = apiHandler.GetServiceStations();

                if (serviceStationId.HasValue)
                {
                    serviceStations = serviceStations.Where(item => item.Id == serviceStationId.Value).ToList();
                    return Json(serviceStations.GetSelectList());
                }

                var selectList = new List<SelectListItem> { new() { Text = "--select--", Value = "0" } };
                selectList.AddRange(serviceStations.GetSelectList());

                return Json(selectList);
            }
            catch (Exception ex)
            {
                return View("Error", new ErrorViewModel { Error = ex.Message });
            }
        }

        public IActionResult GetClients(int serviceStationId)
        {
            try
            {
                var token = HttpContext.Request.Headers["Authorization"].ToString();
                var apiHandler = new ServiceStationApiHandler(ApiUrl, token);

                var clients = apiHandler.GetClients(serviceStationId);

                var clientsSelectList = new List<SelectListItem> { new() { Text = "--select--", Value = "0" } };
                clientsSelectList.AddRange(clients.GetSelectList());

                return Json(clientsSelectList);
            }
            catch (Exception ex)
            {
                return View("Error", new ErrorViewModel { Error = ex.Message });
            }
        }

        public IActionResult GetVehicles(int clientId)
        {
            try
            {
                var token = HttpContext.Request.Headers["Authorization"].ToString();
                var apiHandler = new ServiceStationApiHandler(ApiUrl, token);

                var vehicles = apiHandler.GetVehiclesByClientId(clientId);

                var vehiclesSelectList = new List<SelectListItem> { new() { Text = "--select--", Value = "0" } };
                vehiclesSelectList.AddRange(vehicles.GetSelectList());

                return Json(vehiclesSelectList);
            }
            catch (Exception ex)
            {
                return View("Error", new ErrorViewModel { Error = ex.Message });
            }
        }

        [HttpPost]
        public IActionResult ReportResult([FromBody]ReportRequestModel reportRequestModel)
        {
            try
            {
                var token = HttpContext.Request.Headers["Authorization"].ToString();

                reportRequestModel.DateFrom = reportRequestModel.DateFrom.ToLocalTime();
                reportRequestModel.DateTo = reportRequestModel.DateTo.ToLocalTime();

                var apiHandler = new ServiceStationApiHandler(ApiUrl, token);
                var repairOrders = new List<RepairOrderModel>();

                if (reportRequestModel.VehicleId.HasValue)
                {
                    repairOrders = apiHandler.GetReportRepairOrdersByVehicleId(reportRequestModel.VehicleId.Value, reportRequestModel.DateFrom, reportRequestModel.DateTo);
                }
                else if (reportRequestModel.ClientId.HasValue)
                {
                    repairOrders = apiHandler.GetReportRepairOrdersByClientd(reportRequestModel.ClientId.Value, reportRequestModel.DateFrom, reportRequestModel.DateTo);
                }
                else if (reportRequestModel.ServiceStationId.HasValue)
                {
                    repairOrders = apiHandler.GetReportRepairOrdersByServiceStationId(reportRequestModel.ServiceStationId.Value, reportRequestModel.DateFrom, reportRequestModel.DateTo);
                }
                else
                {
                    repairOrders = apiHandler.GetReportRepairOrders(reportRequestModel.DateFrom, reportRequestModel.DateTo);
                }

                var reportResultModel = repairOrders.GenerateReport(reportRequestModel.VehicleId.HasValue); 

                return Json(reportResultModel);
            }
            catch (Exception ex)
            {
                return View("Error", new ErrorViewModel { Error = ex.Message });
            }
        }
    }
}
