using Parlem.Common;
using Parlem.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parlem.Data.Seeding
{
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
