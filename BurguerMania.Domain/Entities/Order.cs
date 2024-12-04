using System.ComponentModel.DataAnnotations.Schema;
using BurguerMania.Domain.Common;

namespace BurguerMania.Domain.Entities
{
    public class Order : BaseEntity<int>
    {
        public decimal Value { get; set; }
        public int StatusId { get; set; }
        public Guid UserId { get; set; }
        [ForeignKey("StatusId")]
        public virtual required Status Status { get; set; }
        [ForeignKey("UserId")]
        public virtual required User User { get; set; }
        public virtual ICollection<Product> Products { get; set; } = [];
    }   
}