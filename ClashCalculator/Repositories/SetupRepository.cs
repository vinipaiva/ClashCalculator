using Microsoft.EntityFrameworkCore;

namespace ClashCalculator.Database.Repositories
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
