using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using OpenPOS.Users.Authorization.Roles;
using OpenPOS.Users.Authorization.Users;
using OpenPOS.Users.MultiTenancy;

namespace OpenPOS.Users.EntityFrameworkCore
{
    public class UsersDbContext : AbpZeroDbContext<Tenant, Role, User, UsersDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public UsersDbContext(DbContextOptions<UsersDbContext> options)
            : base(options)
        {
        }
    }
}
