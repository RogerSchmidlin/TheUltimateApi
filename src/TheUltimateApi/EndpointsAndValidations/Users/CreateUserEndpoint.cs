using Application.Features.Users;
using FastEndpoints;
using TheUltimateApi.EndpointsAndValidations.Users;

namespace TheUltimateApi.Endpoints.Users;

public class CreateUserEndpoint : Endpoint<CreateUserRequest, CreateUserResponse, CreateUserMapper>
{
    public required IUserHandler UserHandler {  get; set; }

    public override void Configure()
    {
        Post("/users");
        AllowAnonymous();
    }

    public override async Task HandleAsync(CreateUserRequest req, CancellationToken ct)
    {
        var mappedUser = Map.ToEntity(req);
        var newUser = await UserHandler.CreateUser(mappedUser);
        var response = Map.FromEntity(newUser);
        await Send.OkAsync(response);
    }
}
