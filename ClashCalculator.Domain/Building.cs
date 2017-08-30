using System;
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

        public Building(string name, string description, string imageUrl, BaseVersion version, BuildingType type) : base(name, description, imageUrl, version)
        {
            BuildingType = type;
        }

        public void AddOrUpdateUpgrade(BuildingUpgrade upgrade)
        {
            if (BuildingUpgrades == null)
            {
                BuildingUpgrades = new List<BuildingUpgrade>();
            }
            else
            {
                var existentUpgrade = BuildingUpgrades.Find(b => b.Level == upgrade.Level);
                if(existentUpgrade != null)
                    BuildingUpgrades.Remove(existentUpgrade);
            }
            BuildingUpgrades.Add(upgrade);
        }

        public BuildingType BuildingType { get; private set; }
        public List<BuildingUpgrade> BuildingUpgrades { get; private set; }
    }
}
