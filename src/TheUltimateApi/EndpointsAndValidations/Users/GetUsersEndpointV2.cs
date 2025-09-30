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
        response.Users.Add(new GetUserResponse { User = new UserDto { Name = "User Version 1" } });

        // Send response
        await Send.OkAsync(response);
    }
}
