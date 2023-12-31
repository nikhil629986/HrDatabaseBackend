﻿using HrDatabaseBackend.Model.UserModel;

namespace HrDatabaseBackend.Services.UserService
{
    public interface IUserService
    {
        List<User> Get();
      
        User Get(string id);
        User Create(User user);
        void Update(string id, User user);
        void Remove(string id);
    }
}
