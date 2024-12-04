using BurguerMania.Domain.Common;
using Microsoft.AspNetCore.Http;

namespace BurguerMania.Application.Dtos.Category
{
    public sealed record CategoryRequest 
    (
        string Name,
        string Description,
        IFormFile Image
    ) : BaseDto;
}