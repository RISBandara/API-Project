using System.Threading.Tasks;
using PersonApi.Models.Responses;

namespace PersonApi.Repositories.PersonDetails
{
    public interface IPersonDetailsRepository
    {
        Task<List<GetPersonDetailsResponse>> GetPersonDetailsAsync(int id);
    }
}
