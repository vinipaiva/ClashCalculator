using System;
using System.Collections.Generic;
using System.Text;
using ClashCalculator.Common.Enum;

namespace ClashCalculator.Common.Model
{
    public class BuildingUpgradeModel
    {
        public int RequirementLevel { get; set; }
        public int Level { get; set; }
        public long TimeInTicks { get; set; }
        public int Amount { get; protected set; }
        public ResourceType Resource { get; set; }

        public TimeSpan Time
        {
            get => TimeSpan.FromTicks(TimeInTicks);
            set => TimeInTicks = value.Ticks;
        }
    }
}
