using DevOpsDemo.Controllers;
using Microsoft.Extensions.Logging;
using Moq;
using Xunit;

namespace DevOpsDemo.Tests;

public class DevOpsControllerTests
{
    [Fact]
    public void Constructor_Should_Throw_If_Logger_Is_Null()
    {
        Assert.Throws<ArgumentNullException>(() => new DevOpsController(null));
    }
    
    [Fact]
    public void Contributers_Are_Returned_Correctly()
    {
        // Arrange
        var mockLogger = new Mock<ILogger<DevOpsController>>();
        var controller = new DevOpsController(mockLogger.Object);
        
        // Act
        var result = controller.GetContributers();
        
        // Assert
        string[] Contributers = 
        {
            "Philipp", "Marcel", "Marco", "Fabian", "Daniel", "Roman"
        };
        Assert.Equal(result, Contributers);
    }
}