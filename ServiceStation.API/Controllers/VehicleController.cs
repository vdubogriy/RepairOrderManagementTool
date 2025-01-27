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
    [Route("vehicle")]
    [ApiController]
    [AuthorizeCustom]
    public class VehicleController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public VehicleController(DatabaseContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<VehicleModel>>> GetAsync()
        {
            return await _context.Vehicles.Include(item => item.Client).Select(item => item.ToVehicleModel()).ToListAsync();
        }

        [HttpGet("carservicestation/{id}")]
        public async Task<ActionResult<IEnumerable<VehicleModel>>> GetByServiceStationIdAsync(int id)
        {
            return await _context.Vehicles.Include(item => item.Client).Where(item => item.Client.CarServiceStationId == id).Select(item => item.ToVehicleModel()).ToListAsync();
        }

        [HttpGet("client/{id}")]
        public async Task<ActionResult<IEnumerable<VehicleModel>>> GetByClientIdAsync(int id)
        {
            return await _context.Vehicles.Include(item => item.Client).Where(item => item.Client.Id == id).Select(item => item.ToVehicleModel()).ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<VehicleModel>> PostAsync([FromBody] VehicleModel vehicleModel)
        {
            if (vehicleModel == null || string.IsNullOrWhiteSpace(vehicleModel.LicensePlateNumber)
                || string.IsNullOrWhiteSpace(vehicleModel.BrandModel))
            {
                Log.Error("Create Vehicle failed. Missing parameters.");
                return BadRequest();
            }

            var client = _context.Clients.FirstOrDefault(item => item.Id == vehicleModel.ClientId);
            if (client == null)
            {
                Log.Error("Create Vehicle failed. Client not found.");
                return NotFound();
            }

            var vehicle = vehicleModel.ToVehicle();

            _context.Vehicles.Add(vehicle);
            await _context.SaveChangesAsync();

            return vehicle.ToVehicleModel();
        }
    }
}
