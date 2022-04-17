using DevOpsDemo.Data;
using DevOpsDemo.Model;
using DevOpsDemo.Shared;
using Microsoft.AspNetCore.Mvc;

namespace DevOpsDemo.Controllers;

public class DemoController : ControllerBase
{
    private readonly ILogger<DevOpsController>? _logger;

    public DemoController(ILogger<DevOpsController>? logger)
    {
        _logger = Validate.NotNull(() => logger);
    }
    
    [HttpGet("info")]
    public IActionResult GetDevOpsInfo()
    {
        return Ok(new DevOpsInfo()
        {
            Contributers = Database.Contributors,
            Practices = Database.Practices,
            ClassName = Database.ClassName,
            ProjectState = State.Ongoing
        });
    }
}