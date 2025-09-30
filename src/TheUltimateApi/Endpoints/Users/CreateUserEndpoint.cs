using Application.Features.Users;
using FastEndpoints;

namespace FastEndpointsDemo.Endpoints.Users;

public class CreateUserEndpoint : Endpoint<CreateUserRequest, CreateUserResponse>
{
    private readonly IUserHandler _handler;

    public CreateUserEndpoint(IUserHandler handler)
    {
        _handler = handler;
    }

    public override void Configure()
    {
        Post("/users");
        AllowAnonymous();
    }

    public override async Task HandleAsync(CreateUserRequest req, CancellationToken ct)
    {
        var response = await _handler.CreateUser(req);

        // Send response
        await Send.OkAsync(response);
    }
}
