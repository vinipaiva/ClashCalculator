using ClashCalculator.Domain.Enum;

namespace ClashCalculator.Domain.Abstract
{
    public abstract class Base
    {
        protected Base()
        {
            
        }
        protected Base(string name, string description, BaseVersion version)
        {
            Name = name;
            Description = description;
            Version = version;
        }

        public int Id { get; protected set; }
        public string Name { get; protected set; }
        public string Description { get; protected set; }
        public BaseVersion Version { get; protected set; }
    }
}
