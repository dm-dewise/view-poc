using MediatR;

namespace user.application.Features.Addresses.Requests
{
    public class CreateUserAddressCommand : IRequest<string>
    {
        public domain.Address Address { get; set; }
    }
}
