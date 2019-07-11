using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using OpenPOS.Users.Configuration;
using OpenPOS.Users.Web;

namespace OpenPOS.Users.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class UsersDbContextFactory : IDesignTimeDbContextFactory<UsersDbContext>
    {
        public UsersDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<UsersDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            UsersDbContextConfigurer.Configure(builder, configuration.GetConnectionString(UsersConsts.ConnectionStringName));

            return new UsersDbContext(builder.Options);
        }
    }
}
