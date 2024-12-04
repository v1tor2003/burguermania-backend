using BurguerMania.Domain.Common;

namespace BurguerMania.Application.Dtos.User
{
    public sealed record UserRequest
    (
        string Name,
        string Email,
        string Password
    ) : BaseDto; 
}