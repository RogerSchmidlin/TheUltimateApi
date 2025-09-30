using Application.Features.Users;
using FastEndpoints;

namespace TheUltimateApi.Endpoints.Users;

public class GetUsersEndpoint : Endpoint<GetUsersRequest, GetUsersResponse>
{
    private readonly IUserHandler _handler;

    public GetUsersEndpoint(IUserHandler handler)
    {
        _handler = handler;
    }

    public override void Configure()
    {
        Get("/users");
        AllowAnonymous();
    }

    public override async Task HandleAsync(GetUsersRequest req, CancellationToken ct)
    {
        var response = await _handler.GetUsers(req);

        // Send response
        await Send.OkAsync(response);
    }
}
