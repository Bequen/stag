using Microsoft.AspNetCore.Mvc;

namespace StagApi;

[ApiController]
[Route("[controller]")]
public class TestController : ControllerBase
{
    [HttpGet]
    [Route("Test")]
    public ActionResult<String> Get([FromServices] ILogger<TestController> logger)
    {
        logger.LogInformation("Test");
        logger.LogError("Testing some information");
        Console.WriteLine("Test");
        return "test";
    }

}