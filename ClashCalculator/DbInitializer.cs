using System;
using System.Collections.Generic;
using System.Text;

namespace ClashCalculator.Database
{
    public static class DbInitializer
    {
        public static void Initialize(ClashCalculatorContext context)
        {
            context.Database.EnsureCreated();
            
        }
    }
}
