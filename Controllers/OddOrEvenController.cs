using MiniChallengeFiveToSeven___Endpoints.Services.Endpoint2;
using Microsoft.AspNetCore.Mvc;

namespace MiniChallengeFiveToSeven___Endpoints.Controllers.OddOrEvenController;

[ApiController]
[Route("[controller]")]
public class OddOrEvenController : Controller
{
    private readonly IOddOrEven _oddOrEven;

    public OddOrEvenController(IOddOrEven oddOrEven)
    {
        _oddOrEven = oddOrEven;
    }

    [HttpGet]
    [Route("NumberType/{num}")]
    public string NumberType(int num)
    {
        return _oddOrEven.NumberType(num);
    }
}