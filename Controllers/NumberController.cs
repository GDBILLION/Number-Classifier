using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NumberClassfierAPI.Services;

namespace NumberClassfierAPI.Controllers
{
    [Route("api/classify-number")]
    [ApiController]
    public class NumberController : ControllerBase
    {
        private readonly NumberService _numberService;

        public NumberController(NumberService numberService)
        {
            _numberService = numberService;
        }

        [HttpGet]
        public async Task<IActionResult> ClassifyNumber([FromQuery] string number)
        {
            if (!int.TryParse(number, out int num))
            {
                return BadRequest(new { number, error = true });
            }

            var result = new
            {
                number = num,
                is_prime = _numberService.IsPrime(num),
                is_perfect = _numberService.IsPerfect(num),
                properties = _numberService.GetNumberProperties(num),
                digit_sum = _numberService.GetDigitSum(num),
                fun_fact = await _numberService.GetFunFact(num)
            };

            return Ok(result);
        }
    }
}
