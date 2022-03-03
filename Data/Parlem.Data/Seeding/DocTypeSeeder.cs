namespace Parlem.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using Parlem.Data.Models;

    internal class DocTypeSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.DocTypes.Any())
            {
                return;
            }

            await dbContext.DocTypes.AddAsync(new DocType { Name = "nie" });
            await dbContext.DocTypes.AddAsync(new DocType { Name = "nif" });
        }
    }
}
