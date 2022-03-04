namespace Parlem.Services.Data
{
    using System.Linq;
    using System.Threading.Tasks;

    using Parlem.Data.Common.Repositories;
    using Parlem.Data.Models;
    using Parlem.Services.Mapping;

    public class ClientsService : IClientsService
    {
        private IDeletableEntityRepository<Client> repository;

        public ClientsService(IDeletableEntityRepository<Client> clientsRepository)
        {
            this.repository = clientsRepository;
        }

        public async Task<int> AddAsync<T>(T input)
        {
            var item = AutoMapperConfig.MapperInstance.Map<Client>(input);
            await this.repository.AddAsync(item);
            await this.repository.SaveChangesAsync();
            return item.Id;
        }

        public async Task DeleteAsync<T>(int id)
        {
            var item = this.repository.All().FirstOrDefault(x => x.Id == id);
            this.repository.Delete(item);
            await this.repository.SaveChangesAsync();
        }

        public T GetById<T>(int id)
        {
            return this.repository.All().Where(x => x.Id == id).To<T>().FirstOrDefault();
        }

        public T GetByDocNum<T>(string docNum)
        {
            return this.repository.All().Where(x => x.Document.DocNum == docNum).To<T>().FirstOrDefault();
        }

        public async Task<int> UpdateAsync<T>(T input)
        {
            var item = AutoMapperConfig.MapperInstance.Map<Client>(input);
            this.repository.Update(item);
            await this.repository.SaveChangesAsync();
            return item.Id;
        }
    }
}
