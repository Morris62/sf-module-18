using Module_18;
using YoutubeExplodeNoPolytics;

var url = args.Any() ? args[0] : "https://www.youtube.com/watch?v=jNQXAC9IVRw";
var output = "test.mp4";
var client = new YoutubeClient();

var downloader = new Downloader();

// получение информации
var informationCommand = new InformationCommand(client, url);
downloader.SetCommand(informationCommand);
await downloader.ExecuteTaskAsync();

// загрузка видео
var downloadCommand = new DownloadCommand(client, url, output);
downloader.SetCommand(downloadCommand);
await downloader.ExecuteTaskAsync();
