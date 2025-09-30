namespace Application.Features.Users;

public class GetUsersResponse
{
    public List<GetUserResponse> Users { get; set; } = new List<GetUserResponse>();
}

