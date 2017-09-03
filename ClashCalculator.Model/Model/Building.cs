using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using ClashCalculator.Common.Enum;

namespace ClashCalculator.Common.Model
{
    public class BuildingModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public BaseVersion Version { get; set; }
        public List<BuildingUpgradeModel> BuildingUpgrades { get; set; }
    }

    
}
