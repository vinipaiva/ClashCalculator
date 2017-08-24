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

        public Troop(string name, string description, BaseVersion version) : base(name, description, version)
        {

        }
        public TroopType Type { get; private set; }
        public List<TroopResearch> TroopResearches { get; private set; }
    }
}
