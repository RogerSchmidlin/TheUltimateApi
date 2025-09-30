﻿namespace Domain.Entities;

public class User
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string Name { get; private set; }
    public string Email { get; private set; }

    public User(string name, string email)
    {
        Name = name;
        Email = email;
    }
}
