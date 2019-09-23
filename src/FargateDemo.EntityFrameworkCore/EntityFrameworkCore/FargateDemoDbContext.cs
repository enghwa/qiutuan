using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using FargateDemo.Authorization.Roles;
using FargateDemo.Authorization.Users;
using FargateDemo.MultiTenancy;

namespace FargateDemo.EntityFrameworkCore
{
    public class FargateDemoDbContext : AbpZeroDbContext<Tenant, Role, User, FargateDemoDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public FargateDemoDbContext(DbContextOptions<FargateDemoDbContext> options)
            : base(options)
        {
        }
    }
}
