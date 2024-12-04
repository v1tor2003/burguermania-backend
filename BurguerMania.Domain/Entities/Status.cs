using BurguerMania.Domain.Common;

namespace BurguerMania.Domain.Entities
{
    public class Status : BaseEntity<int>
    {
        public required string Name { get; set; }
        public virtual ICollection<Order> Orders { get; set; } = [];
    }
}