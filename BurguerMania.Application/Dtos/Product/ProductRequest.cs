using BurguerMania.Domain.Common;
using Microsoft.AspNetCore.Http;

namespace BurguerMania.Application.Dtos.Product
{
    public sealed record ProductRequest(
        string Name,
        string BaseDescription,
        string FullDescription,
        IFormFile Image,
        decimal Price,
        int CategoryId
    ) : BaseDto;
}