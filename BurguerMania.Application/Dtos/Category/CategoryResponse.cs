using BurguerMania.Domain.Common;

namespace BurguerMania.Application.Dtos.Category
{
    public sealed record CategoryResponse : BaseDto
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string PathImage { get; set; } = string.Empty;
    }
}