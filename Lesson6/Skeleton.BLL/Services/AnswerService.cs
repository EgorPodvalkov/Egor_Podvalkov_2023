using AutoMapper;
using Skeleton.BLL.Interfaces;
using Skeleton.BLL.Models;
using Skeleton.DAL.Interfaces;

namespace Skeleton.BLL.Services;

public class AnswerService : IAnswerService
{
    private readonly IMapper _mapper;
    private readonly IAnswerRepository _answerRepository;

    public AnswerService(IAnswerRepository answerRepository, IMapper mapper)
    {
        _mapper = mapper;
        _answerRepository = answerRepository;
    }

    public async Task<IEnumerable<AnswerModel>> GetAnswersByQuestionIdAsync(Guid questionId)
    {
        var answers = await _answerRepository.GetAllByQuestionIdAsync(questionId);

        return _mapper.Map<IEnumerable<AnswerModel>>(answers);
    }

    public async Task<bool> CheckAnswerByIdAsync(Guid id)
    {
        return await _answerRepository.CheckIsCorrectAsync(id);
    }
}