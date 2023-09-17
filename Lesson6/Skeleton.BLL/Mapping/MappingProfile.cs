using AutoMapper;
using Skeleton.BLL.Models;
using Skeleton.BLL.Models.AddModels;
using Skeleton.BLL.Models.UpdateModels;
using Skeleton.DAL.Entities;

namespace Skeleton.BLL.Mapping;

public class AppMappingProfile : Profile
{
    public AppMappingProfile()
    {
        #region Answer
        CreateMap<Answer, AnswerModel>()
            .ForMember(model => model.Id,
                option => option.MapFrom(entity => entity.Id))
            .ForMember(model => model.Text,
                option => option.MapFrom(entity => entity.Text));

        CreateMap<AddAnswerModel, Answer>()
            .ForMember(entity => entity.Text,
                option => option.MapFrom(model => model.Text))
            .ForMember(entity => entity.QuestionId,
                option => option.MapFrom(model => Guid.Parse(model.QuestionId)))
            .ForMember(entity => entity.IsCorrect,
                option => option.MapFrom(model => model.IsCorrect));

        CreateMap<UpdateAnswerModel, Answer>()
            .ForMember(entity => entity.Id,
                option => option.MapFrom(model => Guid.Parse(model.Id)))
            .ForMember(entity => entity.Text,
                option => option.MapFrom(model => model.Text))
            .ForMember(entity => entity.IsCorrect,
                option => option.MapFrom(model => model.IsCorrect));
        #endregion

        #region Question
        CreateMap<Question, QuestionModel>()
            .ForMember(model => model.Id,
                option => option.MapFrom(entity => entity.Id))
            .ForMember(model => model.Text,
                option => option.MapFrom(entity => entity.Text));

        CreateMap<AddQuestionModel, Question>()
            .ForMember(entity => entity.Text,
                option => option.MapFrom(model => model.Text))
            .ForMember(entity => entity.TestId,
                option => option.MapFrom(model => Guid.Parse(model.TestId)))
            .ForMember(entity => entity.Answers,
                option => option.MapFrom(model => model.Answers));

        CreateMap<UpdateQuestionModel, Question>()
            .ForMember(entity => entity.Id,
                option => option.MapFrom(model => Guid.Parse(model.Id)))
            .ForMember(entity => entity.Text,
                option => option.MapFrom(model => model.Text))
            .ForMember(entity => entity.Answers,
                option => option.MapFrom(model => model.Answers));
        #endregion

        #region Test
        CreateMap<Test, TestModel>()
            .ForMember(model => model.Id,
                option => option.MapFrom(entity => entity.Id))
            .ForMember(model => model.Title,
                option => option.MapFrom(entity => entity.Title))
            .ForMember(model => model.Description,
                option => option.MapFrom(entity => entity.Description))
            .ForMember(model => model.QuestionIdList,
                option => option.MapFrom(entity =>
                    entity.Questions != null
                        ? entity.Questions.Select(x => x.Id.ToString())
                        : new List<string>()));

        CreateMap<AddTestModel, Test>()
            .ForMember(entity => entity.Title,
                option => option.MapFrom(model => model.Title))
            .ForMember(entity => entity.Description,
                option => option.MapFrom(model => model.Description))
            .ForMember(entity => entity.CreatedForUserId,
                option => option.MapFrom(model => Guid.Parse(model.CreatedForUserId)))
            .ForMember(entity => entity.Questions,
                option => option.MapFrom(model => model.Questions));

        CreateMap<UpdateTestModel, Test>()
            .ForMember(entity => entity.Id,
                option => option.MapFrom(model => Guid.Parse(model.Id)))
            .ForMember(entity => entity.Title,
                option => option.MapFrom(model => model.Title))
            .ForMember(entity => entity.Description,
                option => option.MapFrom(model => model.Description))
            .ForMember(entity => entity.CreatedForUserId,
                option => option.MapFrom(model => Guid.Parse(model.CreatedForUserId)))
            .ForMember(entity => entity.Questions,
                option => option.MapFrom(model => model.Questions));
        #endregion

        #region User
        CreateMap<User, UserModel>()
            .ForMember(model => model.Id,
                option => option.MapFrom(entity => entity.Id.ToString()))
            .ForMember(model => model.Name,
                option => option.MapFrom(entity => entity.Name))
            .ForMember(model => model.Surname,
                option => option.MapFrom(entity => entity.Surname));

        CreateMap<AddUserModel, User>()
            .ForMember(entity => entity.Name,
                option => option.MapFrom(model => model.Name))
            .ForMember(entity => entity.Surname,
                option => option.MapFrom(model => model.Surname))
            .ForMember(entity => entity.Password,
                option => option.MapFrom(model => model.Password));

        CreateMap<UpdateUserModel, User>()
            .ForMember(entity => entity.Id,
                option => option.MapFrom(model => Guid.Parse(model.Id)))
            .ForMember(entity => entity.Name,
                option => option.MapFrom(model => model.Name))
            .ForMember(entity => entity.Surname,
                option => option.MapFrom(model => model.Surname))
            .ForMember(entity => entity.Password,
                option => option.MapFrom(model => model.Password))
            .ForAllMembers(options => options.DoNotAllowNull());

        #endregion
    }
}