using System;
using System.Collections.Generic;
using CocCalculator.Domain.Abstract;
using CocCalculator.Domain.Enum;

namespace CocCalculator.Domain
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
