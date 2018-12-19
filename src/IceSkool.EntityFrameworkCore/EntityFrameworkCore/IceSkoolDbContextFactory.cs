using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using IceSkool.Configuration;
using IceSkool.Web;

namespace IceSkool.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class IceSkoolDbContextFactory : IDesignTimeDbContextFactory<IceSkoolDbContext>
    {
        public IceSkoolDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<IceSkoolDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            IceSkoolDbContextConfigurer.Configure(builder, configuration.GetConnectionString(IceSkoolConsts.ConnectionStringName));

            return new IceSkoolDbContext(builder.Options);
        }
    }
}
