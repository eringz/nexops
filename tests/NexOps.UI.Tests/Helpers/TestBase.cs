using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using NexOps.UI.Services;

namespace NexOps.UI.Tests.Helpers;

public abstract class TestBase : TestContent
{
    protected readonly Mock<IEmployeeService> MockEmployeeService;

    protected TestBase()
    {
        MockEmployeeService = new Mock<IEmployeeService>();
        Services.AddScoped(_ => MockEmployeeService.Object);
    }
}

