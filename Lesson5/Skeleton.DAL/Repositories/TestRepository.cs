using Microsoft.EntityFrameworkCore;
using Skeleton.DAL.Context;
using Skeleton.DAL.Entities;
using Skeleton.DAL.Interfaces;

namespace Skeleton.DAL.Repositories;

public class TestRepository : BaseRepository<Test>, ITestRepository
{
    public TestRepository(QuizHubDatabaseContext dbContext) : base(dbContext)
    {
    }

    public async Task<IEnumerable<Test>> GetTestsByUserIdAsync(Guid userId)
    {
        return await _dbContext.Set<Test>()
            .Where(x => x.CreatedForUserId == userId)
            .ToListAsync();
    }

    public async Task<Test> GetByIdWithQuestionsAsync(Guid id)
    {
        return await _dbContext.Set<Test>()
            .Where(x => x.Id == id)
            .Include(x => x.Questions)
            .FirstAsync();
    }

    public async Task<string> GetDescriptionAsync(Guid id)
    {
        var test = await GetByIdAsync(id);
        return test?.Description ?? "";
    }
}