using FitnessApp.Infrastructure.Food.Handlers;
using FitnessApp.Infrastructure.Food.Queries;
using MediatR;

namespace UnitTests;

public class FoodHandlersTests
{
    [Fact]
    public void GetById_PassNullId_ThrowsArgumentNullException()
    {
        int? id = null;

        var command = new GetByIdQuery(id, "url");

        var handler = new GetByIdHandler(null,null);

        Assert.ThrowsAsync<ArgumentNullException>(async () => await handler.Handle(command, CancellationToken.None));
    }
}