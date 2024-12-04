using BurguerMania.Domain.Common;

namespace BurguerMania.Application.Dtos.Product
{
    public sealed record ProductResponse : BaseDto
    {
        public string Name { get; set; } = string.Empty;
        public string BaseDescription { get; set; } = string.Empty;
        public string FullDescription { get; set; } = string.Empty;
        public string PathImage { get; set; } = string.Empty;
        public decimal Price { get; set; }
    }
    
}