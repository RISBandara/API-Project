using System.Threading.Tasks;
using PersonApi.Models.Responses;

namespace PersonApi.Repositories.PersonDetails
{
    public interface IPersonDetailsRepository
    {
        Task<GetPersonDetailsResponse> GetPersonDetailsAsync(int id);
    }
}
