using Skeleton.BLL.Models;

namespace Skeleton.BLL.Interfaces;

public interface IAnswerService
{
    public Task<IEnumerable<AnswerModel>> GetAnswersByQuestionIdAsync(Guid questionId);
    public Task<bool> CheckAnswerByIdAsync(Guid id);
    
    // todo: Add CRUD functions
}