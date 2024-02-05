namespace MiniChallengeFiveToSeven___Endpoints.Services.Endpoint2;

public class OddOrEven : IOddOrEven
{
    public string NumberType(int num)
    {
        if (num % 2 == 0)
        {
            return num + " is an even number.";
        }
        else
        {
            return num + " is an odd number.";
        }
    }
}
