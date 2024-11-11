using System.Threading.Tasks;
using PersonApi.Models.Responses;


namespace PersonApi.Repositories.Product{

public interface IProductRepository{

 Task <List<GetProductResponse>> GetAllProductAsyncs(int id);

}
}
