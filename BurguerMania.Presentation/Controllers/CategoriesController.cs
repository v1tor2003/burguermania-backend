using BurguerMania.Application.Dtos.Category;
using BurguerMania.Application.Dtos.Product;
using BurguerMania.Domain.Common;
using BurguerMania.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BurguerMania.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IBaseUrlService _baseUrlService;

        public CategoriesController(ICategoryService categoryService, IBaseUrlService baseUrlService) 
        {
            _categoryService = categoryService;
            _baseUrlService = baseUrlService;
        }
        
        [HttpGet(Name = "GetCategories")]
        public async Task<ActionResult<IEnumerable<CategoryResponse>>> GetCategories()
        {
            var categories = await _categoryService.GetAllAsync<CategoryResponse>();
            if(!categories.Any()) return NotFound();
            //there is a better approach for building the img url, but for now we gonna do this
            var baseUrl = _baseUrlService.GetBaseUrl();

            var updatedCategories = categories.Select(category => 
            {
                category.PathImage = $"{baseUrl}/{category.PathImage}";
                return category;
            });

            return Ok(updatedCategories);
        }

        [HttpGet("{categoryId}/Products",Name = "GetCategoryProducts")]
        public async Task<ActionResult<IEnumerable<ProductResponse>>> GetCategoryProducts([FromRoute] int categoryId)
        {
            var products = await _categoryService.GetProductsAsync<ProductResponse>(categoryId);
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
    }
}
