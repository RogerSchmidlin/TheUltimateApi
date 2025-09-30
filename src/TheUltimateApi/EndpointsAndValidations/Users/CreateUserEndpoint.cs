using Application.Features.Users;
using FastEndpoints;

namespace TheUltimateApi.Endpoints.Users;

public class CreateUserEndpoint : Endpoint<CreateUserRequest, CreateUserResponse>
{
    public required IUserHandler UserHandler {  get; set; }

    public override void Configure()
    {
        Post("/users");
        AllowAnonymous();
    }

    public override async Task HandleAsync(CreateUserRequest req, CancellationToken ct)
    {
        var response = await UserHandler.CreateUser(req);

        // Send response
        await Send.OkAsync(response);
    }
}
