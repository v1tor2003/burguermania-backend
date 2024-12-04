using BurguerMania.Domain.Common;

namespace BurguerMania.Application.Dtos.Order
{
    public sealed record OrderResponse : BaseDto
    {
        public int Id { get; set; }
        public string StatusName { get; set; } = string.Empty;
     } 
}