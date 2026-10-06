using Microsoft.AspNetCore.Mvc;

namespace netproject.Controllers;

[ApiController]
[Route("[controller]")]
public class SquareController : ControllerBase
{
    [HttpPost]
    public int Square(SquareRequest Request)
    {
        return Request.Number*Request.Number;
    }
}
public class SquareRequest
{
    public int Number {get;set;}
}