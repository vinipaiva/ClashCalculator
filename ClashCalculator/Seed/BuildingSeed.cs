using ClashCalculator.Domain;
using ClashCalculator.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
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

            var builderHall = buildings.FirstOrDefault(b => b.Name == "Builder Hall");
            builderHall.AddOrUpdateUpgrade(new BuildingUpgrade(1, 1, 0, 0, ResourceType.Gold));
            builderHall.AddOrUpdateUpgrade(new BuildingUpgrade(1, 2, TimeSpan.FromSeconds(5).Ticks, 3500, ResourceType.Gold)); 
            builderHall.AddOrUpdateUpgrade(new BuildingUpgrade(2, 3, TimeSpan.FromHours(1).Ticks, 30000, ResourceType.Gold)); 
            builderHall.AddOrUpdateUpgrade(new BuildingUpgrade(3, 4, TimeSpan.FromDays(1).Ticks, 200000, ResourceType.Gold)); 
            builderHall.AddOrUpdateUpgrade(new BuildingUpgrade(4, 5, TimeSpan.FromDays(2).Ticks, 400000, ResourceType.Gold)); 
            builderHall.AddOrUpdateUpgrade(new BuildingUpgrade(5, 6, TimeSpan.FromDays(3).Ticks, 1200000, ResourceType.Gold));

            var clockTower = buildings.FirstOrDefault(b => b.Name == "Clock Tower");
            clockTower.AddOrUpdateUpgrade(new BuildingUpgrade(4, 1, TimeSpan.FromHours(2).Ticks, 150000, ResourceType.Gold));
            clockTower.AddOrUpdateUpgrade(new BuildingUpgrade(4, 2, TimeSpan.FromHours(3).Ticks, 180000, ResourceType.Gold));
            clockTower.AddOrUpdateUpgrade(new BuildingUpgrade(4, 3, TimeSpan.FromHours(4).Ticks, 220000, ResourceType.Gold));
            clockTower.AddOrUpdateUpgrade(new BuildingUpgrade(4, 4, TimeSpan.FromHours(6).Ticks, 300000, ResourceType.Gold));
            clockTower.AddOrUpdateUpgrade(new BuildingUpgrade(5, 5, TimeSpan.FromHours(8).Ticks, 700000, ResourceType.Gold));
            clockTower.AddOrUpdateUpgrade(new BuildingUpgrade(6, 6, TimeSpan.FromHours(10).Ticks, 1200000, ResourceType.Gold));

            var gemMine = buildings.FirstOrDefault(b => b.Name == "Gem Mine");
            gemMine.AddOrUpdateUpgrade(new BuildingUpgrade(3, 1, TimeSpan.FromHours(1).Ticks, 120000, ResourceType.Elixir));
            gemMine.AddOrUpdateUpgrade(new BuildingUpgrade(3, 2, TimeSpan.FromHours(2).Ticks, 180000, ResourceType.Elixir));
            gemMine.AddOrUpdateUpgrade(new BuildingUpgrade(4, 3, TimeSpan.FromHours(6).Ticks, 240000, ResourceType.Elixir));
            gemMine.AddOrUpdateUpgrade(new BuildingUpgrade(4, 4, TimeSpan.FromHours(8).Ticks, 450000, ResourceType.Elixir));
            gemMine.AddOrUpdateUpgrade(new BuildingUpgrade(5, 5, TimeSpan.FromHours(10).Ticks, 1000000, ResourceType.Elixir));
            gemMine.AddOrUpdateUpgrade(new BuildingUpgrade(6, 6, TimeSpan.FromHours(12).Ticks, 1500000, ResourceType.Elixir));

            var starLab = buildings.FirstOrDefault(b => b.Name == "Star Lab");
            starLab.AddOrUpdateUpgrade(new BuildingUpgrade(2, 1, 0, 1000, ResourceType.Elixir));
            starLab.AddOrUpdateUpgrade(new BuildingUpgrade(2, 2, TimeSpan.FromMinutes(10).Ticks, 15000, ResourceType.Elixir));
            starLab.AddOrUpdateUpgrade(new BuildingUpgrade(3, 3, TimeSpan.FromMinutes(30).Ticks, 50000, ResourceType.Elixir));
            starLab.AddOrUpdateUpgrade(new BuildingUpgrade(4, 4, TimeSpan.FromHours(8).Ticks, 300000, ResourceType.Elixir));
            starLab.AddOrUpdateUpgrade(new BuildingUpgrade(5, 5, TimeSpan.FromHours(12).Ticks, 700000, ResourceType.Elixir));
            starLab.AddOrUpdateUpgrade(new BuildingUpgrade(6, 6, TimeSpan.FromDays(1).Ticks, 1000000, ResourceType.Elixir));

            var battleAltar = buildings.FirstOrDefault(b => b.Name == "Battle Machine Altar");
            battleAltar.AddOrUpdateUpgrade(new BuildingUpgrade(5, 1, TimeSpan.FromHours(12).Ticks, 900000, ResourceType.Gold));

            var armyCamp = buildings.FirstOrDefault(b => b.Name == "Army Camp");
            armyCamp.AddOrUpdateUpgrade(new BuildingUpgrade(1, 1, 0, 0, ResourceType.Elixir));
            armyCamp.AddOrUpdateUpgrade(new BuildingUpgrade(2, 2, TimeSpan.FromMinutes(5).Ticks, 12000, ResourceType.Elixir));
            armyCamp.AddOrUpdateUpgrade(new BuildingUpgrade(3, 3, TimeSpan.FromHours(3).Ticks, 180000, ResourceType.Elixir));
            armyCamp.AddOrUpdateUpgrade(new BuildingUpgrade(4, 4, TimeSpan.FromHours(8).Ticks, 350000, ResourceType.Elixir));
            armyCamp.AddOrUpdateUpgrade(new BuildingUpgrade(4, 5, TimeSpan.FromDays(2).Ticks, 2500000, ResourceType.Elixir));

            var builderBarrack = buildings.FirstOrDefault(b => b.Name == "Builder Barrack");
            builderBarrack.AddOrUpdateUpgrade(new BuildingUpgrade(1, 1, 0, 1000, ResourceType.Elixir));
            builderBarrack.AddOrUpdateUpgrade(new BuildingUpgrade(2, 2, TimeSpan.FromMinutes(1).Ticks, 4000, ResourceType.Elixir));
            builderBarrack.AddOrUpdateUpgrade(new BuildingUpgrade(3, 3, TimeSpan.FromMinutes(10).Ticks, 10000, ResourceType.Elixir));
            builderBarrack.AddOrUpdateUpgrade(new BuildingUpgrade(3, 4, TimeSpan.FromMinutes(30).Ticks, 25000, ResourceType.Elixir));
            builderBarrack.AddOrUpdateUpgrade(new BuildingUpgrade(4, 5, TimeSpan.FromHours(3).Ticks, 100000, ResourceType.Elixir));
            builderBarrack.AddOrUpdateUpgrade(new BuildingUpgrade(4, 6, TimeSpan.FromHours(6).Ticks, 150000, ResourceType.Elixir));
            builderBarrack.AddOrUpdateUpgrade(new BuildingUpgrade(5, 7, TimeSpan.FromHours(8).Ticks, 300000, ResourceType.Elixir));
            builderBarrack.AddOrUpdateUpgrade(new BuildingUpgrade(6, 8, TimeSpan.FromHours(10).Ticks, 500000, ResourceType.Elixir));

            var elixirCollector = buildings.FirstOrDefault(b => b.Name == "Elixir Collector");
            elixirCollector.AddOrUpdateUpgrade(new BuildingUpgrade(2, 1, TimeSpan.FromMinutes(10).Ticks, 1000, ResourceType.Gold));
            elixirCollector.AddOrUpdateUpgrade(new BuildingUpgrade(2, 2, TimeSpan.FromMinutes(20).Ticks, 5000, ResourceType.Gold));
            elixirCollector.AddOrUpdateUpgrade(new BuildingUpgrade(3, 3, TimeSpan.FromMinutes(40).Ticks, 10000, ResourceType.Gold));
            elixirCollector.AddOrUpdateUpgrade(new BuildingUpgrade(4, 4, TimeSpan.FromHours(2).Ticks, 30000, ResourceType.Gold));
            elixirCollector.AddOrUpdateUpgrade(new BuildingUpgrade(5, 5, TimeSpan.FromHours(5).Ticks, 60000, ResourceType.Gold));
            elixirCollector.AddOrUpdateUpgrade(new BuildingUpgrade(6, 6, TimeSpan.FromHours(8).Ticks, 100000, ResourceType.Gold));

            var elixirStorage = buildings.FirstOrDefault(b => b.Name == "Elixir Storage");
            elixirStorage.AddOrUpdateUpgrade(new BuildingUpgrade(3, 1, TimeSpan.FromMinutes(30).Ticks, 20000, ResourceType.Gold));
            elixirStorage.AddOrUpdateUpgrade(new BuildingUpgrade(3, 2, TimeSpan.FromHours(1).Ticks, 80000, ResourceType.Gold));
            elixirStorage.AddOrUpdateUpgrade(new BuildingUpgrade(4, 3, TimeSpan.FromHours(3).Ticks, 200000, ResourceType.Gold));
            elixirStorage.AddOrUpdateUpgrade(new BuildingUpgrade(4, 4, TimeSpan.FromHours(6).Ticks, 300000, ResourceType.Gold));
            elixirStorage.AddOrUpdateUpgrade(new BuildingUpgrade(5, 5, TimeSpan.FromHours(8).Ticks, 600000, ResourceType.Gold));
            elixirStorage.AddOrUpdateUpgrade(new BuildingUpgrade(6, 6, TimeSpan.FromHours(10).Ticks, 1000000, ResourceType.Gold));

            var goldCollector = buildings.FirstOrDefault(b => b.Name == "Gold Collector");
            goldCollector.AddOrUpdateUpgrade(new BuildingUpgrade(2, 1, TimeSpan.FromMinutes(10).Ticks, 1000, ResourceType.Elixir));
            goldCollector.AddOrUpdateUpgrade(new BuildingUpgrade(2, 2, TimeSpan.FromMinutes(20).Ticks, 5000, ResourceType.Elixir));
            goldCollector.AddOrUpdateUpgrade(new BuildingUpgrade(3, 3, TimeSpan.FromMinutes(40).Ticks, 10000, ResourceType.Elixir));
            goldCollector.AddOrUpdateUpgrade(new BuildingUpgrade(4, 4, TimeSpan.FromHours(2).Ticks, 30000, ResourceType.Elixir));
            goldCollector.AddOrUpdateUpgrade(new BuildingUpgrade(5, 5, TimeSpan.FromHours(5).Ticks, 60000, ResourceType.Elixir));
            goldCollector.AddOrUpdateUpgrade(new BuildingUpgrade(6, 6, TimeSpan.FromHours(8).Ticks, 100000, ResourceType.Elixir));

            var goldStorage = buildings.FirstOrDefault(b => b.Name == "Gold Storage");
            goldStorage.AddOrUpdateUpgrade(new BuildingUpgrade(3, 1, TimeSpan.FromMinutes(30).Ticks, 20000, ResourceType.Elixir));
            goldStorage.AddOrUpdateUpgrade(new BuildingUpgrade(3, 2, TimeSpan.FromHours(1).Ticks, 80000, ResourceType.Elixir));
            goldStorage.AddOrUpdateUpgrade(new BuildingUpgrade(4, 3, TimeSpan.FromHours(3).Ticks, 200000, ResourceType.Elixir));
            goldStorage.AddOrUpdateUpgrade(new BuildingUpgrade(4, 4, TimeSpan.FromHours(6).Ticks, 300000, ResourceType.Elixir));
            goldStorage.AddOrUpdateUpgrade(new BuildingUpgrade(5, 5, TimeSpan.FromHours(8).Ticks, 600000, ResourceType.Elixir));
            goldStorage.AddOrUpdateUpgrade(new BuildingUpgrade(6, 6, TimeSpan.FromHours(10).Ticks, 1000000, ResourceType.Elixir));

            //Missing defensive buildings.
            //http://clashofclans.wikia.com/wiki/Gold_Storage/Builder_Base

            foreach (var b in buildings)
            {
                context.Buildings.Add(b);
            }
            context.SaveChanges();


        }
    }
}
