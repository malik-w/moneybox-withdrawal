﻿using System;

namespace Moneybox.App
{
    public class User
    {
        public User(Guid id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }

        public Guid Id { get; }

        public string Name { get; }

        public string Email { get; }
    }
}
