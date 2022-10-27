// Jasmine Leek
// 25oct2022
// Say Hello - Endpoints
// This is a web api that has an endpoint which says hello to a user by name
// peer review: Arely - The program does  whaat it needs to do. Jasmine did job of naming her controller and route name. Overall very neat and works well. 

using Microsoft.AspNetCore.Mvc;

namespace LeekJSayHelloEP.Controllers;

[ApiController]
[Route("[controller]")]
public class SayHelloController : ControllerBase
{
    [HttpGet]
    [Route("Hello/{name}")]

    public string SayHello(string name)
    {
        return $"Hello {name}";
    }
}