using ClashCalculator.Common.Enum;

namespace ClashCalculator.Domain.Abstract
{
    public abstract class Base
    {
        protected Base()
        {
            
        }
        protected Base(string name, string description, string imageUrl, BaseVersion version)
        {
            Name = name;
            Description = description;
            Version = version;
            ImageUrl = imageUrl;
        }

        public int Id { get; protected set; }
        public string Name { get; protected set; }
        public string Description { get; protected set; }
        public string ImageUrl { get; protected set; }
        public BaseVersion Version { get; protected set; }
    }
}
