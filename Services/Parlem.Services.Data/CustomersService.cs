namespace Parlem.Services.Data
{
    using System.Linq;

    using Parlem.Data.Common.Repositories;
    using Parlem.Data.Models;
    using Parlem.Services.Mapping;

    public class CustomersService : ICustomersService
    {
        private IDeletableEntityRepository<Customer> repository;

        public CustomersService(IDeletableEntityRepository<Customer> customersRepository)
        {
            this.repository = customersRepository;
        }

        public T GetById<T>(int id)
        {
            return this.repository.All().Where(x => x.Id == id).To<T>().FirstOrDefault();
        }
    }
}
