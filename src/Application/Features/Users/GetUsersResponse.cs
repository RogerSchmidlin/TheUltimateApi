namespace Application.Features.Users;

public class GetUsersResponse
{
    List<GetUserResponse> Users { get; set; } = new List<GetUserResponse>();
}

