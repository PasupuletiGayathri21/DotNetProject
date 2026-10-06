using Microsoft.AspNetCore.Mvc;
namespace netproject.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    [HttpGet]
    public object Get()
    {
        return new {id=1,name="Laptop",price=75000,brand="Dell"};
  
    }
}
