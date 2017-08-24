using System.Collections.Generic;
using ClashCalculator.Domain.Abstract;
using ClashCalculator.Domain.Enum;

namespace ClashCalculator.Domain
{
    public class Building : Base
    {
        internal Building()
        {
            
        }

        public Building(string name, string description, BaseVersion version) : base(name, description, version)
        {

        }

        public BuildingType BuildingType { get; private set; }
        public List<BuildingUpgrade> BuildingUpgrades { get; private set; }
    }
}
