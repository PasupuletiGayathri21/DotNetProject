using Microsoft.AspNetCore.Mvc;

namespace netproject.Controllers;

[ApiController]
[Route("[controller]")]
public class EmployeeController : ControllerBase
{
    [HttpPost]
    public object Employee(EmployeeRequest request)
    {
        if (request.id == 101){
            return new {id=101,name="gayathri",department="cse"};

            
        }
         return new
        {
            message = "Employee not found"
        };
    }
}
public class EmployeeRequest
{
    public int id{get;set;}
}