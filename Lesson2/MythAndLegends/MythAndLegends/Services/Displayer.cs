using MythAndLegends.Data;
using MythAndLegends.Data.Entity;
using MythAndLegends.Services.Interface;

namespace MythAndLegends.Services;

public class Display : IDisplay
{
    private readonly IStoryService _storyService;
    
    public Display()
    {
        _storyService = new StoryService();
    }

    public void DisplayByCode(string code)
    {
        var story = _storyService.GetStoryByCode(code);

        if (story is not null)
        {
            story.Tell();
        }
        else
        {
            Console.WriteLine($"No myth or legend with code {code}");
        }
    }

    public void AddNewStory()
    {
        Console.WriteLine("Enter story type (myth/legend)");
        var input = Console.ReadLine();

        Story? story = null;

        if (input == "legend")
        {
            Console.WriteLine("Enter name of the legend");
            var name = Console.ReadLine();
            Console.WriteLine("Enter object of the legend");
            var storyObject = Console.ReadLine();
            Console.WriteLine("Enter the story");
            var storyText = Console.ReadLine();

            story = new Legend()
            {
                Name = name,
                Object = storyObject,
                Content = storyText
            };
            
        }
        else if (input == "myth")
        {
            Console.WriteLine("Enter name of the myth");
            var name = Console.ReadLine();
            Console.WriteLine("Enter the story");
            var storyText = Console.ReadLine();
            Console.WriteLine("Enter some fact");
            var fact = Console.ReadLine();

            story = new Myth()
            {
                Name = name,
                Fact = fact,
                Content = storyText
            };
            
        }

        if(story is not null)
        {
            _storyService.AddStory(story);
        }
        else
        {
            Console.WriteLine("Oops, wrong input");
        }
    }
}