using DevOpsDemo.Controllers;
using Xunit;

namespace DevOpsDemo.Tests;

public class DevOpsControllerTests
{
    [Fact]
    public void Constructor_Should_Throw_If_Logger_Is_Null()
    {
        Assert.Throws<ArgumentNullException>(() => new DevOpsController(null));
    }
}