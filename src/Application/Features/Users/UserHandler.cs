using Application.Interfaces;
using Domain.Entities;

namespace Application.Features.Users;

public interface IUserHandler
{
    Task<User> CreateUser(User user);
    Task<GetUsersResponse> GetUsers(GetUsersRequest request);
}

public class UserHandler : IUserHandler
{
    private readonly IUserRepository _repo;
    public UserHandler(IUserRepository repo) => _repo = repo;
    public async Task<User> CreateUser(User user)
    {
        await _repo.AddUserAsync(user);
        return user;
    }

    public async Task<GetUsersResponse> GetUsers(GetUsersRequest request)
    {
        var users = new GetUsersResponse();
        //throw(new Exception("some error 1"));
        return users;
    }
}
