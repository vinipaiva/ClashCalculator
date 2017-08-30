using ClashCalculator.Database;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClashCalculator.Aggregate
{
    public abstract class BaseAggregate
    {
        protected readonly ClashCalculatorContext _dbContext;
        protected BaseAggregate(ClashCalculatorContext context)
        {
            _dbContext = context;
        }
    }
}
