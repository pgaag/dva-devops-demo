using DevOpsDemo.Controllers;
using DevOpsDemo.Model;
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
        Assert.Throws<ArgumentNullException>(() => new DevOpsController(null, true));
    }
    
    [Fact]
    public void Contributors_Are_Returned_Correctly()
    {
        // Arrange 
        var mockLogger = new Mock<ILogger<DevOpsController>>();
        var controller = new DevOpsController(mockLogger.Object);
        
        // Act
        var result = controller.GetContributors();
        var resultObj = result as OkObjectResult;
        
        // Assert
        Assert.NotNull(resultObj?.Value);
        Assert.Equal(200, resultObj.StatusCode);
    }
    
    [Fact]
    public void Contributors_Returns_Not_Found_When_Null()
    {
        // Arrange
        var mockLogger = new Mock<ILogger<DevOpsController>>();
        var controller = new DevOpsController(mockLogger.Object, false);

        // Act
        var result = controller.GetContributors();
        var resultObj = result as StatusCodeResult;
        
        // Assert
        Assert.Equal(404, resultObj?.StatusCode);
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
    public void DVA_Class_Returns_Not_Found_When_Null()
    {
        // Arrange
        var mockLogger = new Mock<ILogger<DevOpsController>>();
        var controller = new DevOpsController(mockLogger.Object, false);
        
        // Act
        var result = controller.GetClass();
        var resultObj = result as StatusCodeResult;
        
        // Assert
        Assert.Equal(404, resultObj?.StatusCode);
    }
    
    [Fact]
    public void Practices_Returns_Not_Found_When_Null()
    {
        // Arrange
        var mockLogger = new Mock<ILogger<DevOpsController>>();
        var controller = new DevOpsController(mockLogger.Object, false);

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
    
    [Fact]
    public void DevOpsInfo_Is_Returned_Correctly()
    {
        // Arrange
        var mockLogger = new Mock<ILogger<DevOpsController>>();
        var controller = new DevOpsController(mockLogger.Object);
        
        // Act
        var result = controller.GetDevOpsInfo();
        var resultObj = result as OkObjectResult;
        
        // Assert
        Assert.NotNull(resultObj?.Value);
        Assert.IsType<DevOpsInfo>(resultObj.Value);
        var devOpsInfo = (DevOpsInfo)resultObj.Value;
        Assert.NotNull(devOpsInfo.Contributers);
        Assert.NotNull(devOpsInfo.Practices);
        Assert.NotNull(devOpsInfo.ClassName);
        Assert.Equal(200, resultObj.StatusCode);
    }
    
    [Fact]
    public void DevOpsInfo_Return_Not_Found_If_Null()
    {
        // Arrange
        var mockLogger = new Mock<ILogger<DevOpsController>>();
        var controller = new DevOpsController(mockLogger.Object, false);
        
        // Act
        var result = controller.GetDevOpsInfo();
        var resultObj = result as OkObjectResult;
        
        // Assert
        Assert.NotNull(resultObj?.Value);
        Assert.IsType<DevOpsInfo>(resultObj.Value);
        var devOpsInfo = (DevOpsInfo)resultObj.Value;
        Assert.Null(devOpsInfo.Contributers);
        Assert.Null(devOpsInfo.Practices);
        Assert.Null(devOpsInfo.ClassName);
        Assert.Equal(200, resultObj.StatusCode);
    }
    
}