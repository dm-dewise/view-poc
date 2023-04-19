using user.domain;

namespace user.application.Contracts.Persistence
{
    public interface IUserRepository
    {
        Task<string> CreateUser(User user);
        Task<List<User>> GetUsers();
    }
}
