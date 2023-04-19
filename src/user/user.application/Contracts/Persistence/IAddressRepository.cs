using user.domain;

namespace user.application.Contracts.Persistence
{
    public interface IAddressRepository
    {
        Task<string> CreateUserAddress(Address address);
        Task<List<Address>> GetUserAddresses();
    }
}
