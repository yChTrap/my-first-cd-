using Microsoft.AspNetCore.Mvc;
using static System.IO.File;

namespace my_first_cd_.Controllers;

[ApiController]
[Route("/")]
public class TestController : ControllerBase
{
    [HttpGet]
    public string Test()
    {
        return "meu backend esta rodando";
}
    [HttpGet]
    public ActionResult OutroTest()
    {   
            return Content(
                ReadAllText("views/index.html"),
                "text/html");
    }
}


