using Microsoft.AspNetCore.Mvc;

namespace netproject.Controllers;

[ApiController]
[Route("[controller]")]
public class GreetingsController : ControllerBase
{
    [HttpPost]
    public string Greet(GreetingRequest request)
    {
        return $"Hello {request.Name}";
  
    }
}
public class GreetingRequest
{
    public string Name {get;set;}
}








