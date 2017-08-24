using ClashCalculator.Domain.Abstract;
using ClashCalculator.Domain.Enum;

namespace ClashCalculator.Domain
{
    public class TroopResearch : Upgrade
    {
        internal TroopResearch()
        {

        }
        public TroopResearch(int requirementLevel, int level, long timeInTicks, int amount, ResourceType resource): base(requirementLevel, level, timeInTicks, amount, resource)
        {

        }
        public int TroopId { get; private set; }
        public Troop Troop { get; private set; }

        public int Hitpoint { get; private set; }
        public int DamagePerSecond { get; private set; }
        public int UnitsPerCamp { get; private set; }
    }
}
