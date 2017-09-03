using ClashCalculator.Database;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClashCalculator.Repository
{
    public abstract class BaseRepository
    {
        protected readonly ClashCalculatorContext _dbContext;
        protected BaseRepository(ClashCalculatorContext context)
        {
            _dbContext = context;
        }
    }
}
