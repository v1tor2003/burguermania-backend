using BurguerMania.Application.Dtos.Product;
using BurguerMania.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BurguerMania.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IBaseUrlService _baseUrlService;

        public ProductsController(IProductService productService, IBaseUrlService baseUrlService) 
        {
            _productService = productService;
            _baseUrlService = baseUrlService;
        }
        
        [HttpGet(Name = "GetProducts")]
        public async Task<ActionResult<IEnumerable<ProductResponse>>> GetProducts()
        {
            var products = await _productService.GetAllAsync<ProductResponse>();
            if(!products.Any()) return NotFound();
            
            //there is a better approach for building the img url, but for now we gonna do this
            
            var baseUrl = _baseUrlService.GetBaseUrl();

            var updatedProducts = products.Select(product => 
            {
                product.PathImage = $"{baseUrl}/{product.PathImage}";
                return product;
            });

            return Ok(updatedProducts);
        }

        [HttpGet("{productId}", Name = "GetProduct")]
        public async Task<ActionResult<ProductResponse>> GetProduct([FromRoute] int productId)
        {
            var product = await _productService.GetByIdAsync<ProductResponse>(productId);
            if(product is null) return NotFound();
            
            var baseUrl = _baseUrlService.GetBaseUrl();
            product.PathImage = $"{baseUrl}/{product.PathImage}";

            return Ok(product);
        }
    }
}
