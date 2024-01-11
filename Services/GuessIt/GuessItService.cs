namespace EightToTen.Services.GuessIt;

public class GuessItService : IGuessItService
{
    Random randomRange = new Random();

    public string GuessEasy(string numberChoice)
    {
        int numberChose = 0;
        int numberRange = randomRange.Next(1, 10);
        bool dataVerify = int.TryParse(numberChoice, out numberChose);

        if (dataVerify == true)
        {
            if (numberChose == numberRange)
            {
                return $"You won! Your guessed number ({numberChose}) matched the number being guessed ({numberRange})";
            }
            else
            {
                if (numberChose > numberRange)
                {
                    return "Your guess was greater than the number you were attempting to guess. Try Again.";
                }
                else if (numberChose < numberRange)
                {
                    return "Your guess was less than the number you were attempting to guess. Try Again.";
                } else {
                    return "";
                }
            }
        }
        else
        {
            return "Invalid input. Please enter a number from 1 - 10";
        }
    }

    public string GuessHard(string numberChoice)
    {
        int numberChose = 0;
        int numberRange = randomRange.Next(1, 50);
        bool dataVerify = int.TryParse(numberChoice, out numberChose);

        if (dataVerify == true)
        {
            if (numberChose == numberRange)
            {
                return $"You won! Your guessed number ({numberChose}) matched the number being guessed ({numberRange})";
            }
            else
            {
                if (numberChose > numberRange)
                {
                    return "Your guess was greater than the number you were attempting to guess. Try Again.";
                }
                else if (numberChose < numberRange)
                {
                    return "Your guess was less than the number you were attempting to guess. Try Again.";
                } else {
                    return "";
                }
            }
        }
        else
        {
            return "Invalid input. Please enter a number from 1 - 50";
        }
    }

    public string GuessMedium(string numberChoice)
    {
        int numberChose = 0;
        int numberRange = randomRange.Next(1, 100);
        bool dataVerify = int.TryParse(numberChoice, out numberChose);

        if (dataVerify == true)
        {
            if (numberChose == numberRange)
            {
                return $"You won! Your guessed number ({numberChose}) matched the number being guessed ({numberRange})";
            }
            else
            {
                if (numberChose > numberRange)
                {
                    return "Your guess was greater than the number you were attempting to guess. Try Again.";
                }
                else if (numberChose < numberRange)
                {
                    return "Your guess was less than the number you were attempting to guess. Try Again.";
                } else {
                    return "";
                }
            }
        }
        else
        {
            return "Invalid input. Please enter a number from 1 - 100";
        }
    }
}
