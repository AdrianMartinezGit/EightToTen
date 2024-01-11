namespace EightToTen.Services.GuessIt;

public interface IGuessItService
{
    string GuessEasy(string numberChoice);
    string GuessMedium(string numberChoice);
    string GuessHard(string numberChoice);
}