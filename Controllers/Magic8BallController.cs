using Microsoft.AspNetCore.Mvc;
using EightToTen.Services;

namespace EightToTen.Controllers
{
    [ApiController]
    [Route("[controller]")] 
    public class Magic8BallController : ControllerBase
    {
        private readonly Magic8BallService _magic8BallService;

        public Magic8BallController(Magic8BallService magic8BallService)
        {
            _magic8BallService = magic8BallService;
        }

        
        [HttpGet("{question}")]
        public string ShakeBall(string question)
        {
            return _magic8BallService.GetPrediction(question);
        }
    }
}