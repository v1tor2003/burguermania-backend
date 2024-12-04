using BurguerMania.Domain.Common;

namespace BurguerMania.Domain.Entities
{
    public class Category : BaseEntity<int>
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string PathImage { get; set; } = string.Empty; 

        public virtual ICollection<Product> Products { get; set;} = [];
    }
}