using System.Collections.Generic;
using ClashCalculator.Common.Enum;
using ClashCalculator.Domain.Abstract;

namespace ClashCalculator.Domain
{
    public class Troop : Base
    {
        internal Troop()
        {

        }

        public Troop(string name, string description, string imageUrl, BaseVersion version) : base(name, description, imageUrl, version)
        {

        }
        public void AddOrUpdateUpgrade(TroopResearch research)
        {
            if (TroopResearches == null)
            {
                TroopResearches = new List<TroopResearch>();
            }
            else
            {
                var existentresearch = TroopResearches.Find(b => b.Level == research.Level);
                if (existentresearch != null)
                    TroopResearches.Remove(existentresearch);
            }
            TroopResearches.Add(research);
        }
        public TroopType Type { get; private set; }
        public List<TroopResearch> TroopResearches { get; private set; }
    }
}
