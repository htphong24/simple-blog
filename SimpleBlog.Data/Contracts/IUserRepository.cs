namespace SimpleBlog.Data.Contracts
{
    public interface IUserRepository : IEntityBaseRepository<User>
    {
        bool IsUsernameUniq(string username);
        bool IsEmailUniq(string email);
    }
}
