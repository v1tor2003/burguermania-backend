using System.ComponentModel.DataAnnotations.Schema;
using BurguerMania.Domain.Common;

namespace BurguerMania.Domain.Entities
{
    public class Order : BaseEntity<IntKey>
    {
        public int Quantity { get; set; }
        public string Observation { get; set; } = string.Empty;
        public IntKey StatusId { get; set; }
        public GuidKey UserId { get; set; }
        [ForeignKey("StatusId")]
        public virtual Status Status { get; set; } = null!;
        [ForeignKey("UserId")]
        public virtual User User { get; set; } = null!;
        public virtual ICollection<OrderProduct> OrderProducts { get; set; } = [];
    }   
}