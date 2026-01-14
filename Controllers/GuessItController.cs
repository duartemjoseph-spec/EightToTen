using Microsoft.AspNetCore.Mvc;
using EightToTen.Services;

namespace EightToTen.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GuessItController : ControllerBase
    {
        private readonly GuessItService _guessItService;

        public GuessItController(GuessItService guessItService)
        {
            _guessItService = guessItService;
        }

        [HttpGet("Easy/1-10/{guess}")]
        public string Easy(string guess)
        {
            return _guessItService.GuessNumber(guess, 10);
        }

        [HttpGet("Medium/1-50/{guess}")]
        public string Medium(string guess)
        {
            return _guessItService.GuessNumber(guess, 50);
        }

        [HttpGet("Hard/1-100/{guess}")]
        public string Hard(string guess)
        {
            return _guessItService.GuessNumber(guess, 100);
        }
    }
}