using Microsoft.AspNetCore.Mvc;

namespace netproject.Controllers;

[ApiController]
[Route("[controller]")]
public class LanguageController : ControllerBase
{
    [HttpGet]
    public string[] Get()
    {
        return ["C#","Java","Python","JavaScript","Go"];
    }
}