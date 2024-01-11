using EightToTen.Services.EightBall;
using Microsoft.AspNetCore.Mvc;

namespace EightToTen.Controllers;

[ApiController]
[Route("[controller]")]
public class EightBallController : ControllerBase
{
    private readonly IEightBallService _eightBallService;

    public EightBallController(IEightBallService eightBallService) 
    {
        _eightBallService = eightBallService;
    }
    
    [HttpGet]
    [Route("AskQuestion/{question}")]
    public string AskQuestion(string question) {
        return _eightBallService.AskQuestion(question);
    }
}