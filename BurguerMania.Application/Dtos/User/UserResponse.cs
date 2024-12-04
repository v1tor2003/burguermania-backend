using BurguerMania.Domain.Common;

namespace BurguerMania.Application.Dtos.User
{
    public sealed record UserResponse : BaseDto
    {
        public Guid UserId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTimeOffset CreatedAt { get; set; }
    }
}