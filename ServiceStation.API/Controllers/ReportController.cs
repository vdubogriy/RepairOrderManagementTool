using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ServiceStation.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using System.Linq;
using ServiceStation.Extensions;
using ServiceStation.API.Auth;

namespace ServiceStation.API.Controllers
{
    [Route("report")]
    [ApiController]
    [AuthorizeCustom]
    public class ReportController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public ReportController(DatabaseContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<RepairOrderModel>>> GetAsync([FromQuery] DateTime dateFrom, [FromQuery] DateTime dateTo)
        {
            return await _context.RepairOrders.Where(item => item.HandoverDate.HasValue && item.HandoverDate.Value >= dateFrom 
                && item.HandoverDate.Value <= dateTo).Select(item => item.ToRepairOrderModel()).ToListAsync();
        }

        [HttpGet("carservicestation/{id}")]
        public async Task<ActionResult<IEnumerable<RepairOrderModel>>> GetByServiceStationIdAsync(int id, [FromQuery] DateTime dateFrom, [FromQuery] DateTime dateTo)
        {
            return await _context.RepairOrders.Where(item => item.CarServiceStationId == id && item.HandoverDate.HasValue && item.HandoverDate.Value >= dateFrom
                && item.HandoverDate.Value <= dateTo).Select(item => item.ToRepairOrderModel()).ToListAsync();
        }

        [HttpGet("client/{id}")]
        public async Task<ActionResult<IEnumerable<RepairOrderModel>>> GetByClientIdAsync(int id, [FromQuery] DateTime dateFrom, [FromQuery] DateTime dateTo)
        {
            return await _context.RepairOrders.Where(item => item.ClientId == id && item.HandoverDate.HasValue && item.HandoverDate.Value >= dateFrom
                && item.HandoverDate.Value <= dateTo).Select(item => item.ToRepairOrderModel()).ToListAsync();
        }

        [HttpGet("vehicle/{id}")]
        public async Task<ActionResult<IEnumerable<RepairOrderModel>>> GetByVehicleIdAsync(int id, [FromQuery] DateTime dateFrom, [FromQuery] DateTime dateTo)
        {
            return await _context.RepairOrders.Where(item => item.VehicleId == id && item.HandoverDate.HasValue && item.HandoverDate.Value >= dateFrom
                && item.HandoverDate.Value <= dateTo).Select(item => item.ToRepairOrderModel()).ToListAsync();
        }
    }
}
