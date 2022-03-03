namespace Parlem.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using Parlem.Data.Models;

    internal class ClientsSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Clients.Any())
            {
                return;
            }

            var client1 = new Client()
            {
                Email = "client1@yahoo.com",
                GivenName = "Client",
                FamilyName1 = "One",
                CustomerId = 1,
                DocumentId = 1,
                Phone = "766123123",
                Document = new Document() { DocTypeId = 1, DocNum = "11223344E" },
                SimpleRoleId = 2,
            };

            var client2 = new Client()
            {
                Email = "client2@yahoo.com",
                GivenName = "Client",
                FamilyName1 = "Two",
                CustomerId = 1,
                DocumentId = 1,
                Phone = "635123123",
                Document = new Document() { DocTypeId = 2, DocNum = "Y34534532L" },
                SimpleRoleId = 2,
            };

            await dbContext.Clients.AddAsync(client1);
            await dbContext.Clients.AddAsync(client2);
        }
    }
}
