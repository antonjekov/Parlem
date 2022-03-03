using Parlem.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parlem.Data.Seeding
{
    internal class ProductsSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Products.Any())
            {
                return;
            }

            await dbContext.Products.AddAsync(new Product { Name = "FIBRA 100", TypeName = "ftth" });
            await dbContext.Products.AddAsync(new Product { Name = "FIBRA 600", TypeName = "ftth" });
            await dbContext.Products.AddAsync(new Product { Name = "FIBRA 1000", TypeName = "ftth" });
            await dbContext.Products.AddAsync(new Product { Name = "MOVIL 5GB", TypeName = "movil" });
            await dbContext.Products.AddAsync(new Product { Name = "MOVIL 10GB", TypeName = "movil" });
            await dbContext.Products.AddAsync(new Product { Name = "MOVIL 15GB", TypeName = "movil" });
        }
    }
}
