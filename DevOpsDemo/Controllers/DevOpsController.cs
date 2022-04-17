using DevOpsDemo.Data;
using DevOpsDemo.Model;
using DevOpsDemo.Shared;
using Microsoft.AspNetCore.Mvc;

namespace DevOpsDemo.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DevOpsController : ControllerBase
{
    private IEnumerable<string>? _contributors;

    private IEnumerable<string>? _practices;

    private string? _class;

    private readonly ILogger<DevOpsController>? _logger;

    public DevOpsController(ILogger<DevOpsController>? logger, bool useLocalDatabase = true)
    {
        _logger = Validate.NotNull(() => logger);
        if (useLocalDatabase)
        {
            InitLocalData();
        }
    }

    [HttpGet("info")]
    public IActionResult GetDevOpsInfo()
    {
        return Ok(new DevOpsInfo()
        {
            Contributers = _contributors,
            Practices = _practices,
            ClassName = _class,
            ProjectState = State.Ongoing
        });
    }
    
    [HttpGet("contributors")]
    public IActionResult GetContributors()
    {
        if (_contributors == null)
        {
            return NotFound();
        }
        return Ok(_contributors);
    }
    
    [HttpGet("practices")]
    public IActionResult GetPractices()
    {
        if (_practices == null)
        {
            return NotFound();
        }
        return Ok(_practices);
    }

    [HttpGet("class")]
    public IActionResult GetClass()
    {
        if (_class == null)
        {
            return NotFound();
        }
        return Ok(_class);
    }

    private void InitLocalData()
    {
        _contributors = Database.Contributors;
        _practices = Database.Practices;
        _class = Database.ClassName;
    }
}