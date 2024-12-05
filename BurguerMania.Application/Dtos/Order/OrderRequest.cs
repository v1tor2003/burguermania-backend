using BurguerMania.Domain.Common;

namespace BurguerMania.Application.Dtos.Order
{
    public sealed record OrderRequest
    (     
        Guid UserId, 
        int ProductId,
        int Quantity,
        string Observation
    ) : BaseDto;
}