using Microsoft.AspNetCore.Mvc;

namespace netproject.Controllers;

[ApiController]
[Route("[controller]")]
public class AddNumbersController:ControllerBase
{
    [HttpPost]
    public int AddNumber(AddNumberRequest request)
    {
        return  request.FirstNumber+request.SecondNumber;
    }
}

public class AddNumberRequest
{
    public int FirstNumber{get;set;}
    public int SecondNumber{get;set;}

}