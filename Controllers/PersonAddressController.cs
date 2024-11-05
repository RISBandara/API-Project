using Microsoft.AspNetCore.Mvc;
using PersonApi.Models.Requests;
using PersonApi.Repositories.PersonAddress;
using System.Threading.Tasks;

namespace PersonApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonAddressController : ControllerBase
    {
        private readonly IPersonAddressRepository _personAddressRepository;

        public PersonAddressController(IPersonAddressRepository personAddressRepository)
        {
            _personAddressRepository = personAddressRepository;
        }

        [HttpPost("GetPersonAddress")]
        public async Task<IActionResult> GetPersonAddress([FromBody] GetPersonAddressRequest request)
        {
            var result = await _personAddressRepository.GetPersonAddressAsync(request.Id);
            return Ok(result);
        }
    }
}
