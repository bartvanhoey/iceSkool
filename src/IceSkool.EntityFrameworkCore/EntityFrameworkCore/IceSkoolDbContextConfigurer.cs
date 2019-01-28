using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace IceSkool.EntityFrameworkCore
{
    public static class IceSkoolDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<IceSkoolDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<IceSkoolDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
