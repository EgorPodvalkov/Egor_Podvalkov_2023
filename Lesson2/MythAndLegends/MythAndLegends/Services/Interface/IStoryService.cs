using MythAndLegends.Data.Entity;

namespace MythAndLegends.Services.Interface;

public interface IStoryService
{
    public void AddStory(Story legend);

    public Story? GetStoryByCode(string code);
}