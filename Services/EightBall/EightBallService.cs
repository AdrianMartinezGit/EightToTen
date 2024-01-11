namespace EightToTen.Services.EightBall;

public class EightBallService : IEightBallService
{
    public string AskQuestion(string question)
    {
        string response = question; 

        response = Responses(response);
        return response;
    }

    public string Responses(string response)
    {
        string Response1 = "It is certain.";
        string Response2 = "It is decidedly so.";
        string Response3 = "As I see it, yes.";
        string Response4 = "Most likely.";
        string Response5 = "Reply hazy, try again.";
        string Response6 = "Ask again later.";
        string Response7 = "Don't count on it.";
        string Response8 = "My reply is no.";

        int numberOfResponse;
        Random var = new Random();
        numberOfResponse = var.Next(8);

        switch (numberOfResponse)
        {
            case 0:
                response = Response1;
                return response;
            case 1:
                response = Response2;
                return response;
            case 2:
                response = Response3;
                return response;
            case 3:
                response = Response4;
                return response;
            case 4:
                response = Response5;
                return response;
            case 5:
                response = Response6;
                return response;
            case 6:
                response = Response7;
                return response;
            case 7:
                response = Response8;
                return response;
            default:                           
                response = Response1;
                return response;
        }
    }
}