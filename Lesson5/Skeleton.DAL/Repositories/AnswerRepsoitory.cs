using Microsoft.EntityFrameworkCore;
using Skeleton.DAL.Context;
using Skeleton.DAL.Entities;
using Skeleton.DAL.Interfaces;

namespace Skeleton.DAL.Repositories;

public class AnswerRepository : BaseRepository<Answer>, IAnswerRepository
{
    public AnswerRepository(QuizHubDatabaseContext dbContext) : base(dbContext)
    {
    }

    public async Task<bool> CheckIsCorrectAsync(Guid id)
    {
        var answer = await GetByIdAsync(id);
        return answer is not null && answer.IsCorrect;
    }

    public async Task<IEnumerable<Answer>> GetAllByQuestionIdAsync(Guid questionId)
    {
        return await _dbContext.Set<Answer>()
            .Where(x => x.QuestionId == questionId)
            .ToListAsync();
    }
}