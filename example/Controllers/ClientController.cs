using example.Models;
using example.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace example.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientRepository _clientRepository;

        public ClientController( IClientRepository clientepository)
        { 

          _clientRepository =  clientepository;

    }
       // [Route("[action]")]
        [HttpGet("")]
        public async Task<IActionResult> MyClaims()
        {
          
            var result = await _clientRepository.GetAllClient();
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var da = await _clientRepository.GetByIdasync(id);
            if(da == null)
            {
                return NotFound();
            }
            return Ok(da);
        }
        

            //[Route("[action]")]
        [HttpPost("hi")]
        public IActionResult AddData([FromBody] ClientModel clientModel)
        {
            var id = _clientRepository.AddDataasync(clientModel);

            return CreatedAtAction(nameof(GetById), new { id = clientModel.Id , Controller = "Client"}, clientModel);
        }
    }
}
