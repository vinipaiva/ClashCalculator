using System;
using System.ComponentModel.DataAnnotations.Schema;
using ClashCalculator.Domain.Enum;

namespace ClashCalculator.Domain.Abstract
{
    public abstract class Upgrade
    {
        protected Upgrade()
        {
            
        }
        protected Upgrade(int requirementLevel, int level, long timeInTicks, int amount, ResourceType resource)
        {
            RequirementLevel = requirementLevel;
            Level = level;
            TimeInTicks = timeInTicks;
            Amount = amount;
            Resource = resource;
        }
        public int RequirementLevel { get; protected set; }
        public int Level { get; protected set; }
        public long TimeInTicks { get; protected set; }
        public int Amount { get; protected set; }
        public ResourceType Resource { get; protected set; }

        [NotMapped]
        public TimeSpan Time
        {
            get => TimeSpan.FromTicks(TimeInTicks);
            set => TimeInTicks = value.Ticks;
        }
    }
}
