using ClashCalculator.Domain.Abstract;
using ClashCalculator.Domain.Enum;

namespace ClashCalculator.Domain
{
    public class BuildingUpgrade : Upgrade
    {
        internal BuildingUpgrade()
        {
            
        }
        public BuildingUpgrade(int requirementLevel, int level, long timeInTicks, int amount, ResourceType resource): base(requirementLevel, level, timeInTicks, amount, resource)
        {
            
        }
        public int BuildingId { get; private set; }
        public Building Building { get; private set; }
    }
}
