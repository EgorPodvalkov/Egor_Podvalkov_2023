using AutoMapper;
using Skeleton.BLL.Interfaces;
using Skeleton.BLL.Models;
using Skeleton.BLL.Models.AddModels;
using Skeleton.DAL.Entities;
using Skeleton.DAL.Interfaces;

namespace Skeleton.BLL.Services;

public class TestService : ITestService
{
    private readonly ITestRepository _testRepository;
    private readonly IMapper _mapper;

    public TestService(ITestRepository testRepository, IMapper mapper)
    {
        _testRepository = testRepository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<string>> GetTestsByUserIdAsync(Guid userId)
    {
        var tests = await _testRepository.GetTestsByUserIdAsync(userId);

        return tests.Select(x => x.Id.ToString());
    }

    public async Task<TestModel> GetTestWithQuestionsAsync(Guid id)
    {
        var entity = await _testRepository.GetByIdWithQuestionsAsync(id);

        return _mapper.Map<TestModel>(entity);
    }

    public async Task<string> GetTestDescriptionAsync(Guid id)
    {
        return await _testRepository.GetDescriptionAsync(id);
    }

    public async Task DeleteTestAsync(Guid id)
    {
        await _testRepository.DeleteAsync(id);
    }

    public async Task AddTestAsync(AddTestModel model)
    {
        var entity = _mapper.Map<Test>(model);

        await _testRepository.AddAsync(entity);
    }

    public async Task UpdateTestAsync(UpdateTestModel model)
    {
        var entity = await _testRepository.GetWithQuestionsAndAnswerAsync(Guid.Parse(model.Id));
        _mapper.Map(model, entity);

        await _testRepository.UpdateAsync(entity);
    }
}