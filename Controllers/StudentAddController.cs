using Microsoft.AspNetCore.Mvc;

namespace netproject.Controllers;

[ApiController]
[Route("[controller]")]
public class StudentAddController : ControllerBase
{
    [HttpPost]
    public object Student(StudentAddRequest request)
    {
        return new
        {
            message="Student sucessfully added",
            name="Gayathri",
            age=35,
            course="CSE"


        };
    }

}
public class StudentAddRequest
{
    public string Name{get;set;}
    public int age{get;set;}
    public string course{get;set;}
}