using System.Threading.Tasks;
using PersonApi.Models.Responses;

namespace PersonApi.Repositories.PersonAddress
{
    public interface IPersonAddressRepository
    {
        Task<GetPersonAddressResponse> GetPersonAddressAsync(int id);
    }
}