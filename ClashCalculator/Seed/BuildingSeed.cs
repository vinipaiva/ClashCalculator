using ClashCalculator.Domain;
using ClashCalculator.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClashCalculator.Database.Seed
{
    public static class BuildingSeed
    {
        public static void Seed(ClashCalculatorContext context)
        {
            var buildings = new Building[]
            {
                new Building("Builder Hall", "Description", "http://test.com", BaseVersion.BuilderBase, BuildingType.Other),
                new Building("Clock Tower", "Description", "http://test.com", BaseVersion.BuilderBase, BuildingType.Other),
                new Building("Gem Mine", "Description", "http://test.com", BaseVersion.BuilderBase, BuildingType.Other),
                new Building("Star Lab", "Description", "http://test.com", BaseVersion.BuilderBase, BuildingType.Other),
                new Building("Battle Machine Altar", "Description", "http://test.com", BaseVersion.BuilderBase, BuildingType.Other),

                new Building("Army Camp", "Description", "http://test.com", BaseVersion.BuilderBase, BuildingType.Offense),
                new Building("Builder Barrack", "Description", "http://test.com", BaseVersion.BuilderBase, BuildingType.Offense),
               

                new Building("Elixir Collector", "Description", "http://test.com", BaseVersion.BuilderBase, BuildingType.Resource),
                new Building("Elixir Storage", "Description", "http://test.com", BaseVersion.BuilderBase, BuildingType.Resource),
                new Building("Gold Collector", "Description", "http://test.com", BaseVersion.BuilderBase, BuildingType.Resource),
                new Building("Gold Storage", "Description", "http://test.com", BaseVersion.BuilderBase, BuildingType.Resource),

                new Building("Cannon", "Description", "http://test.com", BaseVersion.BuilderBase, BuildingType.Defense),
                new Building("Double Cannon", "Description", "http://test.com", BaseVersion.BuilderBase, BuildingType.Defense),
                new Building("Archer Tower", "Description", "http://test.com", BaseVersion.BuilderBase, BuildingType.Defense),
                new Building("Hidden Tesla", "Description", "http://test.com", BaseVersion.BuilderBase, BuildingType.Defense),
                new Building("Firecrackers", "Description", "http://test.com", BaseVersion.BuilderBase, BuildingType.Defense),
                new Building("Crusher", "Description", "http://test.com", BaseVersion.BuilderBase, BuildingType.Defense),
                new Building("Guard Post", "Description", "http://test.com", BaseVersion.BuilderBase, BuildingType.Defense),
                new Building("Air Bombs", "Description", "http://test.com", BaseVersion.BuilderBase, BuildingType.Defense),
                new Building("Multi Mortar", "Description", "http://test.com", BaseVersion.BuilderBase, BuildingType.Defense),
                new Building("Roaster", "Description", "http://test.com", BaseVersion.BuilderBase, BuildingType.Defense),
                new Building("Push Trap", "Description", "http://test.com", BaseVersion.BuilderBase, BuildingType.Defense),
                new Building("Spring Trap", "Description", "http://test.com", BaseVersion.BuilderBase, BuildingType.Defense),
                new Building("Mine", "Description", "http://test.com", BaseVersion.BuilderBase, BuildingType.Defense),
                new Building("Mega Mine", "Description", "http://test.com", BaseVersion.BuilderBase, BuildingType.Defense),
                
            };

            foreach(var b in buildings)
            {
                context.Buildings.Add(b);
            }
            context.SaveChanges();

            
        }
    }
}
