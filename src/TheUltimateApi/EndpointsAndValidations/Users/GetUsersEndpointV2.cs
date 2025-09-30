using Application.Features.Users;
using FastEndpoints;

namespace TheUltimateApi.Endpoints.Users;

public class GetUsersEndpointV2 : Endpoint<GetUsersRequest, GetUsersResponse>
{
    public required IUserHandler UserHandler;

    public override void Configure()
    {
        Get("/users");
        Version(1);
        AllowAnonymous();
    }

    public override async Task HandleAsync(GetUsersRequest req, CancellationToken ct)
    {
        var response = await UserHandler.GetUsers(req);
        response.Users.Add(new GetUserResponse { User = new UserDto { Name = "User Version 1" } });

        // Send response
        await Send.OkAsync(response);
    }
}
