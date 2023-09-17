using Skeleton.BLL.Models;

namespace Skeleton.BLL.Interfaces;

public interface IQuestionService
{
    public Task<IEnumerable<QuestionModel>> GetQuestionsByTestIdAsync(Guid testId);
    
    // todo: add CRUD functions
}