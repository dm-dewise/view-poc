using MediatR;
using user.domain;

namespace user.application.Features.Users.Requests
{
    public class GetUserListCommand: IRequest<List<User>>
    {
    }
}
