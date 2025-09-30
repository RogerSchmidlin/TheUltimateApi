using Application.Features.Users;
using FastEndpoints;

namespace TheUltimateApi.Endpoints.Users;

public class GetUsersEndpointV2 : Endpoint<GetUsersRequest, GetUsersResponse>
{
    private readonly IUserHandler _handler;

    public GetUsersEndpointV2(IUserHandler handler)
    {
        _handler = handler;
    }

    public override void Configure()
    {
        Get("/users");
        Version(1);
        AllowAnonymous();
    }

    public override async Task HandleAsync(GetUsersRequest req, CancellationToken ct)
    {
        var response = await _handler.GetUsers(req);

        // Send response
        await Send.OkAsync(response);
    }
}
