using MiniChallengeFiveToSeven___Endpoints.Services.Endpoint4;
using Microsoft.AspNetCore.Mvc;

namespace MiniChallengeFiveToSeven___Endpoints.Controllers.ReverseIt_NumbersOnlyController;

[ApiController]
[Route("[controller]")]
public class ReverseIt_NumbersOnlyController : Controller
{
    private readonly IReverseIt_NumbersOnly _reverseIt_NumbersOnly;

    public ReverseIt_NumbersOnlyController(IReverseIt_NumbersOnly ReverseIt_NumbersOnly)
    {
        _reverseIt_NumbersOnly = ReverseIt_NumbersOnly;
    }

    [HttpGet]
    [Route("ReverseNums/{nums}")]
    public int ReverseNums(int nums)
    {
        return _reverseIt_NumbersOnly.ReverseNums(nums);
    }
}