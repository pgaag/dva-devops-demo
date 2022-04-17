using DevOpsDemo.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using Xunit;

namespace DevOpsDemo.Tests;

public class DevOpsControllerTests
{
    [Fact]
    public void Constructor_Should_Throw_If_Logger_Is_Null()
    {
        // Act & Assert
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
        var resultObj = result as OkObjectResult;
        
        // Assert
        Assert.NotNull(resultObj?.Value);
        Assert.Equal(200, resultObj.StatusCode);
    }
    
    [Fact]
    public void DVA_Class_Is_Returned_Correctly()
    {
        // Arrange
        var mockLogger = new Mock<ILogger<DevOpsController>>();
        var controller = new DevOpsController(mockLogger.Object);
        
        // Act
        var result = controller.GetClass();
        var resultObj = result as OkObjectResult;
        
        // Assert
        Assert.NotNull(resultObj?.Value);
        Assert.Equal(200, resultObj.StatusCode);
    }
    
    [Fact]
    public void Practices_Returns_Not_Found_When_Null()
    {
        // Arrange
        var mockLogger = new Mock<ILogger<DevOpsController>>();
        var controller = new DevOpsController(mockLogger.Object);
        controller.Practices = null;
        
        // Act
        var result = controller.GetPractices();
        var resultObj = result as StatusCodeResult;
        
        // Assert
        Assert.Equal(404, resultObj?.StatusCode);
    }
    
    [Fact]
    public void Practices_Are_Returned_Correctly()
    {
        // Arrange
        var mockLogger = new Mock<ILogger<DevOpsController>>();
        var controller = new DevOpsController(mockLogger.Object);
        
        // Act
        var result = controller.GetPractices();
        var resultObj = result as OkObjectResult;
        
        // Assert
        Assert.NotNull(resultObj?.Value);
        Assert.Equal(200, resultObj.StatusCode);
    }
    
}