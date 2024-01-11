using EightToTen.Services.GuessIt;
using Microsoft.AspNetCore.Mvc;

namespace EightToTen.Controllers;

[ApiController]
[Route("[controller]")]
public class GuessItController : ControllerBase
{
    private readonly IGuessItService _guessItService;

    public GuessItController(IGuessItService guessItService)
    {
        _guessItService = guessItService;
    }

    [HttpGet]
    [Route("GuessEasy/{numberChoice}")]
    public string GuessEasy(string numberChoice)
    {
        return _guessItService.GuessEasy(numberChoice);
    }

    [HttpGet]
    [Route("GuessMedium/{numberChoice}")]
    public string GuessMedium(string numberChoice)
    {
        return _guessItService.GuessMedium(numberChoice);
    }

    [HttpGet]
    [Route("GuessHard/{numberChoice}")]
    public string GuessHard(string numberChoice)
    {
        return _guessItService.GuessHard(numberChoice);
    }
}