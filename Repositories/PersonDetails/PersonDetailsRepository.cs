using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using PersonApi.Data;
using PersonApi.Models.Responses;
using System.Linq;
using System.Threading.Tasks;

namespace PersonApi.Repositories.PersonDetails
{
    public class PersonDetailsRepository : IPersonDetailsRepository
    {
        private readonly PersonDbContext _context;

        public PersonDetailsRepository(PersonDbContext context)
        {
            _context = context;
        }

        public async Task<List<GetPersonDetailsResponse>> GetPersonDetailsAsync(int id)
        {
            var sql = "EXEC GetPersonNameById @Id";
            var param = new SqlParameter("@Id", id);

            var result = await _context.PersonDetailsResponses
                .FromSqlRaw(sql, param)
                .ToListAsync();

            return result;
        }
    }
}
