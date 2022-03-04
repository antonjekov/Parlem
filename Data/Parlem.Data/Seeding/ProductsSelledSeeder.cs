using Parlem.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parlem.Data.Seeding
{
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
