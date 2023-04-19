using System.Net;
using user.application.Contracts.Persistence;
using user.domain;

namespace user.infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        protected readonly ViewallDbContext _context;
        public UserRepository(ViewallDbContext context)
        {
            _context = context;
        }
        public async Task<string> CreateUser(User user)
        {
            var response = await _context.User.AddAsync(user);
            if (response != null)
            {
                await _context.SaveChangesAsync();
                return user.Id.ToString();
            }
            return "";
        }

        public Task<List<User>> GetUsers()
        {
            var users = _context.User.ToList();
            return Task.FromResult(users);
        }
    }
}
