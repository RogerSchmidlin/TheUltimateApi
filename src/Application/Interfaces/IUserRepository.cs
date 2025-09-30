﻿using Domain.Entities;

namespace Application.Interfaces;

public interface IUserRepository
{
    Task<User> AddUserAsync(User user);
}
