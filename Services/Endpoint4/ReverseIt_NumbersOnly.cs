namespace MiniChallengeFiveToSeven___Endpoints.Services.Endpoint4;

public class ReverseIt_NumbersOnly : IReverseIt_NumbersOnly
{
    public int ReverseNums(int nums)
    {
        string stringNums = nums.ToString();
        string reversedString = "";
        for (int i = stringNums.Length - 1; i >= 0; i--)
        {
            reversedString += stringNums[i];
        }
        return int.Parse(reversedString);
        }
}
