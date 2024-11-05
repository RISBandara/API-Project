using System.Threading.Tasks;
using PersonApi.Models.Responses;

namespace PersonApi.Repositories.PersonAddress
{
    public interface IPersonAddressRepository
    {
        Task<List<GetPersonAddressResponse>> GetPersonAddressAsync(int id,string owner);
    }
}
