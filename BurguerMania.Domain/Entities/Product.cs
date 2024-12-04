using System.ComponentModel.DataAnnotations.Schema;
using BurguerMania.Domain.Common;

namespace BurguerMania.Domain.Entities
{
    public class Product : BaseEntity<IntKey>
    {
        public string Name { get; set; } = string.Empty;
        public string PathImage { get; set; } = string.Empty;
        public string BaseDescription { get; set; } = string.Empty;
        public string FullDescription { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public IntKey CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; } = null!;
         public virtual ICollection<OrderProduct> OrderProducts { get; set; } = [];
    }
}