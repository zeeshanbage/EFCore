using Microsoft.EntityFrameworkCore;
using webapi.Models;

namespace webapi.Controllers;

public class PostgresqlDbContext: DbContext
{
    public PostgresqlDbContext( DbContextOptions<PostgresqlDbContext> options):base(options)
    {
        
    }
    
    public DbSet<Product>? Products { get; set; }

    public DbSet<Order>? Orders { get; set; }
    public DbSet<User>?  Users { get; set; }

    public DbSet<Address>? Addresses { get; set; }
}