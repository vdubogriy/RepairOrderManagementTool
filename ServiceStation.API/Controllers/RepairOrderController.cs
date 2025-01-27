using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Serilog;
using ServiceStation.API.Auth;
using ServiceStation.DTO;
using ServiceStation.Extensions;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceStation.API.Controllers
{
    [Route("repairorder")]
    [ApiController]
    [AuthorizeCustom]
    public class RepairOrderController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public RepairOrderController(DatabaseContext context)
        {
            _context = context;
        }

        [HttpGet("vehicle/{id}")]
        public async Task<ActionResult<IEnumerable<RepairOrderModel>>> GetAsync(int id)
        {
            return await _context.RepairOrders.Where(item => item.VehicleId == id).Select(item => item.ToRepairOrderModel()).ToListAsync();
        }

        [HttpGet("carservicestation/{id}")]
        public async Task<ActionResult<IEnumerable<RepairOrderModel>>> GetByServiceStationIdAsync(int id)
        {
            return await _context.RepairOrders.Include(item => item.Vehicle).Include(item => item.Client).Where(item => item.CarServiceStationId == id).Select(item => item.ToRepairOrderModel()).ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<RepairOrderModel>> PostAsync([FromBody] RepairOrderModel repairOrderModel)
        {
            if (!Validate(repairOrderModel))
            {
                Log.Error("Create Repair Order failed. Missing parameters.");
                return BadRequest();
            }

            var repairOrder = repairOrderModel.ToRepairOrder();

            _context.RepairOrders.Add(repairOrder);
            await _context.SaveChangesAsync();

            return repairOrder.ToRepairOrderModel();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<RepairOrderModel>> PutAsync(int id, [FromBody] RepairOrderModel repairOrderModel)
        {
            var repairOrder = _context.RepairOrders.FirstOrDefault(item => item.Id == id);

            if(repairOrder == null)
            {
                Log.Error("Update Repair Order failed. Not found.");
                return NotFound();

            }

            if (!Validate(repairOrderModel))
            {
                Log.Error("Update Repair Order failed. Missing parameters.");
                return BadRequest();
            }

            repairOrder.HandoverDate = repairOrderModel.HandoverDate;
            repairOrder.RepairDate = repairOrderModel.RepairDate;
            repairOrder.RepairType = repairOrderModel.RepairType;
            repairOrder.Costs = repairOrderModel.Costs;
            repairOrder.Mileage = repairOrderModel.Mileage;

            _context.RepairOrders.Update(repairOrder);
            await _context.SaveChangesAsync();

            return repairOrder.ToRepairOrderModel();
        }

        private bool Validate(RepairOrderModel repairOrderModel)
        {
            if (repairOrderModel == null)
                return false;

            var serviceStation = _context.CarServiceStations.FirstOrDefault(item => item.Id == repairOrderModel.CarServiceStationId);
            var vehicle = _context.Vehicles.FirstOrDefault(item => item.Id == repairOrderModel.VehicleId);

            return serviceStation != null && vehicle != null;
        }
    }
}
