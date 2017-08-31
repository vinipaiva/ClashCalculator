using System;
using System.Collections.Generic;
using System.Text;
using ClashCalculator.Database.Seed;

namespace ClashCalculator.Database
{
    public static class DbInitializer
    {
        public static void Initialize(ClashCalculatorContext context)
        {
            context.Database.EnsureCreated();

            BuildingSeed.Seed(context);
            
        }
    }
}
