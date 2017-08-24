using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace CocCalculator.Database.Repositories
{
    public class SetupRepository
    {
        private readonly CocCalculatorContext _dbContext;
        public SetupRepository()
        {
            _dbContext = new CocCalculatorContext(new DbContextOptions<CocCalculatorContext>());
        }
    }
}
