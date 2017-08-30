using ClashCalculator.Database;
using ClashCalculator.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ClashCalculator.Aggregate
{
    public class BuilderVillageAggregate : BaseAggregate
    {
        public BuilderVillageAggregate(ClashCalculatorContext context): base(context)
        {

        }

        public ICollection<Building> Buildings { get; private set; }
        public ICollection<Troop> Troops { get; private set; }

        public void SetBuilderVillageLevel(int level)
        {
            Buildings = this._dbContext.Buildings
                .Include(b => b.BuildingUpgrades.Select(u => u.RequirementLevel <= level))
                .ToList();
            Troops = this._dbContext.Troops
                .Include(b => b.TroopResearches.Select(u => u.RequirementLevel <= level))
                .ToList();
        }

        

    }
}
