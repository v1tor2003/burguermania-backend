using BurguerMania.Domain.Common;

namespace BurguerMania.Domain.Entities
{
    public class OrderProduct 
    {
        public IntKey OrderId { get; set; }
        public virtual Order Order { get; set; } = null!;

        public IntKey ProductId { get; set; }
        public virtual Product Product { get; set; } = null!;
    }
}