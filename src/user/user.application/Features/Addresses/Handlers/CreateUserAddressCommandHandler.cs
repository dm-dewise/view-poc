using MediatR;
using user.application.Contracts.Persistence;
using user.application.Features.Addresses.Requests;

namespace user.application.Features.Addresses.Handlers
{
    public class CreateUserAddressCommandHandler : IRequestHandler<CreateUserAddressCommand, string>
    {
        private readonly IAddressRepository _addressRepository;

        public CreateUserAddressCommandHandler(IAddressRepository addressRepository)
        {
            _addressRepository = addressRepository;
        }
        public async Task<string> Handle(CreateUserAddressCommand request, CancellationToken cancellationToken)
        {
            var result = await _addressRepository.CreateUserAddress(request.Address);
            return result.ToString();
        }
    }
}
