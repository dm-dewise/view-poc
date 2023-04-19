using user.application.Contracts.Persistence;
using user.domain;

namespace user.infrastructure.Repositories
{
    public class AddressRepository : IAddressRepository
    {
        protected readonly ViewallDbContext _context;
        public AddressRepository(ViewallDbContext context)
        {
            _context = context;
        }
        public async Task<string> CreateUserAddress(Address address)
        {
            var response =  await _context.Address.AddAsync(address);
            if (response != null) {
                await _context.SaveChangesAsync();
                return address.Id.ToString();
            }
            return "";
        }

        public Task<List<Address>> GetUserAddresses()
        {
            throw new NotImplementedException();
        }
    }
}
