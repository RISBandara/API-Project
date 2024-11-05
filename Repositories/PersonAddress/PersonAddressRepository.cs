using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using PersonApi.Data;
using PersonApi.Models.Responses;
using System.Linq;
using System.Threading.Tasks;

namespace PersonApi.Repositories.PersonAddress
{
    public class PersonAddressRepository : IPersonAddressRepository
    {
        private readonly PersonDbContext _context;

        public PersonAddressRepository(PersonDbContext context)
        {
            _context = context;
        }

        public async Task<GetPersonAddressResponse> GetPersonAddressAsync(int id)
        {
            var sql = "EXEC GetAddressById @Id";
            var param = new SqlParameter("@Id", id);

            var result = await _context.PersonAddressResponses
                .FromSqlRaw(sql, param)
                .ToListAsync();

            return result.FirstOrDefault();
        }
    }
}
