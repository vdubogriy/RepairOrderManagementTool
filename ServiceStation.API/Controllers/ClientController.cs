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
    [Route("client")]
    [ApiController]
    [AuthorizeCustom]
    public class ClientController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public ClientController(DatabaseContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClientModel>>> GetAsync()
        {            
            return await _context.Clients.Select(item => item.ToClientModel()).ToListAsync();
        }

        [HttpGet("carservicestation/{id}")]
        public async Task<ActionResult<IEnumerable<ClientModel>>> GetByServiceStationIdAsync(int id)
        {
            return await _context.Clients.Where(item => item.CarServiceStationId == id).Select(item => item.ToClientModel()).ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<ClientModel>> PostAsync([FromBody] ClientModel clientModel)
        {
            if (clientModel == null || string.IsNullOrWhiteSpace(clientModel.Name) 
                || string.IsNullOrWhiteSpace(clientModel.TaxNumber))
            {
                Log.Error("Create Client failed. Missing parameters.");
                return BadRequest();
            }

            var carServiceStation = _context.CarServiceStations.FirstOrDefault(item => item.Id == clientModel.CarServiceStationId);
            if(carServiceStation == null)
            {
                Log.Error("Create Client failed. Car Service Station not found.");
                return NotFound();
            }

            var client = clientModel.ToClient();

            _context.Clients.Add(client);
            await _context.SaveChangesAsync();

            return client.ToClientModel();
        }
    }
}
