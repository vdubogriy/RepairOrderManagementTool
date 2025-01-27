using Microsoft.AspNetCore.Mvc.Rendering;
using ServiceStation.DTO;
using ServiceStation.WebApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace ServiceStation.WebApp.Extensions
{
    public static class ViewModelExtensions
    {
        public static IEnumerable<SelectListItem> GetSelectList<T>(this List<T> list)
        {
            return list?.Select(item => new SelectListItem { Text = item.GetType().GetProperty("Name").GetValue(item).ToString(), Value = item.GetType().GetProperty("Id").GetValue(item).ToString() });
        }

        public static ReportResultModel GenerateReport(this List<RepairOrderModel> repairOrders, bool calculateMileage)
        {
            var reportResultModel = new ReportResultModel();
            if (repairOrders.Any())
            {
                reportResultModel = new ReportResultModel
                {
                    Total = repairOrders.Count,
                    Sum = repairOrders.Sum(item => item.Costs)
                };

                if (calculateMileage)
                    reportResultModel.Mileage = repairOrders.Max(item => item.Mileage) - repairOrders.Min(item => item.Mileage);
            }

            return reportResultModel;
        }
    }
}
