using BurguerMania.Domain.Common;

namespace BurguerMania.Application.Dtos.Order
{
    public sealed record OrderRequest
    (
        decimal Value,       
        int StatusId,
        Guid UserId 
    ) : BaseDto;
}