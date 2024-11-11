using Microsoft.AspNetCore.Mvc;
using PersonApi.Models.Requests;
using PersonApi.Repositories.Product;

namespace PersonApi.Controllers{

[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
    private readonly IProductRepository _product;
    public ProductController(IProductRepository product)
    {
            _product = product;
    }

[HttpPost("GetAllProducts")]
    public async Task<IActionResult>GetAllProducts([FromBody] GetProductRequest request){

        var result = await _product.GetAllProductAsyncs(request.Id);
        return Ok(result);
    }
}

}