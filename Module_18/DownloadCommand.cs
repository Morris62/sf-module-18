using YoutubeExplodeNoPolytics;
using YoutubeExplodeNoPolytics.Converter;

namespace Module_18;

public class DownloadCommand(YoutubeClient client, string url, string output) : ICommand
{
    public async Task ExecuteAsync()
    {
        try
        {
            Console.WriteLine($"Старт загрузки видео {url}");
            await client.Videos.DownloadAsync(url, Path.Combine(Directory.GetCurrentDirectory(), output),
                builder => builder.SetPreset(ConversionPreset.UltraFast));
            Console.WriteLine($"Видео загружено: {output}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Ошибка загрузки видео: {e.Message}");
        }
    }
}
