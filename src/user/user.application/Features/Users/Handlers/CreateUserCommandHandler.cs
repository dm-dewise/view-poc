using MediatR;
using user.application.Contracts.Persistence;
using user.application.Features.Users.Requests;

namespace user.application.Features.Users.Handlers
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, string>
    {
        private readonly IUserRepository _userRepository;
        public CreateUserCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<string> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var result = await _userRepository.CreateUser(request.User);
            return result.ToString();
        }
    }
}
