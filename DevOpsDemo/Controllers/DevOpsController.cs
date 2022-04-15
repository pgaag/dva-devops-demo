using DevOpsDemo.Shared;
using Microsoft.AspNetCore.Mvc;

namespace DevOpsDemo.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DevOpsController : ControllerBase
{
    private static readonly string[] Contributers = 
    {
        "Philipp", "Marcel", "Roman", "Fabian", "Daniel", "Roman"
    };
    
    private static readonly string[] Practices = 
    {
        "Continuous Integration", "Continuous Development", "Monitoring", "Testing", "Wiki"
    };

    private const string Class = "DVA-Praktikum";

    private readonly ILogger<DevOpsController>? _logger;

    public DevOpsController(ILogger<DevOpsController>? logger)
    {
        _logger = Validate.NotNull(() => logger);
    }

    [HttpGet("info")]
    public DevOpsInfo GetDevOpsInfo()
    {
        return new DevOpsInfo()
        {
            Contributers = Contributers,
            Pratices = Practices,
            ClassName = Class
        };
    }
    
    [HttpGet("contributers")]
    public IEnumerable<string> GetContributers()
    {
        return Contributers;
    }
    
    [HttpGet("practices")]
    public IEnumerable<string> GetPractices()
    {
        return Contributers;
    }
    
    [HttpGet("class")]
    public string GetClass()
    {
        return Class;
    }
}