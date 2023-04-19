using MediatR;
using user.application.Contracts.Persistence;
using user.application.Features.Users.Requests;
using user.domain;

namespace user.application.Features.Users.Handlers
{
    public class GetUserListCommandHandler : IRequestHandler<GetUserListCommand, List<User>>
    {
        private readonly IUserRepository _userRepository;
        public GetUserListCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<List<User>> Handle(GetUserListCommand request, CancellationToken cancellationToken)
        {
            var result = await _userRepository.GetUsers();
            if (result == null)
            {
                return new List<User>();
            }
            return result;
        }
    }
}
