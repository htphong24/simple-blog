using System;
using System.Collections.Generic;
using System.Text;
using SimpleBlog.Data.Contracts;

namespace SimpleBlog.Data.Repos
{
    public class UserRepository : EntityBaseRepository<User>, IUserRepository
    {
        public UserRepository(BlogContext context) : base(context) { }

        public bool IsEmailUniq(string email)
        {
            var user = this.GetSingle(u => u.Email == email);
            return user == null;
        }

        public bool IsUsernameUniq(string username)
        {
            var user = this.GetSingle(u => u.Username == username);
            return user == null;
        }
    }

}
