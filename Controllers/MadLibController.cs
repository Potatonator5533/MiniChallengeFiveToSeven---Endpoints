using MiniChallengeFiveToSeven___Endpoints.Services.Endpoint1;
using Microsoft.AspNetCore.Mvc;

namespace MiniChallengeFiveToSeven___Endpoints.Controllers.MadLibController;

[ApiController]
[Route("[controller]")]
public class MadLibController : Controller
{
    private readonly IMadLib _madLib;

    public MadLibController(IMadLib madLib)
    {
        _madLib = madLib;
    }

    [HttpGet]
    [Route("LibGenerator/{day}/{name}/{mood}/{activity}/{structure}/{sound}/{feeling}/{name2}/{item}/{feeling2}")]
    public string LibGenerator(string day, string name, string mood, string activity, string structure, string sound, string feeling, string name2, string item, string feeling2)
    {
        return _madLib.LibGenerator(day, name, mood, activity, structure, sound, feeling, name2, item, feeling2);
    }
}