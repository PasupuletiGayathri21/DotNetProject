using Microsoft.AspNetCore.Mvc;

namespace netproject.Controllers;

[ApiController]
[Route("[controller]")]
public class StudentController : ControllerBase
{
    [HttpGet]
    public object Get()
    {
        return new {id=101,name="Rahul",course="B.Tech",age=21};
  
    }
}








