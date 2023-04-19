using Microsoft.EntityFrameworkCore;
using user.domain;

namespace user.infrastructure;
public class ViewallDbContext: DbContext
{
    public ViewallDbContext(DbContextOptions options): base(options) { }

    //model setup
    public DbSet<User> User { get; set; }
    public DbSet<Address> Address { get; set; }
}
