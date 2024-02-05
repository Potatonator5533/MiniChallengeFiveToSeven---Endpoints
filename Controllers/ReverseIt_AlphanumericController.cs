using MiniChallengeFiveToSeven___Endpoints.Services.Endpoint3;
using Microsoft.AspNetCore.Mvc;

namespace MiniChallengeFiveToSeven___Endpoints.Controllers.ReverseIt_AlphanumericController;

[ApiController]
[Route("[controller]")]
public class ReverseIt_AlphanumericController : Controller
{
    private readonly IReverseIt_Alphanumeric _reverseIt_Alphanumeric;

    public ReverseIt_AlphanumericController(IReverseIt_Alphanumeric ReverseIt_Alphanumeric)
    {
        _reverseIt_Alphanumeric = ReverseIt_Alphanumeric;
    }

    [HttpGet]
    [Route("ReverseChars/{chars}")]
    public string ReverseChars(string chars)
    {
        return _reverseIt_Alphanumeric.ReverseChars(chars);
    }
}