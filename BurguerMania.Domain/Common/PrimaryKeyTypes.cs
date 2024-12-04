namespace BurguerMania.Domain.Common
{
    public interface IEntityKey 
    { 
        object Value { get; }
    }
    public readonly struct GuidKey : IEntityKey
    {
        public Guid Value { get; }
        public GuidKey(Guid value) => Value = value;

        object IEntityKey.Value => Value;
    } 
    public readonly struct IntKey : IEntityKey
    {
        public int Value { get; }
        public IntKey(int value) => Value = value;
        object IEntityKey.Value => Value;
    }   
}