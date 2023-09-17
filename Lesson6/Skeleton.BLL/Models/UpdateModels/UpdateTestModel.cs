﻿namespace Skeleton.BLL.Models.AddModels;

public class UpdateTestModel
{
    public string Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }

    public string CreatedForUserId { get; set; }

    public List<AddQuestionModel> Questions { get; set; }
}