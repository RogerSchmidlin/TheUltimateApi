using Application.Interfaces;

namespace Application.Features.Users;

public interface IUserHandler
{
    Task<CreateUserResponse> CreateUser(CreateUserRequest request);
    Task<GetUsersResponse> GetUsers(GetUsersRequest request);
}

public class UserHandler : IUserHandler
{
    private readonly IUserRepository _repo;
    public UserHandler(IUserRepository repo) => _repo = repo;
    public async Task<CreateUserResponse> CreateUser(CreateUserRequest request)
    {
        var user = new Domain.Entities.User(request.Email, request.Name);
        await _repo.AddUserAsync(user);
        return new() { UserId = user.Id };
    }

    public async Task<GetUsersResponse> GetUsers(GetUsersRequest request)
    {
        var users = new GetUsersResponse();
        //throw(new Exception("some error 1"));
        return users;
    }
}
