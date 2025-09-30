using Application.Features.Users;
using FastEndpoints;

namespace TheUltimateApi.Endpoints.Users;

public class GetUsersEndpoint : Endpoint<GetUsersRequest, GetUsersResponse>
{
    public required IUserHandler UserHandler;

    public override void Configure()
    {
        Get("/users");
        AllowAnonymous();
    }

    public override async Task HandleAsync(GetUsersRequest req, CancellationToken ct)
    {
        var response = await UserHandler.GetUsers(req);

        // Send response
        await Send.OkAsync(response);
    }
}
