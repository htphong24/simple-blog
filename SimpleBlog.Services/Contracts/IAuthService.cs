using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleBlog.Services.Contracts
{
    public interface IAuthService
    {
        string HashPassword(string password);
        bool VerifyPassword(string actualPassword, string hashedPassword);
        AuthData GetAuthData(string id);
    }
}
