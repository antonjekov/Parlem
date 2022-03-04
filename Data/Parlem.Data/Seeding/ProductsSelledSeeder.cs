namespace Parlem.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using Parlem.Data.Models;

    internal class ProductsSelledSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.ProductsSelled.Any())
            {
                return;
            }

            var productSelled1 = new ProductSelled
            {
                SoldAt = DateTime.Now,
                CustomerId = 1,
                ClientId = 1,
                ProductId = 1,
                TerminalNumber = 933933933,
            };

            var productSelled2 = new ProductSelled
            {
                SoldAt = DateTime.Now,
                CustomerId = 1,
                ClientId = 1,
                ProductId = 4,
                TerminalNumber = 933933933,
            };

            await dbContext.ProductsSelled.AddAsync(productSelled1);
            await dbContext.ProductsSelled.AddAsync(productSelled2);
        }
    }
}
