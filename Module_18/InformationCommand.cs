using YoutubeExplodeNoPolytics;

namespace Module_18;

public class InformationCommand(YoutubeClient client, string url) : ICommand
{
    public async Task ExecuteAsync()
    {
        try
        {
            var video = await client.Videos.GetAsync(url);
            Console.WriteLine($"Название видео: {video.Title}");
            Console.WriteLine($"Описание: {video.Description}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Ошибка загрузки информации: {e.Message}");
        }
    }
}
