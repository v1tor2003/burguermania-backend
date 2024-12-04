using System.ComponentModel.DataAnnotations.Schema;
using BurguerMania.Domain.Common;

namespace BurguerMania.Domain.Entities
{
    public class Product : BaseEntity<int>
    {
        public string Name { get; set; } = string.Empty;
        public string PathImage { get; set; } = string.Empty;
        public string BaseDescription { get; set; } = string.Empty;
        public string FullDescription { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual required Category Category { get; set; }
        public virtual ICollection<Order> Orders { get; set; } = [];
    }
}