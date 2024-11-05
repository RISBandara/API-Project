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

        public async Task<List<GetPersonAddressResponse>> GetPersonAddressAsync(int id,string owner)
        {
            var sql = "EXEC GetAddressById @Id ,@Owner";
                 var param = new[]
            {
                new SqlParameter("@Id", id),
                new SqlParameter("@Owner", string.IsNullOrEmpty(owner) ? DBNull.Value : owner)
               
            };

            var result = await _context.PersonAddressResponses
                .FromSqlRaw(sql, param)
                .ToListAsync();

            return result;
        }
    }
}
