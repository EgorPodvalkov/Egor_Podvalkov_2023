using MythAndLegends.Data;
using MythAndLegends.Data.Entity;
using MythAndLegends.Services.Interface;

namespace MythAndLegends.Services;

public class StoryService : IStoryService
{
    public void AddStory(Story story)
    {
        if (string.IsNullOrEmpty(story.StoryCode))
        {
            story.StoryCode = CreateCode(story.Name);
        }

        Storage.MythsAndLegends.Add(story);
    }

    public Story? GetStoryByCode(string code)
    {
        return Storage.MythsAndLegends.FirstOrDefault(x => x.StoryCode.Equals(code));
    }
    
    private string CreateCode(string name)
    {
        var code = $"{name.First()}{name.Last()}-{name.Length}";

        return code;
    }
}