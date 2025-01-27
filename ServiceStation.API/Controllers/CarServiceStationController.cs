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
    [Route("carservicestation")]
    [ApiController]
    [AuthorizeCustom]
    public class CarServiceStationController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public CarServiceStationController(DatabaseContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CarServiceStationModel>>> GetAsync()
        {
            return await _context.CarServiceStations.Select(item => item.ToCarServiceStationModel()).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<CarServiceStationModel>>> GetByIdAsync(int id)
        {
            return await _context.CarServiceStations.Where(item => item.Id == id).Select(item => item.ToCarServiceStationModel()).ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<CarServiceStationModel>> PostAsync([FromBody] CarServiceStationModel carServiceStationModel)
        {
            if(carServiceStationModel == null || string.IsNullOrWhiteSpace(carServiceStationModel.Name) 
                || string.IsNullOrWhiteSpace(carServiceStationModel.TaxNumber))
            {
                Log.Error("Create CarSeriveStation failed. Missing Parameters.");
                return BadRequest();
            }

            var carServiceStation = carServiceStationModel.ToCarServiceStation();

            _context.CarServiceStations.Add(carServiceStation);
            await _context.SaveChangesAsync();

            return carServiceStation.ToCarServiceStationModel();
        }
    }
}
