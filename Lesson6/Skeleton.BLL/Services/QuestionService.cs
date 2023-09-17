using AutoMapper;
using Skeleton.BLL.Interfaces;
using Skeleton.BLL.Models;
using Skeleton.DAL.Interfaces;

namespace Skeleton.BLL.Services;

public class QuestionService : IQuestionService
{
    private readonly IMapper _mapper;
    private readonly IQuestionRepository _questionRepository;

    public QuestionService(IQuestionRepository questionRepository, IMapper mapper)
    {
        _mapper = mapper;
        _questionRepository = questionRepository;
    }

    public async Task<IEnumerable<QuestionModel>> GetQuestionsByTestIdAsync(Guid testId)
    {
        var entities = await _questionRepository.GetAllByTestIdAsync(testId);

        return _mapper.Map<IEnumerable<QuestionModel>>(entities);
    }
}