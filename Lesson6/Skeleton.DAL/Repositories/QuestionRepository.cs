using Microsoft.EntityFrameworkCore;
using Skeleton.DAL.Context;
using Skeleton.DAL.Entities;
using Skeleton.DAL.Interfaces;

namespace Skeleton.DAL.Repositories;

public class QuestionRepository : BaseRepository<Question>, IQuestionRepository
{
    public QuestionRepository(QuizHubDatabaseContext dbContext) : base(dbContext)
    {
    }

    public async Task<IEnumerable<Question>> GetAllByTestIdAsync(Guid testId)
    {
        return await _dbContext.Set<Question>()
            .Where(x => x.TestId == testId)
            .ToListAsync();
    }
}