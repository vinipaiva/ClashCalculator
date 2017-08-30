using System.Collections.Generic;
using ClashCalculator.Domain.Abstract;
using ClashCalculator.Domain.Enum;

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
