namespace Parlem.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using Parlem.Common;
    using Parlem.Data.Models;

    internal class SimpleRolesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.SimpleRoles.Any())
            {
                return;
            }

            await dbContext.SimpleRoles.AddAsync(new SimpleRole { Name = GlobalConstants.CustomerRoleName });
            await dbContext.SimpleRoles.AddAsync(new SimpleRole { Name = GlobalConstants.ClientRoleName });
        }
    }
}
