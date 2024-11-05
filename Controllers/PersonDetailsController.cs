using Microsoft.AspNetCore.Mvc;
using PersonApi.Models.Requests;
using PersonApi.Repositories.PersonDetails;
using System.Threading.Tasks;

namespace PersonApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonDetailsController : ControllerBase
    {
        private readonly IPersonDetailsRepository _personDetailsRepository;

        public PersonDetailsController(IPersonDetailsRepository personDetailsRepository)
        {
            _personDetailsRepository = personDetailsRepository;
        }

        [HttpPost("GetPersonDetails")]
        public async Task<IActionResult> GetPersonDetails([FromBody] GetPersonDetailsRequest request)
        {
            var result = await _personDetailsRepository.GetPersonDetailsAsync(request.Id);
            return Ok(result);
        }
    }
}
