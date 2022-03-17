using System;
using System.Collections.Generic;
using System.Text;
using SimpleBlog.Data;
using SimpleBlog.Data.Contracts;

namespace SimpleBlog.Services.Contracts
{
    public interface IUserRepository : IEntityBaseRepository<User>
    {
        bool IsUsernameUniq(string username);
        bool IsEmailUniq(string email);
    }
}
