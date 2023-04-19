using MediatR;

namespace user.application.Features.Users.Requests
{
    public class CreateUserCommand : IRequest<string>
    {
        public domain.User User { get; set; }
    }
}
