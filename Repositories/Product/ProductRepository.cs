using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using PersonApi.Data;
using PersonApi.Models.Responses;

namespace PersonApi.Repositories.Product
{

    public class ProductRepository:IProductRepository 
    {
        private readonly PersonDbContext _context;
        public ProductRepository(PersonDbContext context)
        {
        _context = context;

        }


    public async Task<List<GetProductResponse>>GetAllProductAsyncs(int id){

 var sql = "EXEC GetProducts @Id ";
                 var param = new[]
            {
                new SqlParameter("@Id", id)
             
            };

            var result = await _context.PrductDetailsResponse
                .FromSqlRaw(sql, param)
                .ToListAsync();

            return result;
    }

    }

}
