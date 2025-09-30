using Application.Features.Users;
using Domain.Entities;
using FastEndpoints;

namespace TheUltimateApi.EndpointsAndValidations.Users;

public class CreateUserMapper : Mapper<CreateUserRequest, CreateUserResponse, User>
{
    public override User ToEntity(CreateUserRequest r) => new()
    {
        Id = Guid.NewGuid(),
        Name = r.Name,
        Email = r.Email
    };

    public override CreateUserResponse FromEntity(User e) => new()
    {
        UserId = e.Id
    };
}
