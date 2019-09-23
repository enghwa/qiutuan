using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using FargateDemo.Configuration;
using FargateDemo.Web;

namespace FargateDemo.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class FargateDemoDbContextFactory : IDesignTimeDbContextFactory<FargateDemoDbContext>
    {
        public FargateDemoDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<FargateDemoDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            FargateDemoDbContextConfigurer.Configure(builder, configuration.GetConnectionString(FargateDemoConsts.ConnectionStringName));

            return new FargateDemoDbContext(builder.Options);
        }
    }
}
