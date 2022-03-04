namespace Parlem.Services.Data
{
    using System.Collections.Generic;

    public interface IProductsSelledService
    {
        IEnumerable<T> GetByDocNum<T>(string docNum);
    }
}
