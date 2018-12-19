using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using IceSkool.Authorization.Roles;
using IceSkool.Authorization.Users;
using IceSkool.MultiTenancy;

namespace IceSkool.EntityFrameworkCore
{
    public class IceSkoolDbContext : AbpZeroDbContext<Tenant, Role, User, IceSkoolDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public IceSkoolDbContext(DbContextOptions<IceSkoolDbContext> options)
            : base(options)
        {
        }
    }
}
