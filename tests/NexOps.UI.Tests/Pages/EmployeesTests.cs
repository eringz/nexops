using Bunit;
usin FluentAssertions;
using Moq;
using NexOps.UI.Pages;
using NexOps.UI.Services;
using NexOps.UI.Models;
using Microsoft.Extensions.DependencyInjection;

namespace NexOps.UI.TestsPages;

public class EmployeesTests : TestContest
{
    [Fact]
    public void EmployeesPage_ShouldDisplayEmployeeData()
    {
        // Arrange
        var mockService = new Mock<IEmployeeService>();
        mockService.Setup(s => s.GetAllAsync())
            .ReturnAsync(new List<EmployeeDto>
            {
                new(Guid.NewGuid(), "Test User", "test@example.com", "Agent", true)
            });
        
        Services.AddScoped(_ => mockService.Object);

        // Act
        var cut = RenderComponent<Employees>();

        // Assert 
        var rows = cut.FindAll("tr");
        rows.Should().HaveCountGreaterThan(1);

        var cells = cut.FindAll("td");
        cells[0].TextContent.Should().Contain("Test User");

        
    }
}