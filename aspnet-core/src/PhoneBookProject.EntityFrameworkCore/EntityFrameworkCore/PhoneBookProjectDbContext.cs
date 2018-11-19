using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using PhoneBookProject.Authorization.Roles;
using PhoneBookProject.Authorization.Users;
using PhoneBookProject.MultiTenancy;

namespace PhoneBookProject.EntityFrameworkCore
{
    public class PhoneBookProjectDbContext : AbpZeroDbContext<Tenant, Role, User, PhoneBookProjectDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public PhoneBookProjectDbContext(DbContextOptions<PhoneBookProjectDbContext> options)
            : base(options)
        {
        }
    }
}
