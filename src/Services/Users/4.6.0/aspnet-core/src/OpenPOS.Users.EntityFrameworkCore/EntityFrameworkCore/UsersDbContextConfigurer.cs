using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace OpenPOS.Users.EntityFrameworkCore
{
    public static class UsersDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<UsersDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<UsersDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
