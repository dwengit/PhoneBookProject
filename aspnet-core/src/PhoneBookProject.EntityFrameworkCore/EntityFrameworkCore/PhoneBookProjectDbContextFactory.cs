using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using PhoneBookProject.Configuration;
using PhoneBookProject.Web;

namespace PhoneBookProject.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class PhoneBookProjectDbContextFactory : IDesignTimeDbContextFactory<PhoneBookProjectDbContext>
    {
        public PhoneBookProjectDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<PhoneBookProjectDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            PhoneBookProjectDbContextConfigurer.Configure(builder, configuration.GetConnectionString(PhoneBookProjectConsts.ConnectionStringName));

            return new PhoneBookProjectDbContext(builder.Options);
        }
    }
}
