using System;
using System.Collections.Generic;
using System.Text;
using CocCalculator.Domain.Abstract;
using CocCalculator.Domain.Enum;

namespace CocCalculator.Domain
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
