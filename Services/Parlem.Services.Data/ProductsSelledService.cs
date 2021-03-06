namespace Parlem.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using Parlem.Data.Common.Repositories;
    using Parlem.Data.Models;
    using Parlem.Services.Mapping;

    public class ProductsSelledService : IProductsSelledService
    {
        private IDeletableEntityRepository<ProductSelled> repository;

        public ProductsSelledService(IDeletableEntityRepository<ProductSelled> productSelledRepository)
        {
            this.repository = productSelledRepository;
        }

        public IEnumerable<T> GetByDocNum<T>(string docNum)
        {
            return this.repository.All().Where(x => x.Client.Document.DocNum == docNum).To<T>().ToList();
        }
    }
}
