using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace FargateDemo.EntityFrameworkCore
{
    public static class FargateDemoDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<FargateDemoDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<FargateDemoDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
