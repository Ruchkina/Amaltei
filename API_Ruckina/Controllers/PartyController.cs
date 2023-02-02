using AppAmalt.Constants;
using AppAmalt.Dto;
using AppAmalt.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace AppAmalt.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PartyController : ControllerBase
    {
        private readonly IResponseRepository _responseRepository;
        public PartyController(IResponseRepository iResponseRepository)
        {
            _responseRepository = iResponseRepository;
        }

        [HttpGet("{name}")]
        public async Task<IActionResult> GetParty(string name)
        {
            IActionResult answer;
            try
            {
                ResponseDto response = ResponseDtoConverter.ConvertToDto(await _responseRepository.GetResponseAsync(PartyId.GetValue(name)));
                answer = Ok(response);
            }
            catch (Exception ex)
            {
                answer = StatusCode(StatusCodes.Status500InternalServerError);
            }
            return answer;
        }

    }
}
