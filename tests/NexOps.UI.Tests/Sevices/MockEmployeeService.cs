using FluentAssertions;
using NexOps.UI.Services;
using NexOps.UI.Models;

namespace NexOps.UI.Test.Services;

public class MockEmployeeServiceTests
{
    private readonly MockEmployeeService _svc = new();

    [Fact]
    public async Task GetAllAsync_ShouldReturnsEmployees()
    {
        // Act
        var result = await _svc.GetAllAsync();

        // Assert
        result.Should().NotBeNull();
        result.Should().NotBeNull();
    }

    [Fact]
    public async Task GetByIdAsync_WithValidId_ShouldReturnEmployee()
    {
        // Arrange
        var employees = await _svc.GetAllAsync();
        var firstId = employees.First().Id;

        // Act
        var result = await _svc.GetByIdAsync(firstId);

        // Assert
        result.Should().NotBeNull();
        result!.Id.Should().Be(firstId);
    }
}