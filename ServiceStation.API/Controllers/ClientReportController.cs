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
    [Route("clientreport")]
    [ApiController]
    public class ClientReportController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public ClientReportController(DatabaseContext context)
        {
            _context = context;
        }

        [HttpGet("repairorder/vehicle/{id}")]
        public async Task<ActionResult<IEnumerable<RepairOrderModel>>> GetByVehicleIdAsync(int id, [FromQuery] DateTime dateFrom, [FromQuery] DateTime dateTo)
        {
            return await _context.RepairOrders.Where(item => item.VehicleId == id && item.HandoverDate.HasValue && item.HandoverDate.Value >= dateFrom
                && item.HandoverDate.Value <= dateTo).Select(item => item.ToRepairOrderModel()).ToListAsync();
        }

        [HttpGet("vehicle")]
        public async Task<ActionResult<IEnumerable<VehicleModel>>> GetAsync([FromQuery] string taxNumber, [FromQuery] string licensePlateNumber)
        {
            return await _context.Vehicles.Include(item => item.Client).Where(item => item.Client.TaxNumber == taxNumber
                && item.LicensePlateNumber == licensePlateNumber).Select(item => item.ToVehicleModel()).ToListAsync();
        }
    }
}
