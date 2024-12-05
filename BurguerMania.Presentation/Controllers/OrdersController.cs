using BurguerMania.Application.Dtos.Order;
using BurguerMania.Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BurguerMania.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrdersController(IOrderService orderService) => 
            _orderService = orderService;

        [HttpGet(Name = "GetOrders")]
        public async Task<ActionResult<IEnumerable<OrderResponse>>> GetOrders()
        {
            var orders = await _orderService.GetAllAsync<OrderResponse>();
            if(!orders.Any()) return NotFound();
            
            return Ok(orders);
        }
        //should create the order, no time left to implent
        /*
        [HttpPost(Name = "CreateOrder")]
        public async Task<IActionResult> CreateOrder([FromBody] OrderRequest request)
        {
            
            await _orderService.CreateOrder(request);

            return Created();
        }*/
    }
}
