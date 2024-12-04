namespace BurguerMania.Domain.Common
{
    public class BaseEntity<PK> 
    {
        public required PK Id { get; set; }
        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.Now;
        public DateTimeOffset? UpdatedAt { get; set; }
    }
}