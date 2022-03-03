namespace Parlem.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using Parlem.Data.Models;

    internal class CustomersSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Customers.Any())
            {
                return;
            }

            var customer1 = new Customer()
            {
                Email = "customer1@yahoo.com",
                GivenName = "Customer",
                FamilyName = "One",
                SimpleRoleId = 1,
            };

            var customer2 = new Customer()
            {
                Email = "customer2@yahoo.com",
                GivenName = "Customer",
                FamilyName = "Two",
                SimpleRoleId = 1,
            };

            await dbContext.Customers.AddAsync(customer1);
            await dbContext.Customers.AddAsync(customer2);
        }
    }
}
