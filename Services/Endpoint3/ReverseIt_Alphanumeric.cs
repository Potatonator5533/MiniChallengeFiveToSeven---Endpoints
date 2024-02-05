namespace MiniChallengeFiveToSeven___Endpoints.Services.Endpoint3;

public class ReverseIt_Alphanumeric : IReverseIt_Alphanumeric
{
    public string ReverseChars(string chars)
    {
        string reversed = "";
        for (int i = chars.Length - 1; i >= 0; i--)
        {
            reversed += chars[i];
        }
        return reversed;
    }
}
