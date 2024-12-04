namespace BurguerMania.Domain.Common
{
    public class BaseEntity<PK> where PK : IEntityKey
    {
        public required PK Id { get; set; }
        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;
        public DateTimeOffset? UpdatedAt { get; set; }
    }
}