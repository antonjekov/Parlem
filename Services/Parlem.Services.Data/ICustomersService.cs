namespace Parlem.Services.Data
{
    using System.Threading.Tasks;

    public interface ICustomersService
    {
        T GetById<T>(int id);
    }
}
