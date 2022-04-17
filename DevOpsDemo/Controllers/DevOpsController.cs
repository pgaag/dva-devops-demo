using DevOpsDemo.Model;
using DevOpsDemo.Shared;
using Microsoft.AspNetCore.Mvc;

namespace DevOpsDemo.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DevOpsController : ControllerBase
{
    public IEnumerable<string> Contributers = new List<string>()
    {
        "Philipp", "Marcel", "Marco", "Fabian", "Daniel", "Roman"
    };
    
    public IEnumerable<string> Practices = new List<string>()
    {
        "Continuous Integration", "Continuous Development", "Monitoring", "Testing", "Wiki"
    };

    public string Class = "DVA-Praktikum";

    private const string Unused = null;

    private readonly ILogger<DevOpsController>? _logger;

    public DevOpsController(ILogger<DevOpsController>? logger)
    {
        _logger = Validate.NotNull(() => logger);
    }

    [HttpGet("info")]
    public IActionResult GetDevOpsInfo()
    {
        return Ok(new DevOpsInfo()
        {
            Contributers = Contributers,
            Practices = Practices,
            ClassName = Class,
            ProjectState = State.Ongoing
        });
    }
    
    [HttpGet("contributers")]
    public IActionResult GetContributers()
    {
        return Ok(Contributers);
    }
    
    [HttpGet("practices")]
    public IActionResult GetPractices()
    {
        if (Practices != null)
        {
            return Ok(Practices);
        }
        return NotFound();
    }
    
    [HttpGet("practicesv2")]
    public IActionResult GetPracticesDuplication()
    {
        if (Practices != null)
        {
            return Ok(Practices);
        }
        return NotFound();
    }
    
    [HttpGet("class")]
    public IActionResult GetClass()
    {
        return Ok(Class);
    }
}