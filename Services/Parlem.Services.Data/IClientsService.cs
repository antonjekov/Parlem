namespace Parlem.Services.Data
{
    using System.Threading.Tasks;

    public interface IClientsService
    {
        Task<int> AddAsync<T>(T input);

        Task<int> UpdateAsync<T>(T input);

        Task DeleteAsync<T>(int id);

        T GetById<T>(int id);

        T GetByDocNum<T>(string docNum);
    }
}
