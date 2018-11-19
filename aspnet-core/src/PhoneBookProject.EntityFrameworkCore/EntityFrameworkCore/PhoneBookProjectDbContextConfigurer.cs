using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace PhoneBookProject.EntityFrameworkCore
{
    public static class PhoneBookProjectDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<PhoneBookProjectDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<PhoneBookProjectDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
